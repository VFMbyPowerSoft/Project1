using MySql.Data.MySqlClient;
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

namespace Projects
{
    public partial class Add_Loan : Form
    {
        public Add_Loan()
        {
            InitializeComponent();
        }
        
        MySqlConnection c = new MySqlConnection("Server=localhost; database=villageFund_db; UID=root; Pwd=root;");
        MySqlCommand cmd = new MySqlCommand();

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Add_Loan_Load(object sender, EventArgs e)
        {
            c.Open();
            cmd.Connection = c;
            loadData();

        }
     
        private void but_save_Click(object sender, EventArgs e)
        {
           
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Memumain main = new Memumain();
            main.Show();
        }

        private void ShowMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Show_Member shm = new Show_Member();
            shm.Show();
        }

        private void AddMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Member adm = new Add_Member();
            adm.Show();
        }

        private void ShowDepositeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Show_Deposit shd = new Show_Deposit();
            shd.Show();
        }

        private void AddDepositeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Deposite___withdraw dw = new Deposite___withdraw();
            dw.Show();
        }

        private void PaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment pay = new Payment();
            pay.Show();
        }

        private void AddLoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Loan adl = new Add_Loan();
            adl.Show();
        }

        private void ShowLoan1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowDataAccout1 shda1 = new ShowDataAccout1();
            shda1.Show();
        }

        private void ShowLoan2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowDataAccout2 shda2 = new ShowDataAccout2();
            shda2.Show();
        }

        private void ShowDividendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Show_Interest shi = new Show_Interest();
            shi.Show();
        }

        private void Dividend1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dividend div = new Dividend();
            div.Show();
        }

      
           private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void but_search_Click(object sender, EventArgs e)
        {
            Showdata();
           
        }


        private void loadData()
        {

            //c.Open();
            //cmd.Connection = c;

            MySqlDataReader Reader1;
            cmd.CommandText = "SELECT * FROM member";
            Reader1 = cmd.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(Reader1);

            dataGridView2.AutoGenerateColumns = true;
            dataGridView2.DataSource = dataTable;
            dataGridView2.Refresh();


            MySqlDataReader Reader2;
            cmd.CommandText = "SELECT * FROM member";
            Reader2 = cmd.ExecuteReader();

            DataTable dataTableA = new DataTable();
            dataTable.Load(Reader2);

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dataTable;
            dataGridView1.Refresh();

            
        }
        private void Showdata() //ปุ่มค้นหา
        {
            // MySqlCommand cmd = new MySqlCommand();

            MySqlDataReader Reader;
            cmd.CommandText = "SELECT * FROM member WHERE IDmem LIKE '" + tb_search.Text.Trim() + "'";
            Reader = cmd.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(Reader);

            dataGridView2.AutoGenerateColumns = true;
            dataGridView2.DataSource = dataTable;
            dataGridView2.Refresh();

            /* if (Reader2.HasRows)
             {
                 dt.Load(Reader2);
                 dataGridView1.DataSource = dt;
             }
                
             else
             {
                 dataGridView1.DataSource = null;
             }*/

        }

        //ค้นหาผู้ค้ำประกันคนที่ 1
        private void but_searchGuarantor1_Click(object sender, EventArgs e)
        {


            MySqlDataReader Reader;
            cmd.CommandText = "SELECT * FROM member WHERE IDmem LIKE '" + tb_search.Text.Trim() + "'";
            Reader = cmd.ExecuteReader();
            
            tb_nameGuarantor1.Text = (Reader["memName"].ToString());
            tb_lastnameGuarantor1.Text = (Reader["menLastname"].ToString());

            
        }

        private void Show_Member_Unload(object sender, EventArgs e)
        {
            c.Close();
        }

        private void but_print_Click(object sender, EventArgs e)
        {
            this.Hide();
            Print print = new Print();
            print.Show();

        }

        
        }

    }
