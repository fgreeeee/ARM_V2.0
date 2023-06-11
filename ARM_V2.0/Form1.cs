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
using System.Threading;

namespace ARM_V2._0
{

    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }

    public partial class Form1 : Form
    {
        Thread th;

        DataBase database = new DataBase();
        
        int selectedRow;

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("ID_Klient", "ID Клиента");
            dataGridView1.Columns.Add("Surname", "Фамилия");
            dataGridView1.Columns.Add("Name", "Имя");
            dataGridView1.Columns.Add("Patroyamic", "Отчество");
            dataGridView1.Columns.Add("Sex", "ПОл");
            dataGridView1.Columns.Add("Date_Birth", "Дата рождения");
            dataGridView1.Columns.Add("Date_OfIssue", "Дата Выдачи Пас.");
            dataGridView1.Columns.Add("Pass_Serial", "Серия");
            dataGridView1.Columns.Add("Pass_Number", "Номер");
            dataGridView1.Columns.Add("City", "Город");
            dataGridView1.Columns.Add("District", "Район");
            dataGridView1.Columns.Add("Street", "Улица");
            dataGridView1.Columns.Add("House", "Дом");
            dataGridView1.Columns.Add("Flat_Number", "Квартира"); 
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }

        private void ReadSingleRow(DataGridView dwg, IDataRecord record)
        {
            dwg.Rows.Add( record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetDateTime(5), record.GetDateTime(6), record.GetString(7), record.GetString(8),
                record.GetString(9), record.GetString(10), record.GetString(11), record.GetString(12), record.GetString(13),  RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dwg)
        {
            dwg.Rows.Clear();

            string queryString = $"select * from Klient";

            SqlCommand command = new SqlCommand(queryString, database.getConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dwg, reader);
            }
            reader.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }


        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = $"select * from Klient where concat (ID_Klient, Surname_Klient, Name_Klient, Patroyamic_Klient, Sex, Date_Birth, Date_OfIssue, Pass_Serial, Pass_Number, City, District, Street, House, Flat_Number) like '%" + Text_Find.Text + "%'";

            SqlCommand com = new SqlCommand(searchString, database.getConnection());

            database.openConnection();
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

        private void DeleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[index].Visible = false;

            if (dataGridView1.Rows[index].Cells[0].Value.ToString() != string.Empty)
            {
                dataGridView1.Rows[index].Cells[8].Value = RowState.Deleted;
                return;
            }
        }


        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            int ID_Klient;
            var Surname_Klient = Text_ID.Text;
            var Name_Klient = text_KOD.Text;
            var Patroyamic_Klient = text_PROD.Text;
            var Sex = text_STAT1.Text;
            var Date_Birth = text_DATE.Text;
            var City = text_PRICE.Text;
            var Date_OfIssue = text_DATE.Text;

            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if(int.TryParse(text_IDKLIENT.Text, out ID_Klient))
                dataGridView1.Rows[selectedRowIndex].SetValues(ID_Klient, Surname_Klient, Name_Klient, Patroyamic_Klient, Sex, Date_Birth, City, Date_OfIssue);
                dataGridView1.Rows[selectedRowIndex].Cells[8].Value = RowState.Modified;
            }

        }

        private void RTN_CHANGE_Click(object sender, EventArgs e)
        {
            Change();
        }


        private void UpdateTab()
        {
            database.openConnection();

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[8].Value;

                if (rowState == RowState.Existed)
                {
                    continue;
                }

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from Divilery where id = {id}";

                    var command = new SqlCommand(deleteQuery, database.getConnection());
                    command.ExecuteNonQuery();

                }

                if (rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var Code = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var Product = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var Stat = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var Payment = dataGridView1.Rows[index].Cells[4].Value.ToString();
                    var Price = dataGridView1.Rows[index].Cells[5].Value.ToString();
                    var ID_Klient = dataGridView1.Rows[index].Cells[6].Value.ToString();
                    var Date_Div = dataGridView1.Rows[index].Cells[7].Value.ToString();


                    var changeQuery = $"update Divilery set Product = '{Product}', Code = '{Code}', Stat = '{Stat}', Payment = '{Payment}', Price = '{Price}', ID_klient = '{ID_Klient}', Date_Div = '{Date_Div}' where id = '{id}'";
                    var command = new SqlCommand(changeQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }
            }
            database.closeConnection();
        }


        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            UpdateTab();
        }

        private void BTN_DELETE_Click(object sender, EventArgs e)
        {
            DeleteRow();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                Text_ID.Text = row.Cells[0].Value.ToString();
                text_KOD.Text = row.Cells[1].Value.ToString();
                text_PROD.Text = row.Cells[2].Value.ToString();
                text_STAT1.Text = row.Cells[3].Value.ToString();
                text_PAY1.Text = row.Cells[4].Value.ToString();
                text_PRICE.Text = row.Cells[5].Value.ToString();
                text_IDKLIENT.Text = row.Cells[6].Value.ToString();
                text_DATE.Text = row.Cells[7].Value.ToString();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(open);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        public void open(object obj)
        {
            Application.Run(new Form2());
        }

        
    }


}
