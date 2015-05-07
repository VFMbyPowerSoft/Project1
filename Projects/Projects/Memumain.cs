using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Projects
{
    public partial class Memumain : Form
    {
       // Memumain main = new Memumain();
        
        public Memumain()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.time.Text = dateTime.ToString();
        }

        private void but_Deposite_Click(object sender, EventArgs e)
        {
            this.Hide();
            Deposite___withdraw dw = new Deposite___withdraw();
            dw.Show();
           // Memumain main = new Memumain();
         //   this.Close();


            string strConn = "server=localhost;uid=root;pwd=root;";
            MySqlConnection connection = new MySqlConnection(strConn);
            connection.Open(); //เปิดการเชื่อมต่อ
            if (connection.State == ConnectionState.Open)
            {
                MessageBox.Show("Connectuccess"); //ถ้า connect DB ได้ ให้แสดงข้อความ
            }
            connection.Close(); //ปิดการเชื่อมต่อ
            
            
        }

        private void but_Dividend_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dividend div = new Dividend();
            div.Show();
        }

        private void but_Loan_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment pay = new Payment();
            pay.Show();
        }

        private void but_end_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void but_menber_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Member amb = new Add_Member();
            amb.Show();
        }

        private void but_Manager_Click(object sender, EventArgs e)
        {

            this.Hide();
            LoginManager2 lgm2 = new LoginManager2();
            lgm2.Show();
        }

     
    
    }
}
