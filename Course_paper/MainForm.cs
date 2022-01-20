using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace CoursePaper
{
    public partial class MainForm : Form
    {
        private readonly AutorizationForm autorization;
        private List<Contact> contacts = new List<Contact>();
        private Database database = new Database();
        private MySqlDataReader reader;

        public MainForm(AutorizationForm autorization)
        {
            InitializeComponent();
            this.autorization = autorization;
            searchNameField.Text = "Введите имя";
            searchNameField.ForeColor = Color.Gray;
            AddTableHeader();
            FillTable();
        }

        private void AddTableHeader()
        {
            var column1 = new DataGridViewColumn
            {
                HeaderText = "Имя",
                Width = 485,
                Name = "name",
                Frozen = true,
                CellTemplate = new DataGridViewTextBoxCell()
            };

            var column2 = new DataGridViewColumn
            {
                HeaderText = "Номер",
                Width = 285,
                Name = "number",
                CellTemplate = new DataGridViewTextBoxCell()
            };

            TblContacts.Columns.Add(column1);
            TblContacts.Columns.Add(column2);
        }

        private void MainFormEnabledChanged(object sender, EventArgs e)
        {
            Clear();
            FillTable();
        }

        private void Clear()
        {
            contacts.Clear();
            TblContacts.DataSource = null;
            TblContacts.Rows.Clear();
        }

        private void FillTable()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `contacts` ORDER BY `name` ASC", database.Connection);

            try
            {
                database.OpenConnection();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Contact contact = new Contact(reader["name"].ToString(), reader["number"].ToString());
                    contacts.Add(contact);
                }

                AddContactRows();

                lblContactNumber.Text = contacts.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при заполнение таблицы!\n{ex}");
            }
            finally
            {
                database.CloseConnection();
            }
        }

        private void AddContactRows()
        {
            contacts.ForEach(contact => TblContacts.Rows.Add(contact.Name, contact.Number));
        }

        private void BtnSearchClick(object sender, EventArgs e)
        {
            if (searchNameField.Text == "Введите имя")
            {
                return;
            }

            SearchContact(searchNameField.Text);
        }

        private void SearchContact(string searchedName)
        {
            BinarySearch binarySearch = new BinarySearch(contacts.ToArray());

            Contact foundContact = binarySearch.Search(searchedName);

            bool ContactIsFound = foundContact != null;

            if (ContactIsFound)
            {
                MessageBox.Show($"Контакт найден: {foundContact.Name} {foundContact.Number}");
            }

            if (!ContactIsFound)
            {
                MessageBox.Show("Контакт не найден");
            }
        }

        private void TlMenuUpdateClick(object sender, EventArgs e)
        {
            Clear();
            FillTable();
        }

        private void TlMenuContactAddClick(object sender, EventArgs e)
        {
            ContactAddForm contactAddForm = new ContactAddForm(this);
            contactAddForm.Show();
        }

        private void TlMenuReferenceClick(object sender, EventArgs e)
        {
            Reference referenceForm= new Reference(this);
            referenceForm.Show();
        }

        private void TlMenuContactDeleteClick(object sender, EventArgs e)
        {
            ContactDeleteForm contactDeleteForm = new ContactDeleteForm(this);
            contactDeleteForm.Show();
        }

        private void TlMenuExitClick(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Вы действительно хотите выйти из программы?", "Завершение программы", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void MainFormClosing(object sender, FormClosingEventArgs e)
        {
            autorization.Show();
        }

        private void SearchNameEnter(object sender, EventArgs e)
        {
            if (searchNameField.Text == "Введите имя")
            {
                searchNameField.Text = "";
                searchNameField.ForeColor = Color.Black;
            }
        }

        private void SearchNameLeave(object sender, EventArgs e)
        {
            searchNameField.Text = searchNameField.Text.Trim();

            if (searchNameField.Text == "")
            {
                searchNameField.Text = "Введите имя";
                searchNameField.ForeColor = Color.Gray;
            }
        }
    }
}