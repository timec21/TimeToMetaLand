using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeToMetaLand
{
    public partial class ShopScreen : UserControl
    {
        public GameScreen gameScreen;
        public Game game;
        public int shopId;
        int amount = 0;
        int price = 0;
        public NpgsqlConnection connection = new NpgsqlConnection("server=localHost; port=5432; Database=MetaLand; user ID=postgres; password=admin");


        public ShopScreen()
        {
            InitializeComponent();
            for (int i = 0; i <= 40; i++)
            {
                comboBox1.Items.Add(i);
            }
            comboBox1.SelectedIndex = 0;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            amount = comboBox1.SelectedIndex;

            string sqlQuery = "SELECT shop_item_price FROM shop WHERE shop_field_id = @v1";

            connection.Open();
            using (NpgsqlCommand command = new NpgsqlCommand(sqlQuery, connection))
            {
                command.Parameters.AddWithValue("@v1", shopId);
                using (NpgsqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        price = reader.GetInt32(0);
                    }
                }
            }
            connection.Close();
            textBox2.Text = (amount * price).ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string sqlQuery = "UPDATE users SET money_quantity = money_quantity - @Price WHERE user_id = " + Convert.ToString(gameScreen.newUsers[0].Item3) + ";";
            string sqlQuery2 = "UPDATE users SET item_quantity = item_quantity + @Amount WHERE user_id = " + Convert.ToString(gameScreen.newUsers[0].Item3) + ";";

            connection.Open();
            NpgsqlCommand query = new NpgsqlCommand(sqlQuery, connection);
            NpgsqlCommand query2 = new NpgsqlCommand(sqlQuery2, connection);
            query.Parameters.AddWithValue("@Price", price * amount);
            query2.Parameters.AddWithValue("@Amount", amount);

            query.ExecuteNonQuery();
            query2.ExecuteNonQuery();
            connection.Close();

            using (NpgsqlCommand command = new NpgsqlCommand("UPDATE users SET money_quantity = money_quantity + @Price WHERE user_id = @v1", connection))
            {
                connection.Open();
                NpgsqlCommand command2 = new NpgsqlCommand("SELECT field.field_owner_id FROM business JOIN field ON @shopId = field.field_id", connection);
                command2.Parameters.AddWithValue("@shopId", shopId);
                var ownerId = command2.ExecuteScalar();
                command.Parameters.AddWithValue("@v1", ownerId);
                command.Parameters.AddWithValue("@Price", Convert.ToInt32(textBox2.Text));
                command2.ExecuteNonQuery();
                command.ExecuteNonQuery();
                connection.Close();
            }

            MessageBox.Show("alındı");

            game.updatePlayer();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //exit
            comboBox1.SelectedIndex = 0;
            this.Visible = false;
            gameScreen.Visible = true;
        }

        private void ShopScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
