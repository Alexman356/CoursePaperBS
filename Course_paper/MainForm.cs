using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Course_paper
{
    public partial class MainForm : Form
    {
        AutorizationForm autorization = new AutorizationForm();

        List<ContactDatabase> _data = new List<ContactDatabase>();
        public MainForm()
        {
            InitializeComponent();
        }
        private void AddDataGrid(ContactDatabase table)
        {
            DataTable.Rows.Add(table.Name, table.Number);
        }
        private void TableHeader()
        {
            var column1 = new DataGridViewColumn();
            column1.HeaderText = "Имя";
            column1.Width = 485;
            column1.Name = "name";
            column1.Frozen = true;
            column1.CellTemplate = new DataGridViewTextBoxCell();

            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Номер";
            column2.Width = 285;
            column2.Name = "number";
            column2.CellTemplate = new DataGridViewTextBoxCell();

            DataTable.Columns.Add(column1);
            DataTable.Columns.Add(column2);
         }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            TableHeader();

            Database database = new Database();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `contacts` ORDER BY `name` ASC", database.GetConnection());
            MySqlDataReader reader;

            database.OpenConnection();
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                ContactDatabase table = new ContactDatabase(reader["name"].ToString(), reader["number"].ToString());
                _data.Add(table);
            }

            for (int i = 0; i < _data.Count; i++)
                AddDataGrid(_data[i]);

            lbl_contact_number.Text = _data.Count.ToString();
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _data.Clear();

            Database _manager = new Database();
            MySqlCommand _command = new MySqlCommand("SELECT * FROM `contacts` ORDER BY `name` ASC", _manager.GetConnection());
            MySqlDataReader _reader;

            DataTable.DataSource = null;
            DataTable.Rows.Clear();

            _manager.OpenConnection();
            _reader = _command.ExecuteReader();

            while (_reader.Read())
            {
                ContactDatabase table = new ContactDatabase(_reader["name"].ToString(), _reader["number"].ToString());
                _data.Add(table);
            }

            for (int i = 0; i < _data.Count; i++)
            {
                AddDataGrid(_data[i]);
            }

            lbl_contact_number.Text = _data.Count.ToString();
        }
        private void добавитьКонтактToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddСontactForm add = new AddСontactForm(this);
            add.Show();
        }
        private void выходИзПрограммыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            autorization.Show();
        }
        private void удалитьКонтактToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteContactForm delete = new DeleteContactForm(this);
            delete.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            autorization.Show();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            BinarySearch.Wanted_char_array = tb_search_name.Text.ToCharArray();
            int status = BinarySearch.SearchContact(_data);

            if (status == -1) MessageBox.Show("Контакт не найден");
            if (status != -1) MessageBox.Show($"Контакт найден: {_data[status].Name} {_data[status].Number}");
        }

        private void обToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reference reference = new Reference(this);
            reference.Show();
        }
    }
}
