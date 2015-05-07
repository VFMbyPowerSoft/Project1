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

namespace Projects
{
    public partial class ShowDataAccout2 : Form
    {
        MySqlConnection c = new MySqlConnection("Server=localhost; database=villageFund_db; UID=root; Pwd=root;");
        MySqlCommand cmd = new MySqlCommand();

        public ShowDataAccout2()
        {
            InitializeComponent();
        }

        private void MenuToolStripMenuItem_Click(object sender, EventArgs e)
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
       

        private void ShowDataAccout2_Load(object sender, EventArgs e)
        {
            c.Open();
            cmd.Connection = c;
            loadData();
        }

        private void ShowDataAccout2_Unload(object sender, EventArgs e)
        {
            c.Close();
        }

        private void but_search_Click(object sender, EventArgs e)
        {
            Showdata();
        }

        private void loadData()
        {

            //c.Open();
            //cmd.Connection = c;

            MySqlDataReader Reader;
            cmd.CommandText = "SELECT * FROM loan";
            Reader = cmd.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(Reader);

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dataTable;
            dataGridView1.Refresh();


        }
        private void Showdata()
        {
            // MySqlCommand cmd = new MySqlCommand();

            MySqlDataReader Reader;
            cmd.CommandText = "SELECT * FROM loan WHERE loanID LIKE '" + tb_search.Text.Trim() + "'";
            Reader = cmd.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(Reader);

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dataTable;
            dataGridView1.Refresh();

        }

        private void but_print_Click(object sender, EventArgs e)
        {
            this.Hide();
            Print print = new Print();
            print.Show();
        }

        private void but_add_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Loan adl = new Add_Loan();
            adl.Show();
        }

           
    }
}
