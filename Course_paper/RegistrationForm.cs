using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Course_paper
{
    public partial class RegistrationForm : Form
    {
        AutorizationForm autorization;
        public RegistrationForm(AutorizationForm autorization)
        {
            InitializeComponent();
            this.autorization = autorization;
            autorization.Enabled = false;
            NameField.Text = "Введите имя";
            NameField.ForeColor = Color.Gray;
            SurnameField.Text = "Введите фамилию";
            SurnameField.ForeColor = Color.Gray;
            LoginField.Text = "Введите логин";
            LoginField.ForeColor = Color.Gray;
            PassField.Text = "Введите пароль";
            PassField.ForeColor = Color.Gray;
        }

        private void NameField_Enter(object sender, EventArgs e)
        {
            if (NameField.Text == "Введите имя")
            {
                NameField.Text = "";
                NameField.ForeColor = Color.Black;
            }
        }

        private void NameField_Leave(object sender, EventArgs e)
        {
            if (NameField.Text == "")
            {
                NameField.Text = "Введите имя";
                NameField.ForeColor = Color.Gray;
            }
        }

        private void SurnameField_Enter(object sender, EventArgs e)
        {
            if (SurnameField.Text == "Введите фамилию")
            {
                SurnameField.Text = "";
                SurnameField.ForeColor = Color.Black;
            }
        }

        private void SurnameField_Leave(object sender, EventArgs e)
        {
            if (SurnameField.Text == "")
            {
                SurnameField.Text = "Введите фамилию";
                SurnameField.ForeColor = Color.Gray;
            }
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

        private void ButtonRegistration_Click(object sender, EventArgs e)
        {
            if (NameField.Text == "Введите имя")
            {
                MessageBox.Show("Не все поля заполнены!");
                return;
            }

            if (SurnameField.Text == "Введите фамилию")
            {
                MessageBox.Show("Не все поля заполнены!");
                return;
            }

            if (LoginField.Text == "Введите логин")
            {
                MessageBox.Show("Не все поля заполнены!");
                return;
            }

            if (PassField.Text == "Введите пароль")
            {
                MessageBox.Show("Не все поля заполнены!");
                return;
            }

            if (IsUserExists())
                return;

            Database database = new Database();

            MySqlCommand command = new MySqlCommand("INSERT INTO users (`login`, `pass`, `Name`, `Surname`) VALUES (@login, @pass, @name, @surname)", database.GetConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = LoginField.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = PassField.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = NameField.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = SurnameField.Text;

            database.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                this.Hide();
                MessageBox.Show("Вы зарегистрировались!");
                autorization.Enabled = true;
            }
            else
                MessageBox.Show("Аккаунт с таким логином уже существует!");

            database.CloseConnection();
        }

        public bool IsUserExists()
        {
            Database database = new Database();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", database.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = LoginField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Введенный логин уже занят другим пользователем!");
                return true;
            }
            else
                return false;
        }

        private void RegistrationLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            autorization.Enabled = true;
            autorization.Show();
        }
    }
}