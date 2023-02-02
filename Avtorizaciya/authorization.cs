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


namespace Avtorizaciya
{
    public partial class authorization : Form
    {
        Timer timer = new Timer();
        Class1 dataBase = new Class1();
        public authorization()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            button1.Click += new EventHandler(button1_firstClick);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
            textBox2.MaxLength = 60;
            textBox1.MaxLength = 60;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
            button3.Visible = false;
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
            button2.Visible = false;
            button3.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var loginUser = textBox1.Text;
            var passUser = textBox2.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select id_user, login_user, password_user, is_admin from register where login_user ='{loginUser}' and password_user = '{passUser}'";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                var user = new checkUser(table.Rows[0].ItemArray[1].ToString(), Convert.ToString(table.Rows[0].ItemArray[3]));

                main_screen frm2 = new main_screen();
                this.Hide();
                frm2.ShowDialog();
                this.Show();
                Close();
            }
            else
                MessageBox.Show("Такого аккаунта не существует, либо были введены неверные данные", "Аккаунта не существует", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void button1_firstClick(object sender, EventArgs e)
        {
            var loginUser = textBox1.Text;
            var passUser = textBox2.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select id_user, login_user, password_user, is_admin from register where login_user ='{loginUser}' and password_user = '{passUser}'";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                var user = new checkUser(table.Rows[0].ItemArray[1].ToString(), Convert.ToString(table.Rows[0].ItemArray[3]));

                main_screen frm2 = new main_screen();
                this.Hide();
                frm2.ShowDialog();
                this.Show();
                Close();
            }
            else


                
            button1.Click -= new EventHandler(button1_firstClick); 
            button1.Click += new EventHandler(button1_secondClick);

        }

        private void button1_secondClick(object sender, EventArgs e)
        {
            var loginUser = textBox1.Text;
            var passUser = textBox2.Text;
            

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select id_user, login_user, password_user, is_admin from register where login_user ='{loginUser}' and password_user = '{passUser}'";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                var user = new checkUser(table.Rows[0].ItemArray[1].ToString(), Convert.ToString(table.Rows[0].ItemArray[3]));

                main_screen frm2 = new main_screen();
                this.Hide();
                frm2.ShowDialog();
                this.Show();
                Close();
            }
            else


            timer.Interval = 5000; 
            timer.Tick += timer1_Tick;
            timer.Start();
            button1.Enabled = false;


            button1.Click -= new EventHandler(button1_secondClick);
            button1.Click += new EventHandler(button1_thirdClick);

        }

        private void button1_thirdClick(object sender, EventArgs e)
        {
            var loginUser = textBox1.Text;
            var passUser = textBox2.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select id_user, login_user, password_user, is_admin from register where login_user ='{loginUser}' and password_user = '{passUser}'";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                var user = new checkUser(table.Rows[0].ItemArray[1].ToString(), Convert.ToString(table.Rows[0].ItemArray[3]));

                main_screen frm2 = new main_screen();
                this.Hide();
                frm2.ShowDialog();
                this.Show();
                Close();
            }
            else
                
            button1.Click -= new EventHandler(button1_thirdClick);
           
            captcha captcha = new captcha();
            this.Hide();
            captcha.ShowDialog();
            this.Show();
            Close();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.Enabled = true;
            timer.Stop();
        }
    }

}


