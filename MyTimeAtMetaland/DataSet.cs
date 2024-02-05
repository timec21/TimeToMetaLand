using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace TimeToMetaLand
{
    public partial class DataSet : UserControl
    {
        NpgsqlDataAdapter adapter;
        DataTable dataTable;
        NpgsqlConnection connection = new NpgsqlConnection("server=localHost; port=5432; Database=MetaLand; user ID=postgres; password=admin");
        public GameScreen gameScreen;
        public Game game;
        public DataSet()
        {
            InitializeComponent();
        }

        private void DataSet_Load(object sender, EventArgs e)
        {


            using (NpgsqlConnection connection = new NpgsqlConnection("server=localHost; port=5432; Database=MetaLand; user ID=postgres; password=admin"))
            {
                connection.Open();

                DataTable tableNames = connection.GetSchema("Tables");

                foreach (DataRow row in tableNames.Rows)
                {
                    string tableName = row["TABLE_NAME"].ToString();
                    comboBox1.Items.Add(tableName);
                }

                connection.Close();
            }
        }
        private void LoadData()
        {


            connection.Open();

            adapter = new NpgsqlDataAdapter("SELECT * FROM " + comboBox1.Text, connection);
            dataTable = new DataTable();
            adapter.Fill(dataTable);


            if (dataTable.Rows.Count > 0)
            {
                dataGridView1.Columns.Clear();

                foreach (DataColumn column in dataTable.Columns)
                {
                    dataGridView1.Columns.Add(column.ColumnName, column.ColumnName);
                }

                foreach (DataColumn column in dataTable.Columns)
                {
                    dataGridView1.Columns[column.ColumnName].DataPropertyName = column.ColumnName;
                }

                dataGridView1.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("Veri bulunamadı.");
            }

            connection.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.Open();
            if (dataTable != null)
            {

                using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("SELECT * FROM users", connection))
                {
                    NpgsqlCommandBuilder commandBuilder = new NpgsqlCommandBuilder(dataAdapter);
                    dataAdapter.Update(dataTable);
                }

            }
            else
            {
                MessageBox.Show("Lütfen önce sütunları göster butonuna basınız.");
            }
            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
            int id = 0;
            string query = "";

            connection.Open();
            if (comboBox1.Text == "users")
            {
                query = "DELETE FROM users WHERE user_id = @id";
                id = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["user_id"].Value);
            }
            else if (comboBox1.Text == "field")
            {
                query = "DELETE FROM field WHERE field_id = @id";
                id = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["field_id"].Value);
            }
            else if (comboBox1.Text == "grocery")
            {
                query = "DELETE FROM grocery WHERE grocery_field_id = @id";
                id = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["grocery_field_id"].Value);
            }
            else if (comboBox1.Text == "shop")
            {
                query = "DELETE FROM shop WHERE shop_field_id = @id";
                id = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["shop_field_id"].Value);
            }
            else if (comboBox1.Text == "business")
            {
                query = "DELETE FROM business WHERE business_field_id = @id";
                id = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["business_field_id"].Value);
            }
            else if (comboBox1.Text == "real_estate")
            {
                query = "DELETE FROM real_estate WHERE real_estate_field_id = @id";
                id = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["real_estate_field_id"].Value);
            }
            else if (comboBox1.Text == "employee")
            {
                query = "DELETE FROM employee WHERE employee_id = @id";
                id = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["employee_id"].Value);
            }
            else if (comboBox1.Text == "game")
            {
                query = "DELETE FROM game WHERE game_id = @id";
                id = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["game_id"].Value);
            }


            using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
                connection.Close();
                dataGridView1.Rows.RemoveAt(selectedRowIndex);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //exit
            game.updatePlayer();
            gameScreen.Visible = true;
            this.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button6.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.Dock = DockStyle.Fill;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            button6.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
