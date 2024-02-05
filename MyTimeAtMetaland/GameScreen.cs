using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace TimeToMetaLand
{
    public partial class GameScreen : UserControl
    {
        public Panel panel;
        public DataSet dataSet;
        public Game game;
        NpgsqlConnection connection = new NpgsqlConnection("server=localHost; port=5432; Database=MetaLand; user Id=postgres;" +
            "password=admin ");
        NpgsqlDataReader reader;
        NpgsqlCommand query;
        public List<Tuple<string, string, int>> users;
        public List<Tuple<string, string, int>> newUsers;
        public GameScreen()
        {
            InitializeComponent();


        }


        private void GameScreen_Load(object sender, EventArgs e)
        {

        }
        public void startGame()
        {
            panel = panel1 as Panel;
            users = ReadData();
            newUsers = ReadData();
            show_player();
        }

        public void show_player()
        {
            label5.Text = Convert.ToString(game.gameDate);
            if (users.Count > 0)
            {
                label1.Text = users[0].Item1 + " " + users[0].Item2;
                connection.Open();
                query = new NpgsqlCommand("Select name, surname from users where user_id = " + Convert.ToString(users[0].Item3) + ";", connection);
                reader = query.ExecuteReader();
                reader.Read();
                string name = reader.GetString(0);
                string surname = reader.GetString(1);
                connection.Close();


                connection.Open();
                query = new NpgsqlCommand("Select food_quantity from users where user_id=" + Convert.ToString(users[0].Item3) + ";", connection);
                query.ExecuteNonQuery();
                var foodQuantity = query.ExecuteScalar();

                query.CommandText = "Select item_quantity from users where user_id=" + Convert.ToString(users[0].Item3) + ";";
                query.ExecuteNonQuery();
                var itemQuantity = query.ExecuteScalar();

                query.CommandText = "Select money_quantity from users where user_id=" + Convert.ToString(users[0].Item3) + ";";
                query.ExecuteNonQuery();
                var moneyQuantity = query.ExecuteScalar();

                label2.Text = moneyQuantity.ToString();
                label3.Text = itemQuantity.ToString();
                label4.Text = foodQuantity.ToString();
                connection.Close();
                users.RemoveAt(0);
            }
            else
            {
                users = ReadData();

                foreach (var user in users)
                {
                    using (NpgsqlConnection connection = new NpgsqlConnection("server=localHost; port=5432; Database=MetaLand; user ID=postgres; password=admin"))
                    {
                        connection.Open();
                        NpgsqlCommand command = new NpgsqlCommand("SELECT daily_food_expense, daily_money_expense, daily_item_expense FROM game where game_id = 1", connection);

                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            reader.Read();
                            int dailyFoodExpense = reader.GetInt16(0);
                            int dailyMoneyExpense = reader.GetInt32(1);
                            int dailyItemExpense = reader.GetInt32(2);
                            connection.Close();

                            connection.Open();
                            NpgsqlCommand query = new NpgsqlCommand("UPDATE users SET food_quantity = food_quantity - @foodExpense, money_quantity = money_quantity - @moneyExpense, item_quantity = item_quantity - @itemExpense where user_id = @user_id", connection);
                            query.Parameters.AddWithValue("foodExpense", dailyFoodExpense);
                            query.Parameters.AddWithValue("moneyExpense", dailyMoneyExpense);
                            query.Parameters.AddWithValue("itemExpense", dailyItemExpense);
                            query.Parameters.AddWithValue("user_id", user.Item3);
                            query.ExecuteNonQuery();

                            command = new NpgsqlCommand("SELECT food_quantity, item_quantity FROM users where user_id = @v1", connection);
                            command.Parameters.AddWithValue("@v1", user.Item3);
                            using (NpgsqlDataReader reader1 = command.ExecuteReader())
                            {
                                reader1.Read();
                                if (reader1.GetInt32(0) <= 0 || reader1.GetInt32(1) <= 0)
                                {
                                    connection.Close();
                                    connection.Open();
                                    command = new NpgsqlCommand("UPDATE users SET alive = @v1 WHERE user_id = @v2", connection);
                                    command.Parameters.AddWithValue("@v1", false);
                                    command.Parameters.AddWithValue("@v2", user.Item3);
                                    command.ExecuteNonQuery();
                                    connection.Close();
                                }
                            }

                        }
                        connection.Close();
                    }
                }

                users = ReadData();
                newUsers = ReadData();
                game.gameDate = game.gameDate.AddDays(1);
                show_player();

            }
        }


        public List<Tuple<string, string, int>> ReadData()
        {
            List<Tuple<string, string, int>> usersData = new List<Tuple<string, string, int>>();


            using (NpgsqlConnection connection = new NpgsqlConnection("server=localHost; port=5432; Database=MetaLand; user Id=postgres;password=admin "))
            {
                connection.Open();

                string query = "SELECT column_name FROM table_name";
                using (NpgsqlCommand command = new NpgsqlCommand("Select name, surname, user_id, alive from users order by user_id OFFSET 1", connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = reader.GetString(0);
                            string surname = reader.GetString(1);
                            int id = reader.GetInt32(2);
                            Tuple<string, string, int> tuple = new Tuple<string, string, int>(name, surname, id);
                            if (reader.GetBoolean(3))
                                usersData.Add(tuple);
                        }
                    }
                }

                connection.Close();
            }

            return usersData;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (newUsers.Count != 1)
                newUsers.RemoveAt(0);
            show_player();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataSet.Visible = true;
            this.Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Convert.ToInt32(textBox1.Text); i++)
            {
                while (newUsers.Count > 0)
                {
                    if (newUsers.Count != 1)
                    { newUsers.RemoveAt(0); }
                    else
                    {
                        show_player();
                        break;
                    }

                    show_player();


                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
