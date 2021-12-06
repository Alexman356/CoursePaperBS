using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Course_paper
{
    public partial class AddСontactForm : Form
    {

        MainForm mainform;
        public AddСontactForm(MainForm mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
            mainform.Enabled = false;
            tb_name.Text = "Введите имя";
            tb_name.ForeColor = Color.Gray;
            tb_number.Text = "Введите номер телефона";
            tb_number.ForeColor = Color.Gray;
        }

        private void name_Enter(object sender, EventArgs e)
        {
            if (tb_name.Text == "Введите имя")
            {
                tb_name.Text = "";
                tb_name.ForeColor = Color.Black;
            }
        }
        private void name_Leave(object sender, EventArgs e)
        {
            if (tb_name.Text == "")
            {
                tb_name.Text = "Введите имя";
                tb_name.ForeColor = Color.Gray;
            }
        }
        private void number_Enter(object sender, EventArgs e)
        {
            if (tb_number.Text == "Введите номер телефона")
            {
                tb_number.Text = "";
                tb_number.ForeColor = Color.Black;
            }
        }
        private void number_Leave(object sender, EventArgs e)
        {
            if (tb_number.Text == "")
            {
                tb_number.Text = "Введите номер телефона";
                tb_number.ForeColor = Color.Gray;
            }
        }

        private void AddСontactForm_FormClosing(object sender, FormClosingEventArgs e)
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
            for (int i = 1040; i < 1072; i++)
                if (tb_name.Text.ToCharArray()[0] == i)
                {
                    Database database = new Database();

                    DataTable table = new DataTable();

                    MySqlDataAdapter adapter = new MySqlDataAdapter();

                    MySqlCommand command = new MySqlCommand("SELECT * FROM `contacts` WHERE `name` = @name OR `number` = @number", database.GetConnection());
                    command.Parameters.Add("@name", MySqlDbType.VarChar).Value = tb_name.Text;
                    command.Parameters.Add("@number", MySqlDbType.VarChar).Value = tb_number.Text;

                    adapter.SelectCommand = command;
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        MessageBox.Show("Введенные имя или телефон уже существуют в телефонной книге!");
                        return true;
                    }
                    else
                        return false;
                }
            MessageBox.Show("Введенное имя должно быть с заглавной буквы!");
            return true;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (tb_name.Text == "Введите имя")
            {
                MessageBox.Show("Не все поля заполнены!");
                return;
            }

            if (tb_number.Text == "Введите номер телефона")
            {
                MessageBox.Show("Не все поля заполнены!");
                return;
            }

            if (NameVerification())
                return;

            Database database = new Database();

            MySqlCommand command = new MySqlCommand("INSERT INTO contacts (`name`, `number`) VALUES (@name, @number)", database.GetConnection());

            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = tb_name.Text;
            command.Parameters.Add("@number", MySqlDbType.VarChar).Value = tb_number.Text;

            database.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Контакт добавлен!");
            }
            else
                MessageBox.Show("Введенные имя или телефон уже существуют в телефонной книге!");

            database.CloseConnection();
        }
    }
}
