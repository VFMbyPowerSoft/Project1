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
    public partial class Dividend : Form
    {
        public Dividend()
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

        private void but_submit_1_Click(object sender, EventArgs e)
        {
            caldata1();
        }
        private void but_submit_2_Click(object sender, EventArgs e)
        {
            caldata2();
        }
        private void but_submit_3_Click(object sender, EventArgs e)
        {
            caldata3();
        }
        
        public void caldata1() 
        {
            Int32 loanInterest = Convert.ToInt32(tb_loanInterest_1.Text);//รับค่าดอกเบี้ย

            Int32 avgPayback = Convert.ToInt32(tb_avgPayback_1.Text);//คำนวณค่าเฉลี่ยคืน
            Int32 tbpayback = (avgPayback * loanInterest) / 100;
            tb_payback_1.Text = tbpayback.ToString();

            Int32 avgWage = Convert.ToInt32(tb_avgWage_1.Text);//คำนวณค่าตอบแทนพนักงาน
            Int32 tbwage = (avgWage * loanInterest) / 100;
            tb_wage_1.Text = tbwage.ToString();

            Int32 avgDevidend = Convert.ToInt32(tb_avgDevidend_1.Text);//คำนวณปันผลสมาชิก
            Int32 tbdevidend1 = (avgDevidend * loanInterest) / 100;
            tb_devidend_1.Text = tbdevidend1.ToString();

            Int32 avgInsure = Convert.ToInt32(tb_avgInsure_1.Text);//คำนวณประกันความเสี่ยง
            Int32 tbinsure = (avgInsure * loanInterest) / 100;
            tb_insure_1.Text = tbinsure.ToString();

            Int32 avgWelfare = Convert.ToInt32(tb_avgWelfare_1.Text);//คำนวณสวัสดิการ
            Int32 tbwelfare = (avgWelfare * loanInterest) / 100;
            tb_welfare_1.Text = tbwelfare.ToString();

        }

        public void caldata2()
        {
            Int32 loanInterest = Convert.ToInt32(tb_loanInterest_2.Text);//รับค่าดอกเบี้ย

            Int32 avgPayback = Convert.ToInt32(tb_avgPayback_2.Text);//คำนวณค่าเฉลี่ยคืน
            Int32 tbpayback = (avgPayback * loanInterest) / 100;
            tb_payback_2.Text = tbpayback.ToString();

            Int32 avgWage = Convert.ToInt32(tb_avgWage_2.Text);//คำนวณค่าตอบแทนพนักงาน
            Int32 tbwage = (avgWage * loanInterest) / 100;
            tb_wage_2.Text = tbwage.ToString();

            Int32 avgDevidend = Convert.ToInt32(tb_avgDevidend_2.Text);//คำนวณปันผลสมาชิก
            Int32 tbdevidend2 = (avgDevidend * loanInterest) / 100;
            tb_devidend_2.Text = tbdevidend2.ToString();

            Int32 avgInsure = Convert.ToInt32(tb_avgInsure_2.Text);//คำนวณประกันความเสี่ยง
            Int32 tbinsure = (avgInsure * loanInterest) / 100;
            tb_insure_2.Text = tbinsure.ToString();

            Int32 avgWelfare = Convert.ToInt32(tb_avgWelfare_2.Text);//คำนวณสวัสดิการ
            Int32 tbwelfare = (avgWelfare * loanInterest) / 100;
            tb_welfare_2.Text = tbwelfare.ToString();

        }

        public void caldata3()
        {
            Double Total = Convert.ToInt32(tb_devidend_1.Text) + Convert.ToInt32(tb_devidend_2.Text);//ดึงค่าเงินปันผลสมาชิกมารวมกัน
            tb_totalDividend.Text = Total.ToString();

            Double tbtotalDeposit = Convert.ToInt32(tb_totalDeposit.Text);//คำนวณดอกเบี้ยปันผลสมาชิกมารวมกัน
            Double PerLoanInterest = (Total / tbtotalDeposit) * 100;
            tb_perLoanInterest.Text = PerLoanInterest.ToString();

        }

     
    }
}
