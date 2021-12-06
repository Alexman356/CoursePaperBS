using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Course_paper
{
    public partial class AutorizationForm : Form
    {
        public AutorizationForm()
        {
            InitializeComponent();
            LoginField.Text = "Введите логин";
            LoginField.ForeColor = Color.Gray;
            PassField.Text = "Введите пароль";
            PassField.ForeColor = Color.Gray;
        }

        private void ButtonAutorization_Click(object sender, EventArgs e)
        {
            if ((LoginField.Text == "Введите логин") || (PassField.Text == "Введите пароль"))
            {
                MessageBox.Show("Не все поля заполнены!");
                return;
            }

            String loginUser = LoginField.Text;
            String passUser = PassField.Text;

            Database database = new Database();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `pass` = @uP", database.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Вы авторизованы!");
                this.Hide();
                MainForm main = new MainForm();
                main.Show();
            }
            else
                MessageBox.Show("Введен неверный логин или пароль");
        }

        private void LoginField_Enter(object sender, EventArgs e)
        {
            if (LoginField.Text == "Введите логин")
            {
                LoginField.Text = "";
                LoginField.ForeColor = Color.Black;
            }
        }
        private void LoginField_Leave(object sender, EventArgs e)
        {
            if (LoginField.Text == "")
            {
                LoginField.Text = "Введите логин";
                LoginField.ForeColor = Color.Gray;
            }
        }
        private void PassField_Enter(object sender, EventArgs e)
        {
            if (PassField.Text == "Введите пароль")
            {
                PassField.Text = "";
                PassField.ForeColor = Color.Black;
                PassField.UseSystemPasswordChar = true;
            }
        }
        private void PassField_Leave(object sender, EventArgs e)
        {
            if (PassField.Text == "")
            {
                PassField.UseSystemPasswordChar = false;
                PassField.Text = "Введите пароль";
                PassField.ForeColor = Color.Gray;
            }
        }

        private void RegistrationLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm registration = new RegistrationForm(this);
            registration.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Вы действительно хотите выйти из программы?", "Завершение программы", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void AutorizationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            Application.Exit();
        }
    }
}
