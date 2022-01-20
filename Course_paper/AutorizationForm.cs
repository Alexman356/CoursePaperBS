using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CoursePaper
{
    public partial class AutorizationForm : Form
    {
        public AutorizationForm()
        {
            InitializeComponent();
        }

        private void AutorizationFormVisibleChanged(object sender, EventArgs e)
        {
            loginField.Text = "Введите логин";
            loginField.ForeColor = Color.Gray;
            passField.UseSystemPasswordChar = false;
            passField.Text = "Введите пароль";
            passField.ForeColor = Color.Gray;
        }

        private void BtnAutorizationClick(object sender, EventArgs e)
        {
            if ((loginField.Text == "Введите логин") || (passField.Text == "Введите пароль"))
            {
                MessageBox.Show("Не все поля заполнены!");

                return;
            }

            Autorization(loginField.Text, passField.Text);
        }

        private void Autorization(string login, string pass)
        {
            Database database = new Database();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `pass` = @uP", database.Connection);

            try
            {
                command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login;
                command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = pass;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                bool autorizationIsSuccessfull = table.Rows.Count > 0;

                if (autorizationIsSuccessfull)
                {
                    MessageBox.Show("Вы авторизованы!");
                    Hide();
                    MainForm main = new MainForm(this);
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при авторизации!\n{ex}");
            }
            finally
            {
                database.CloseConnection();
            }
        }

        private void LinkToRegistrationClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm registration = new RegistrationForm(this);
            registration.Show();
            Hide();
        }

        private void BtnExitClick(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Вы действительно хотите выйти из программы?", "Завершение программы", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void LoginFieldEnter(object sender, EventArgs e)
        {
            if (loginField.Text == "Введите логин")
            {
                loginField.Text = "";
                loginField.ForeColor = Color.Black;
            }
        }

        private void LoginFieldLeave(object sender, EventArgs e)
        {
            loginField.Text = loginField.Text.Trim();

            if (loginField.Text == "")
            {
                loginField.Text = "Введите логин";
                loginField.ForeColor = Color.Gray;
            }
        }

        private void PassFieldEnter(object sender, EventArgs e)
        {
            if (passField.Text == "Введите пароль")
            {
                passField.Text = "";
                passField.ForeColor = Color.Black;
                passField.UseSystemPasswordChar = true;
            }
        }

        private void PassFieldLeave(object sender, EventArgs e)
        {
            passField.Text = passField.Text.Trim();

            if (passField.Text == "")
            {
                passField.UseSystemPasswordChar = false;
                passField.Text = "Введите пароль";
                passField.ForeColor = Color.Gray;
            }
        }
    }
}
