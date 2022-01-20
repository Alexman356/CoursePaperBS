using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CoursePaper
{
    public partial class RegistrationForm : Form
    {
        readonly AutorizationForm autorization;
        Database database = new Database();

        public RegistrationForm(AutorizationForm autorization)
        {
            InitializeComponent();
            this.autorization = autorization;
            NameField.Text = "Введите имя";
            NameField.ForeColor = Color.Gray;
            SurnameField.Text = "Введите фамилию";
            SurnameField.ForeColor = Color.Gray;
            LoginField.Text = "Введите логин";
            LoginField.ForeColor = Color.Gray;
            PassField.Text = "Введите пароль";
            PassField.ForeColor = Color.Gray;
        }

        private void BtnRegistrationClick(object sender, EventArgs e)
        {
            if (NameField.Text == "Введите имя" || SurnameField.Text == "Введите фамилию"
                || LoginField.Text == "Введите логин" || PassField.Text == "Введите пароль")
            {
                MessageBox.Show("Не все поля заполнены!");

                return;
            }

            if (UserIsExists(LoginField.Text))
            {
                return;
            }

            Registration(LoginField.Text, PassField.Text, NameField.Text, SurnameField.Text);
        }

        private bool UserIsExists(string login)
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", database.Connection);

            try
            {
                command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                bool loginIsFound = table.Rows.Count > 0;

                if (loginIsFound)
                {
                    MessageBox.Show("Логин уже занят другим пользователем!");

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при проверке логина!\n{ex}");

                return true;
            }
            finally
            {
                database.CloseConnection();
            }
        }

        private void Registration(string login, string pass, string name, string surname)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO users (`login`, `pass`, `Name`, `Surname`) VALUES (@login, @pass, @name, @surname)", database.Connection);

            try
            {
                command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login;
                command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass;
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = surname;

                database.OpenConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Вы зарегистрировались!");
                    autorization.Enabled = true;
                    Close();
                }

                database.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при регистрации!\n{ex}");
            }
            finally
            {
                database.CloseConnection();
            }
        }

        private void LinkToRegistrationClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            autorization.Show();
            Close();
        }

        private void BtnExitClick(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Вы действительно хотите выйти из программы?", "Завершение программы", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void RegistrationFormClosing(object sender, FormClosingEventArgs e)
        {
            autorization.Show();
        }

        private void NameFieldEnter(object sender, EventArgs e)
        {
            if (NameField.Text == "Введите имя")
            {
                NameField.Text = "";
                NameField.ForeColor = Color.Black;
            }
        }

        private void NameFieldLeave(object sender, EventArgs e)
        {
            NameField.Text = NameField.Text.Trim();

            if (NameField.Text == "")
            {
                NameField.Text = "Введите имя";
                NameField.ForeColor = Color.Gray;
            }
        }

        private void SurnameFieldEnter(object sender, EventArgs e)
        {
            if (SurnameField.Text == "Введите фамилию")
            {
                SurnameField.Text = "";
                SurnameField.ForeColor = Color.Black;
            }
        }

        private void SurnameFieldLeave(object sender, EventArgs e)
        {
            SurnameField.Text = SurnameField.Text.Trim();

            if (SurnameField.Text == "")
            {
                SurnameField.Text = "Введите фамилию";
                SurnameField.ForeColor = Color.Gray;
            }
        }

        private void LoginFieldEnter(object sender, EventArgs e)
        {
            if (LoginField.Text == "Введите логин")
            {
                LoginField.Text = "";
                LoginField.ForeColor = Color.Black;
            }
        }

        private void LoginFieldLeave(object sender, EventArgs e)
        {
            LoginField.Text = LoginField.Text.Trim();

            if (LoginField.Text == "")
            {
                LoginField.Text = "Введите логин";
                LoginField.ForeColor = Color.Gray;
            }
        }

        private void PassFieldEnter(object sender, EventArgs e)
        {
            if (PassField.Text == "Введите пароль")
            {
                PassField.Text = "";
                PassField.ForeColor = Color.Black;
                PassField.UseSystemPasswordChar = true;
            }
        }

        private void PassFieldLeave(object sender, EventArgs e)
        {
            PassField.Text = PassField.Text.Trim();

            if (PassField.Text == "")
            {
                PassField.UseSystemPasswordChar = false;
                PassField.Text = "Введите пароль";
                PassField.ForeColor = Color.Gray;
            }
        }
    }
}