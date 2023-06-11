using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ARM_V2._0
{
    public partial class Login : Form
    {

        DataBase database = new DataBase(); 
        public Login()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void singin_Click(object sender, EventArgs e)
        {
            var loginUser = textlogin.Text;
            var passUser = textpass.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select login_user, password_user from employee where login_user='{loginUser}' and password_user = '{passUser}'";

            SqlCommand command = new SqlCommand(querystring, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 frm1 = new Form1();
                this.Hide();
                frm1.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textpass.PasswordChar = '*';
        }

        private void exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
