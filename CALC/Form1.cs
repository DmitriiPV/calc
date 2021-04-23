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
            string sqrt = label1.Text;
            string[] last = sqrt.Split('+', '-', '*', '/','(');
            bool fl=false;
            int index = 0;
            for (int i = sqrt.Length - 1; i >= 0; i--)
            {
                if ((sqrt[i] == '+') || (sqrt[i] == '-') || (sqrt[i] == '*') || (sqrt[i] == '/') || (sqrt[i] == '('))
                {
                    index = i;
                    fl = true;
                    break;
                }
            }
            if (fl == true)
            sqrt = sqrt.Remove(index + 1);
            else
            sqrt = sqrt.Remove(index);
            string sqr = last.Last();
            string sqr1 = sqr.Replace(")", "");
            double a = Convert.ToDouble(sqr1);
            double sum = Math.Sqrt(a);
            label1.Text = sqrt + sum.ToString();

        }

        private void x2btn_Click(object sender, EventArgs e)
        {
            string sqrt = label1.Text;
            string[] last = sqrt.Split('+', '-', '*', '/', '(');
            bool fl = false;
            int index = 0;
            for (int i = sqrt.Length - 1; i >= 0; i--)
            {
                if ((sqrt[i] == '+') || (sqrt[i] == '-') || (sqrt[i] == '*') || (sqrt[i] == '/') || (sqrt[i] == '('))
                {
                    index = i;
                    fl = true;
                    break;
                }
            }
            if (fl == true)
                sqrt = sqrt.Remove(index + 1);
            else
                sqrt = sqrt.Remove(index);
            string sqr = last.Last();
            string sqr1 = sqr.Replace(")", "");
            double a = Convert.ToDouble(sqr1);
            double sum = Math.Pow(a,2);
            label1.Text = sqrt + sum.ToString();
        }

        private void sinbtn_Click(object sender, EventArgs e)
        {
            string sin = label1.Text;
            string[] last = sin.Split('+', '-', '*', '/', '(');
            bool fl = false;
            int index = 0;
            for (int i = sin.Length - 1; i >= 0; i--)
            {
                if ((sin[i] == '+') || (sin[i] == '-') || (sin[i] == '*') || (sin[i] == '/') || (sin[i] == '('))
                {
                    index = i;
                    fl = true;
                    break;
                }
            }
            if (fl == true)
                sin = sin.Remove(index + 1);
            else
                sin = sin.Remove(index);
            string si = last.Last();
            string sin1 = si.Replace(")", "");
            double a = Convert.ToDouble(sin1);
            double sum = Math.Sin(a);
            label1.Text = sin + sum.ToString();
        }

        private void cosbtn_Click(object sender, EventArgs e)
        {
            string cos = label1.Text;
            string[] last = cos.Split('+', '-', '*', '/', '(');
            bool fl = false;
            int index = 0;
            for (int i = cos.Length - 1; i >= 0; i--)
            {
                if ((cos[i] == '+') || (cos[i] == '-') || (cos[i] == '*') || (cos[i] == '/') || (cos[i] == '('))
                {
                    index = i;
                    fl = true;
                    break;
                }
            }
            if (fl == true)
                cos = cos.Remove(index + 1);
            else
                cos = cos.Remove(index);
            string co = last.Last();
            string cos1 = co.Replace(")", "");
            double a = Convert.ToDouble(cos1);
            double sum = Math.Cos(a);
            label1.Text = cos + sum.ToString();
        }

        private void tgbtn_Click(object sender, EventArgs e)
        {
            string tgn = label1.Text;
            string[] last = tgn.Split('+', '-', '*', '/', '(');
            bool fl = false;
            int index = 0;
            for (int i = tgn.Length - 1; i >= 0; i--)
            {
                if ((tgn[i] == '+') || (tgn[i] == '-') || (tgn[i] == '*') || (tgn[i] == '/') || (tgn[i] == '('))
                {
                    index = i;
                    fl = true;
                    break;
                }
            }
            if (fl == true)
                tgn = tgn.Remove(index + 1);
            else
                tgn = tgn.Remove(index);
            string tg = last.Last();
            string tgn1 = tg.Replace(")", "");
            double a = Convert.ToDouble(tgn1);
            double sum = Math.Tan(a);
            label1.Text = tgn + sum.ToString();
        }

        private void nbtn_Click(object sender, EventArgs e)
        {
            string fib = label1.Text;
            string[] last = fib.Split('+', '-', '*', '/', '(');
            bool fl = false;
            int index = 0;
            for (int i = fib.Length - 1; i >= 0; i--)
            {
                if ((fib[i] == '+') || (fib[i] == '-') || (fib[i] == '*') || (fib[i] == '/') || (fib[i] == '('))
                {
                    index = i;
                    fl = true;
                    break;
                }
            }
            if (fl == true)
                fib = fib.Remove(index + 1);
            else
                fib = fib.Remove(index);
            string fi = last.Last();
            string fib1 = fi.Replace(")", "");
            int a = Convert.ToInt32(fib1);  
            int factorial = 1;   
            for (int i = 2; i <= a; i++) 
            {
                factorial *= i;
            }
            label1.Text = fib + factorial.ToString();
        }
    }
}
