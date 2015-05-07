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
    public partial class Add_Employee : Form
    {

        MySqlConnection c = new MySqlConnection("Server=localhost; database=villagefund_db; UID=root; Pwd=root;");
        MySqlCommand cmd = new MySqlCommand();


        public Add_Employee()
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
                if (empPassword.Text == empConfirmPassword.Text)
                {
                    DateTime time = DateTime.Now;
                    string time_started = time.ToString("hh:mm:ss dd-MM-yyyy");

                    cmd.CommandText = @"INSERT INTO employee(empID,empTitle,empName,empLastname,empNoID,empUsername,empPassword,empHouseNo,
                                        empVillage,empVillageNo,empSubdistrict,empDistrict,empProvince,empDay,empStatus,empTime)
                                        VALUES('" + this.empID.Text
                                                  + "','" + this.com_num.SelectedItem
                                                  + "','" + this.empName.Text
                                                  + "','" + this.empLastname.Text
                                                  + "','" + this.empNoID.Text
                                                  + "','" + this.empUsername.Text
                                                  + "','" + this.empPassword.Text
                                                  + "','" + this.empHouseNo.Text
                                                  + "','" + this.empVillage.Text
                                                  + "','" + this.empVillageNo.Text
                                                  + "','" + this.empSubdistrict.Text
                                                  + "','" + this.empDistrict.Text
                                                  + "','" + this.empProvince.Text
                                                  + "','" + this.empdateTime.Value.Date.ToString("yyyy-MM-dd HH:mm")
                                                  + "','" + this.com_status.SelectedItem
                                                  + "','" + time_started + "') ON DUPLICATE KEY UPDATE empID = '" + this.empID.Text
                                                                                                                + "',empTitle = '" + this.com_num.SelectedItem
                                                                                                                + "',empName = '" + this.empName.Text
                                                                                                                + "',empLastname = '" + this.empLastname.Text
                                                                                                                + "',empNoID = '" + this.empNoID.Text
                                                                                                                + "',empUsername = '" + this.empUsername.Text
                                                                                                                + "',empPassword = '" + this.empPassword.Text
                                                                                                                + "',empHouseNo = '" + this.empHouseNo.Text
                                                                                                                + "',empVillage = '" + this.empVillage.Text
                                                                                                                + "',empVillageNo = '" + this.empVillageNo.Text
                                                                                                                + "',empSubdistrict = '" + this.empSubdistrict.Text
                                                                                                                + "',empDistrict = '" + this.empDistrict.Text
                                                                                                                + "',empProvince = '" + this.empProvince.Text
                                                                                                                + "',empDay = '" + this.empdateTime.Value.Date.ToString("yyyy-MM-dd HH:mm")
                                                                                                                + "',empStatus = '" + this.com_status.SelectedItem
                                                                                                                + "',empTime = '" + time_started + "' ";


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
            /*
            cmd.CommandText = "DELETE FROM employee WHERE empNoID = '" + empNoID.Text + "' ";
            cmd.ExecuteNonQuery();
            loadData();


            MessageBox.Show("delete");
             */
        }

        private void but_edit_Click(object sender, EventArgs e)
        {
            /*  DateTime time = DateTime.Now;
              string time_started = time.ToString("hh:mm:ss dd-MM-yyyy");


              cmd.CommandText = @"UPDATE employee
                                  SET empTitle = '" + this.com_num.SelectedItem + "',empName = '" + this.empName.Text + "', empLastname = '" + this.empLastname.Text
                                                   + "',empNoID = '" + this.empNoID.Text + "',empUsername = '" + this.empUsername.Text
                                                   + "',empPassword = '" + this.empPassword.Text + "',empHouseNo = '" + this.empHouseNo.Text
                                                   + "',empVillage = '" + this.empVillage.Text + "',empVillageNo = '" + this.empVillageNo.Text
                                                   + "',empSubdistrict = '" + this.empSubdistrict.Text + "',empDistrict = '" + this.empDistrict.Text
                                                   + "',empProvince = '" + this.empProvince.Text + "',empPostalcode = '" + this.empPostalcode.Text
                                                   + "',empcomday = '" + this.com_day.SelectedItem + "',empcommonth = '" + this.com_month.SelectedItem
                                                   + "',empYear = '" + this.empYear.Text + "',empPostalcode = '" + this.com_status.SelectedItem
                                                   + "',empTime = '" + time_started
                            + "' WHERE empNoID = '" + empNoID.Text + "' ";

              MessageBox.Show("edit");
              cmd.ExecuteNonQuery();
              MessageBox.Show("edit2");
              loadData();  
             */
        }

        private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            empID.Text = dataGridView1.Rows[e.RowIndex].Cells["รหัสพนักงาน"].Value.ToString();
            com_num.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells["คำนำหน้านาม"].Value.ToString();
            empName.Text = dataGridView1.Rows[e.RowIndex].Cells["ชื่อ"].Value.ToString();
            empLastname.Text = dataGridView1.Rows[e.RowIndex].Cells["นามสกุล"].Value.ToString();
            empNoID.Text = dataGridView1.Rows[e.RowIndex].Cells["เลขบัตรประชาชน"].Value.ToString();
            empUsername.Text = dataGridView1.Rows[e.RowIndex].Cells["ผู้ใช้ระบบ"].Value.ToString();
            empPassword.Text = dataGridView1.Rows[e.RowIndex].Cells["รหัสผ่าน"].Value.ToString();
            empHouseNo.Text = dataGridView1.Rows[e.RowIndex].Cells["บ้านเลขที่"].Value.ToString();
            empVillage.Text = dataGridView1.Rows[e.RowIndex].Cells["หมู่บ้าน"].Value.ToString();
            empVillageNo.Text = dataGridView1.Rows[e.RowIndex].Cells["หมู่ที่"].Value.ToString();
            empSubdistrict.Text = dataGridView1.Rows[e.RowIndex].Cells["ตำบล"].Value.ToString();
            empDistrict.Text = dataGridView1.Rows[e.RowIndex].Cells["อำเภอ"].Value.ToString();
            empProvince.Text = dataGridView1.Rows[e.RowIndex].Cells["จังหวัด"].Value.ToString();
            //empdateTime.Value.Date.ToString("yyyy-MM-dd") = dataGridView1.Rows[e.RowIndex].Cells["วันเดือนปีเกิด"].Value.ToString();
            com_status.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells["สถานภาพ"].Value.ToString();

        }


        private void Add_Employee_Load(object sender, EventArgs e)
        {
            c.Open();
            cmd.Connection = c;

            loadData();

            MySqlDataReader Reader;
            cmd.CommandText = "SELECT * FROM employee ORDER BY empID DESC LIMIT 1";
            Reader = cmd.ExecuteReader();
            Reader.Read();

            showNo.Text = Reader["empID"].ToString();
            Reader.Dispose();
        }

        private void Add_Employee_Unload(object sender, EventArgs e)
        {
            c.Close();
        }
        private void Cleardata()
        {
            empID.Clear();
            com_num.Text = "คำนำหน้า";
            empName.Clear();
            empLastname.Clear();
            empNoID.Clear();
            empUsername.Clear();
            empPassword.Clear();
            empConfirmPassword.Clear();
            empHouseNo.Clear();
            empVillage.Clear();
            empVillageNo.Clear();
            empSubdistrict.Clear();
            empDistrict.Clear();
            empProvince.Clear();
            // empdateTime.Value = ();      
            com_status.Text = "การทำงาน";
        }
        private void loadData()
        {
            MySqlDataReader Reader;
            cmd.CommandText = @"SELECT empID AS'รหัสพนักงาน',empTitle AS'คำนำหน้านาม',empName AS'ชื่อ',empLastname AS'นามสกุล',
                                empNoID AS'เลขบัตรประชาชน',empUsername AS'ผู้ใช้ระบบ',empPassword AS'รหัสผ่าน',empHouseNo AS'บ้านเลขที่',
                                empVillage AS'หมู่บ้าน',empVillageNo AS'หมู่ที่',empSubdistrict AS'ตำบล',empDistrict AS'อำเภอ',
                                empProvince AS'จังหวัด',empDay AS'วันเดือนปีเกิด',empStatus AS'สถานภาพ',empTime AS'เวลาที่บันทึก' FROM employee";

            //cmd.CommandText = "SELECT * FROM employee";
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

    }
}