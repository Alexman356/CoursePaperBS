using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CoursePaper
{
    public partial class ContactAddForm : Form
    {
        private readonly MainForm mainForm;
        private Database database = new Database();

        public ContactAddForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            mainForm.Enabled = false;
            nameField.Text = "Имя";
            nameField.ForeColor = Color.Gray;
            numberField.Text = "Номер телефона";
            numberField.ForeColor = Color.Gray;
        }

        private void AddContact(Contact contact)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO contacts (`name`, `number`) VALUES (@name, @number)", database.Connection);

            try
            {
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = contact.Name;
                command.Parameters.Add("@number", MySqlDbType.VarChar).Value = contact.Number;

                database.OpenConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Контакт добавлен!");
                }
                else
                {
                    MessageBox.Show("Введенные имя или телефон уже существуют в телефонной книге!");
                }

                database.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении контакта!\n{ex}");
            }
            finally
            {
                database.CloseConnection();
            }
        }

        private bool ContactIsValid(Contact contact)
        {
            if (!RegisterIsValid(contact.Name))
            {
                MessageBox.Show("Имя должно быть с заглавной буквы!");

                return false;
            }

            if (ContactIsExist(contact))
            {
                MessageBox.Show("Введенные имя или телефон уже существуют в телефонной книге!");

                return false;
            }

            return true;
        }

        private bool RegisterIsValid(string name)
        {
            char firstLetter = name.ToCharArray()[0];

            if (firstLetter.ToString() == firstLetter.ToString().ToLower())
            {
                return false;
            }

            return true;
        }

        private bool ContactIsExist(Contact contact)
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `contacts` WHERE `name` = @name OR `number` = @number", database.Connection);

            try
            {
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = contact.Name;
                command.Parameters.Add("@number", MySqlDbType.VarChar).Value = contact.Number;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                bool contactIsFound = table.Rows.Count > 0;

                if (contactIsFound)
                {
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при проверке контакта!\n{ex}");

                return false;
            }
            finally
            {
                database.CloseConnection();
            }
        }

        private void СontactAddFormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Enabled = true;
        }

        private void BtnAddClick(object sender, EventArgs e)
        {
            if (nameField.Text == "Имя" || numberField.Text == "Номер телефона")
            {
                MessageBox.Show("Не все поля заполнены!");

                return;
            }

            Contact contact = new Contact(nameField.Text, numberField.Text);

            if (!ContactIsValid(contact))
            {
                return;
            }

            AddContact(contact);
        }

        private void BtnBackClick(object sender, EventArgs e)
        {
            Close();
        }

        private void NameEnter(object sender, EventArgs e)
        {
            if (nameField.Text == "Имя")
            {
                nameField.Text = "";
                nameField.ForeColor = Color.Black;
            }
        }

        private void NameLeave(object sender, EventArgs e)
        {
            nameField.Text = nameField.Text.Trim();

            if (nameField.Text == "")
            {
                nameField.Text = "Имя";
                nameField.ForeColor = Color.Gray;
            }
        }

        private void NumberEnter(object sender, EventArgs e)
        {
            if (numberField.Text == "Номер телефона")
            {
                numberField.Text = "";
                numberField.ForeColor = Color.Black;
            }
        }

        private void NumberLeave(object sender, EventArgs e)
        {
            numberField.Text = numberField.Text.Trim();

            if (numberField.Text == "")
            {
                numberField.Text = "Номер телефона";
                numberField.ForeColor = Color.Gray;
            }
        }
    }
}
