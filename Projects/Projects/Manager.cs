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
    public partial class Manager : Form
    {

        MySqlConnection c = new MySqlConnection("Server=localhost; database=villageFund_db; UID=root; Pwd=root;");
        MySqlCommand cmd = new MySqlCommand();


        public Manager()
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

        private void but_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (manPassword.Text == manConfirmPassword.Text)
                {
                    DateTime time = DateTime.Now;
                    string time_started = time.ToString("hh:mm:ss dd-MM-yyyy");

                    
                    MessageBox.Show("test");
                   
                    cmd.CommandText = @"INSERT INTO manager(manID,manTitle,manName,manLastname,manNoID,manUsername,manPassword,manHouseNo,
                                                            manVillage,manVillageNo,manSubdistrict,manDistrict,manProvince,manDay,manTime)
                                        VALUES ('" + this.manID.Text 
                                                   + "','" + this.com_num.SelectedItem
                                                   + "','" + this.manName.Text 
                                                   + "','" + this.manLastname.Text
                                                   + "','" + this.manNoID.Text 
                                                   + "','" + this.manUsername.Text
                                                   + "','" + this.manPassword.Text 
                                                   + "','" + this.manHouseNo.Text
                                                   + "','" + this.manVillage.Text 
                                                   + "','" + this.manVillageNo.Text
                                                   + "','" + this.manSubdistrict.Text 
                                                   + "','" + this.manDistrict.Text
                                                   + "','" + this.manProvince.Text 
                                                   + "','" + this.mandateTime.Value.Date.ToString("yyyy-MM-dd HH:mm")
                                                   + "','" + time_started
                                                   + "') ON DUPLICATE KEY UPDATE manID = '" + this.manID.Text
                                                                                             + "',manTitle = '" + this.com_num.SelectedItem
                                                                                             + "',manName = '" + this.manName.Text
                                                                                             + "',manLastname = '" + this.manLastname.Text
                                                                                             + "',manNoID = '" + this.manNoID.Text
                                                                                             + "',manUsername = '" + this.manUsername.Text
                                                                                             + "',manPassword = '" + this.manPassword.Text
                                                                                             + "',manHouseNo = '" + this.manHouseNo.Text
                                                                                             + "',manVillage = '" + this.manVillage.Text
                                                                                             + "',manVillageNo = '" + this.manVillageNo.Text
                                                                                             + "',manSubdistrict = '" + this.manSubdistrict.Text
                                                                                             + "',manDistrict = '" + this.manDistrict.Text
                                                                                             + "',manProvince = '" + this.manProvince.Text
                                                                                             + "',manDay = '" + this.mandateTime.Value.Date.ToString("yyyy-MM-dd HH:mm")
                                                                                             + "',manTime = '" + time_started + "' ";
                    
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("insert");

                    loadData();
                    MessageBox.Show("yes");
                }
                else
                {
                    MessageBox.Show("No");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

            
        }

        private void but_add_Click(object sender, EventArgs e)
        {
            Cleardata();
        }

        private void but_delete_Click(object sender, EventArgs e)
        {


            cmd.CommandText = "DELETE FROM manager WHERE manNoID = '" + manNoID.Text + "' ";
            cmd.ExecuteNonQuery();
            loadData();


            MessageBox.Show("delete");

        }

        private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {

            com_num.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells["manTitle"].Value.ToString();
            manName.Text = dataGridView1.Rows[e.RowIndex].Cells["manName"].Value.ToString();
            manLastname.Text = dataGridView1.Rows[e.RowIndex].Cells["manLastname"].Value.ToString();
            manNoID.Text = dataGridView1.Rows[e.RowIndex].Cells["manNoID"].Value.ToString();
            manUsername.Text = dataGridView1.Rows[e.RowIndex].Cells["manUsername"].Value.ToString();
            manPassword.Text = dataGridView1.Rows[e.RowIndex].Cells["manPassword"].Value.ToString();
            manHouseNo.Text = dataGridView1.Rows[e.RowIndex].Cells["manHouseNo"].Value.ToString();
            manVillage.Text = dataGridView1.Rows[e.RowIndex].Cells["manVillage"].Value.ToString();
            manVillageNo.Text = dataGridView1.Rows[e.RowIndex].Cells["manVillageNo"].Value.ToString();
            manSubdistrict.Text = dataGridView1.Rows[e.RowIndex].Cells["manSubdistrict"].Value.ToString();
            manDistrict.Text = dataGridView1.Rows[e.RowIndex].Cells["manDistrict"].Value.ToString();
            manProvince.Text = dataGridView1.Rows[e.RowIndex].Cells["manProvince"].Value.ToString();
            

        }

        private void Manager_Load(object sender, EventArgs e)
        {
            c.Open();
            cmd.Connection = c;

            loadData();

            MySqlDataReader Reader;

            cmd.CommandText = "SELECT * FROM manager order by manID desc limit 1";
            Reader = cmd.ExecuteReader();
            Reader.Read();
           
            showNo.Text = Reader["manID"].ToString();
            Reader.Dispose();
        }

        private void Manager_Unload(object sender, EventArgs e)
        {
            c.Close();
        }

        private void Cleardata()
        {
            com_num.Text = "คำนำหน้า";
            manName.Clear();
            manLastname.Clear();
            manNoID.Clear();
            manUsername.Clear();
            manPassword.Clear();
            manConfirmPassword.Clear();
            manHouseNo.Clear();
            manVillage.Clear();
            manVillageNo.Clear();
            manSubdistrict.Clear();
            manDistrict.Clear();
            manProvince.Clear();
            
        }

        private void loadData()
        {

            MySqlDataReader Reader;
            cmd.CommandText = "SELECT * FROM manager";
            Reader = cmd.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(Reader);

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dataTable;
            dataGridView1.Refresh();

        }

    }
}
