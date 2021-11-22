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
    public partial class Form1 : Form
    {
        Calculate ob = new Calculate();
        ConvertStr cstr = new ConvertStr();
        public Form1()
        {
            InitializeComponent();
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void rghtbtn_Click(object sender, EventArgs e)
        {
            label1.Text += ")";
        }

        private void lftbtn_Click(object sender, EventArgs e)
        {
            label1.Text += "(";
        }

        private void equalbtn_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {

                DB db = new DB();

                MySqlCommand command = new MySqlCommand("INSERT INTO `history` (`hist`) VALUES (@hist)", db.getConnection());

                command.Parameters.Add("@hist", MySqlDbType.VarChar).Value = label1.Text;

                db.openConnection();

                command.ExecuteNonQuery();

                MySqlCommand command1 = new MySqlCommand("SELECT * FROM `history` WHERE `id` = (SELECT MAX(`id`) FROM `history`)", db.getConnection());

                MySqlDataReader rd;

                rd = command1.ExecuteReader();

                while (rd.Read())
                {
                    label2.Text = rd["hist"].ToString();
                }
                db.closeConnection();
                db.openConnection();
                MySqlCommand delete = new MySqlCommand("DELETE FROM `history`", db.getConnection());
                delete.ExecuteNonQuery();
                db.closeConnection();
                label1.Text = ob.result(label1.Text).ToString();
            }
        }

        private void divbtn_Click(object sender, EventArgs e)
        {
            label1.Text += "/";
        }

        private void multbtn_Click(object sender, EventArgs e)
        {
            label1.Text += "*";
        }

        private void minusbtn_Click(object sender, EventArgs e)
        {
            label1.Text += "-";
        }

        private void plusbtn_Click(object sender, EventArgs e)
        {
            label1.Text += "+";
        }

        private void pointbtn_Click(object sender, EventArgs e)
        {
            label1.Text += ",";
        }

        private void ninebtn_Click(object sender, EventArgs e)
        {
            label1.Text += "9";
        }

        private void eightbtn_Click(object sender, EventArgs e)
        {
            label1.Text += "8";
        }

        private void sevenbtn_Click(object sender, EventArgs e)
        {
            label1.Text += "7";
        }

        private void sixbtn_Click(object sender, EventArgs e)
        {
            label1.Text += "6";
        }

        private void fivebtn_Click(object sender, EventArgs e)
        {
            label1.Text += "5";
        }

        private void fourbtn_Click(object sender, EventArgs e)
        {
            label1.Text += "4";
        }

        private void threebtn_Click(object sender, EventArgs e)
        {
            label1.Text += "3";
        }

        private void twobtn_Click(object sender, EventArgs e)
        {
            label1.Text += "2";
        }

        private void onebtn_Click(object sender, EventArgs e)
        {
            label1.Text += "1";
        }

        private void zerobtn_Click(object sender, EventArgs e)
        {
            label1.Text += "0";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string ec = "e";

            DB db = new DB();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `constant` WHERE `const_name` = @e", db.getConnection());

            command.Parameters.Add("@e", MySqlDbType.VarChar).Value = ec;
            db.openConnection();

            MySqlDataReader rd;

            rd = command.ExecuteReader();

            while (rd.Read())
            {
                label1.Text += rd["const_value"].ToString();
            }
            db.closeConnection();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string pi = "pi";

            DB db = new DB();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `constant` WHERE `const_name` = @pi", db.getConnection());

            command.Parameters.Add("@pi", MySqlDbType.VarChar).Value = pi;
            db.openConnection();

            MySqlDataReader rd;

            rd = command.ExecuteReader();

            while (rd.Read())
            {
                label1.Text += rd["const_value"].ToString();
            }
            db.closeConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "sqrt";
            try
            {
            label1.Text = cstr.Calcfnc(label1.Text,s);
            }
            catch
            {
                MessageBox.Show("Ошибка, неверный ввод");
            }
        }

        private void x2btn_Click(object sender, EventArgs e)
        {
            string s = "x2";
            try
            {
            label1.Text = cstr.Calcfnc(label1.Text, s);
            }
            catch
            {
                MessageBox.Show("Ошибка, неверный ввод");
            }
        }

        private void sinbtn_Click(object sender, EventArgs e)
        {
            string s = "sin";
            try
            {
                label1.Text = cstr.Calcfnc(label1.Text, s);
            }
            catch
            {
                MessageBox.Show("Ошибка, неверный ввод");
            }
        }

        private void cosbtn_Click(object sender, EventArgs e)
        {
            string s = "cos";
            try
            {
                label1.Text = cstr.Calcfnc(label1.Text, s);
            }
            catch
            {
                MessageBox.Show("Ошибка, неверный ввод");
            }
        }

        private void tgbtn_Click(object sender, EventArgs e)
        {
            string s = "tgn";
            try
            {
                label1.Text = cstr.Calcfnc(label1.Text, s);
            }
            catch
            {
                MessageBox.Show("Ошибка, неверный ввод");
            }
        }

        private void nbtn_Click(object sender, EventArgs e)
        {
            string s = "fib";
            try
            {
                label1.Text = cstr.Calcfnc(label1.Text, s);
            }
            catch
            {
                MessageBox.Show("Ошибка, неверный ввод");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
