using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TimeToMetaLand
{
    public partial class MarketScreen : UserControl
    {
        public GameScreen gameScreen;
        internal Game game;
        public int marketId;
        public List<System.Windows.Forms.Button> land;
        NpgsqlConnection connection = new NpgsqlConnection("server=localHost; port=5432; Database=MetaLand; user ID=postgres; password=admin");
        int amount = 0;
        int price = 0;
        public MarketScreen()
        {
            InitializeComponent();
            for (int i = 0; i <= 40; i++)
            {
                comboBox1.Items.Add(i);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void Market_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //exit
            comboBox1.SelectedIndex = 0;
            this.Visible = false;
            gameScreen.Visible = true;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //buy


            string sqlQuery = "UPDATE users SET money_quantity = money_quantity - @Price WHERE user_id = " + Convert.ToString(gameScreen.users[0].Item3) + ";";
            string sqlQuery2 = "UPDATE users SET food_quantity = money_quantity + @Amount WHERE user_id = " + Convert.ToString(gameScreen.users[0].Item3) + ";";

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
                NpgsqlCommand command2 = new NpgsqlCommand("SELECT field.field_owner_id FROM business JOIN field ON @marketId = field.field_id", connection);
                command2.Parameters.AddWithValue("@marketId", marketId);
                var ownerId = command2.ExecuteScalar();
                command.Parameters.AddWithValue("@v1", ownerId);
                command.Parameters.AddWithValue("@Price", Convert.ToInt32(textBox1.Text));
                command2.ExecuteNonQuery();
                command.ExecuteNonQuery();
                connection.Close();
            }

            MessageBox.Show("alındı");

            game.updatePlayer();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            amount = comboBox1.SelectedIndex;

            string sqlQuery = "SELECT grocery_food_price FROM grocery WHERE grocery_field_id = @v1";
            connection.Open();
            using (NpgsqlCommand command = new NpgsqlCommand(sqlQuery, connection))
            {
                command.Parameters.AddWithValue("@v1", marketId);
                using (NpgsqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        price = reader.GetInt32(0);
                    }
                }
            }
            connection.Close();
            textBox1.Text = (amount * price).ToString();

        }
    }
}
