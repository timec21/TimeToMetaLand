using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace TimeToMetaLand
{
    public partial class LoginScreen : UserControl
    {
        public GameScreen gameScreen;
        public AdminScreen adminScreen;
        public Game game;
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }
        NpgsqlConnection connection = new NpgsqlConnection("server=localHost; port=5432; Database=MetaLand; user Id=postgres;" +
            "password=admin ");
        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand add = new NpgsqlCommand("insert into users(name, surname, password, user_game_id, food_quantity, item_quantity, money_quantity, game_start_date, alive) values(@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9)", connection);
            add.Parameters.AddWithValue("@p1", textBox1.Text);
            add.Parameters.AddWithValue("@p2", textBox2.Text);
            add.Parameters.AddWithValue("@p3", textBox3.Text);
            add.Parameters.AddWithValue("@p4", 1);
            add.Parameters.AddWithValue("@p5", Convert.ToInt32(adminScreen.textBox1.Text));
            add.Parameters.AddWithValue("@p6", Convert.ToInt32(adminScreen.textBox2.Text));
            add.Parameters.AddWithValue("@p7", Convert.ToInt32(adminScreen.textBox3.Text));
            add.Parameters.AddWithValue("@p8", game.gameDate);
            add.Parameters.AddWithValue("@p9", true);
            add.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("eklnedi");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //play button

            this.Visible = false;
            gameScreen.Visible = true;
            game.createMap();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //admin button
            this.Visible = false;
            adminScreen.Visible = true;
        }
    }
}
