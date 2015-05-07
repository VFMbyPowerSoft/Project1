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
    public partial class ShowEmployee : Form
    {
        MySqlConnection c = new MySqlConnection("Server=localhost; database=villageFund_db; UID=root; Pwd=root;");
        MySqlCommand cmd = new MySqlCommand();


        public ShowEmployee()
        {
            InitializeComponent();
        }
        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Memumain main = new Memumain();
            main.Show();
        }

        private void addemployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Employee ade = new Add_Employee();
            ade.Show();
        }

        private void showemployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowEmployee she = new ShowEmployee();
            she.Show();
        }

        private void managerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manager man = new Manager();
            man.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
 
        private void but_search_Click(object sender, EventArgs e)
        {

            loadData();

        }
        private void loadData()
        {

            //c.Open();
            //cmd.Connection = c;

            MySqlDataReader Reader;
            cmd.CommandText = "SELECT * FROM employee";
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
            cmd.CommandText = "SELECT * FROM employee WHERE empID LIKE '" + tb_search.Text.Trim() + "'or empName LIKE '" + tb_search.Text.Trim() +"'";
            Reader = cmd.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(Reader);

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dataTable;
            dataGridView1.Refresh();

        }

        private void but_search1_Click(object sender, EventArgs e)
        {
            Showdata();
        }

        private void ShowEmployee_Load(object sender, EventArgs e)
        {
            c.Open();
            cmd.Connection = c;
            loadData();
        }
        private void ShowEmployee_Unload(object sender, EventArgs e)
        {
            c.Close();
        }

        private void but_print_Click(object sender, EventArgs e)
        {
            this.Hide();
            Print print = new Print();
            print.Show();
        }

        private void addemployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Employee ade = new Add_Employee();
            ade.Show();
        }

       
        }
    
    }

