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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void but_log_Click(object sender, EventArgs e)
        {

            try
            {

                MySqlConnection c = new MySqlConnection("Server=localhost; database=villageFund_db; UID=root; Pwd=root;");

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM villageFund_db.employee WHERE empUsername ='" + this.text_Name.Text + "' AND empPassword ='" + this.text_password.Text + "' ; ", c);

                MySqlDataReader myReader;
                c.Open();
                myReader = cmd.ExecuteReader();
                int count = 0;
                while (myReader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    this.Hide();
                    LoginManager1 lgm = new LoginManager1();
                    lgm.Show();
                    //MessageBox.Show("Successful");
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
    }
}