using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;

namespace ARM_V2._0
{
    public partial class Form2 : Form
    {
        Thread th;
        DataBase database1 = new DataBase();
        public Form2()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(open);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }

        public void open(object obj)
        {
            Application.Run(new Form1());
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("FIO", "ФИО");
            dataGridView1.Columns.Add("NUMBER", "Телефон");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }

        private void ReadSingleRow(DataGridView dwg, IDataRecord record)
        {
            dwg.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dwg)
        {
            dwg.Rows.Clear();

            string queryString = $"select * from Klient";

            SqlCommand command = new SqlCommand(queryString, database1.getConnection());

            database1.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dwg, reader);
            }
            reader.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = $"select * from Klient where concat (Id_Klient, Fio, Number) like '%" + Text_Find.Text + "%'";

            SqlCommand com = new SqlCommand(searchString, database1.getConnection());

            database1.openConnection();
            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRow(dgw, read);
            }

            read.Close();
        }

        private void Text_Find_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }
    }
}
