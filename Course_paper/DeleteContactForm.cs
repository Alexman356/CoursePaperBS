using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Course_paper
{
    public partial class DeleteContactForm : Form
    {
        MainForm mainform;
        public DeleteContactForm(MainForm mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
            mainform.Enabled = false;
            name.Text = "Введите имя";
            name.ForeColor = Color.Gray;
        }

        private void name_Enter(object sender, EventArgs e)
        {
            if (name.Text == "Введите имя")
            {
                name.Text = "";
                name.ForeColor = Color.Black;
            }
        }
        private void name_Leave(object sender, EventArgs e)
        {
            if (name.Text == "")
            {
                name.Text = "Введите имя";
                name.ForeColor = Color.Gray;
            }
        }

        private void DeleteContactForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            mainform.Enabled = true;
        }
        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool NameVerification()
        {
            Database database = new Database();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `contacts` WHERE `name` = @name", database.GetConnection());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                return true;

            else
                return false;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (name.Text == "Введите имя")
            {
                MessageBox.Show("Не все поля заполнены!");
                return;
            }

            if (!NameVerification())
            {
                MessageBox.Show("Введенное имя не существует в телефонной книге!");
                return;
            }

            Database database = new Database();
            MySqlCommand command = new MySqlCommand("DELETE FROM `contacts` WHERE `name` = @name", database.GetConnection());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name.Text;

            try
            {
                database.OpenConnection();
                command.ExecuteNonQuery();
                MessageBox.Show("Контакт удален!");
            }
            catch(Exception ex)
            {
               MessageBox.Show($"{ex}");
               MessageBox.Show("Введенное имя не существует в телефонной книге!");
            }
            database.CloseConnection();
        }
    }
}
