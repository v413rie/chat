using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chat
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            usernameField.Text = "Введите имя";
            usernameField.ForeColor = Color.Red;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastPoint;
        private void RegisterForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void RegisterForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void usernameField_Enter(object sender, EventArgs e)
        {
            if (usernameField.Text == "Введите имя")
            {
                usernameField.Text = "";
                usernameField.ForeColor = Color.Black;
            }
        }

        private void usernameField_Leave(object sender, EventArgs e)
        {
            if (usernameField.Text == "")
            {
                usernameField.ForeColor = Color.Red;
                usernameField.Text = "Введите имя";
            }
        }

        private void userSurnameField_Enter(object sender, EventArgs e)
        {
            if (usernameField.Text == "Введите фамилию")
            {
                usernameField.Text = "";
                usernameField.ForeColor = Color.Black;
            }
        }

        private void userSurnameField_Leave(object sender, EventArgs e)
        {
            {
                usernameField.ForeColor = Color.Red;
                usernameField.Text = "Введите фамиию";
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (usernameField.Text == "Введите имя")
            {
                MessageBox.Show("Введите имя");
                return;
            }
            if (userSurnameField.Text == "")
            {
                MessageBox.Show("Введите фамилию");
                return;
            }

            if (isUserExists(usernameField))
                return;

            DB dB = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`, `name`, `surname`) VALUES (@login, @password, @name, @surname);", dB.getConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginField.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = passField.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = usernameField.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = userSurnameField.Text;

            dB.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Аккаунт создан");
            else
                MessageBox.Show("Аккаунт не создан");

            dB.closeConnection();


        }

        private bool isUserExists(TextBox usernameField)
        {
            return false;
        }

        public Boolean checkUser()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();


            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже существует");
                return true;
            }
            else
                return false;
        }
    }
}
