using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CoursePaper
{
    public partial class ContactDeleteForm : Form
    {
        readonly MainForm mainForm;
        Database database = new Database();

        public ContactDeleteForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            mainForm.Enabled = false;
            nameField.Text = "Имя";
            nameField.ForeColor = Color.Gray;
        }

        private void BtnDeleteClick(object sender, EventArgs e)
        {
            if (nameField.Text == "Имя")
            {
                MessageBox.Show("Не все поля заполнены!");

                return;
            }

            if (!ContactIsExist())
            {
                MessageBox.Show("Контакт не существует в телефонной книге!");

                return;
            }

            DeleteContact();
        }

        private bool ContactIsExist()
        {
            try
            {
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("SELECT * FROM `contacts` WHERE `name` = @name", database.Connection);

                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = nameField.Text;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                bool contactIsFound = table.Rows.Count > 0;

                if (contactIsFound)
                {
                    return true;
                }
                else
                {
                    return false;
                }
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

        private void DeleteContact()
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `contacts` WHERE `name` = @name", database.Connection);

            try
            {
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = nameField.Text;

                database.OpenConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Контакт удален!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении контакта!\n{ex}");
            }
            finally
            {
                database.CloseConnection();
            }
        }

        private void ContactDeleteFormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Enabled = true;
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
    }
}
