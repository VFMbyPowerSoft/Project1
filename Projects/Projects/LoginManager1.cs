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
    public partial class LoginManager1 : Form
    {
        public LoginManager1()
        {
            InitializeComponent();
        }

        private void but_loginmanager_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlConnection c = new MySqlConnection("Server=localhost; database=villageFund_db; UID=root; Pwd=root;");

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM villageFund_db.manager WHERE manUsername='" + this.text_manager.Text + "' AND manPassword='" + this.text_Passw.Text + "' ; ", c);

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
                    //LoginManager lgm = new LoginManager();
                    // lgm.Show();
                    MessageBox.Show("Successful");
                    this.Hide();
                    Memumain main = new Memumain();
                    main.Show();
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