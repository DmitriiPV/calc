using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALC
{
    public class DB
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=calc");
    
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        public MySqlConnection getConnection()
        {
            return connection;
        }
        public int Aut(string user, string pass)
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `login` WHERE `username` = @u AND `password` = @p", db.getConnection());

            command.Parameters.Add("@u", MySqlDbType.VarChar).Value = user;
            command.Parameters.Add("@p", MySqlDbType.VarChar).Value = pass;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Добро пожаловать!");
                Form2 form2 = new Form2();
                form2.Hide();
                Form1 form1 = new Form1();
                form1.Show();
                return 1;
            }
            else
            {
                MessageBox.Show("Неверные данные для входа!");
                return 0;

            }
        }
    }

}
