namespace Projects
{
    partial class ShowDataAccout2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ToolStripMenuItem AddMemberToolStripMenuItem;
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.but_search = new System.Windows.Forms.Button();
            this.but_print = new System.Windows.Forms.Button();
            this.but_add = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DepositeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowDepositeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddDepositeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowLoan1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowLoan2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddLoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DividendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowDividendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Dividend1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            AddMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddMemberToolStripMenuItem
            // 
            AddMemberToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            AddMemberToolStripMenuItem.Name = "AddMemberToolStripMenuItem";
            AddMemberToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            AddMemberToolStripMenuItem.Text = "เพิ่มสมาชิก/เปิดบัญชี";
            AddMemberToolStripMenuItem.Click += new System.EventHandler(this.AddMemberToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 215;
            this.label1.Text = "รายชื่อผู้กู้ทั้งหมด";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 204);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(983, 333);
            this.dataGridView1.TabIndex = 212;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(290, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 211;
            this.label2.Text = "ค้นหาสมาชิก";
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(386, 138);
            this.tb_search.Margin = new System.Windows.Forms.Padding(4);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(132, 22);
            this.tb_search.TabIndex = 210;
            // 
            // but_search
            // 
            this.but_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_search.Location = new System.Drawing.Point(546, 135);
            this.but_search.Margin = new System.Windows.Forms.Padding(4);
            this.but_search.Name = "but_search";
            this.but_search.Size = new System.Drawing.Size(100, 28);
            this.but_search.TabIndex = 209;
            this.but_search.Text = "ค้นหา";
            this.but_search.UseVisualStyleBackColor = true;
            this.but_search.Click += new System.EventHandler(this.but_search_Click);
            // 
            // but_print
            // 
            this.but_print.BackgroundImage = global::Projects.Properties.Resources.print_icon;
            this.but_print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_print.Location = new System.Drawing.Point(862, 121);
            this.but_print.Margin = new System.Windows.Forms.Padding(4);
            this.but_print.Name = "but_print";
            this.but_print.Size = new System.Drawing.Size(64, 62);
            this.but_print.TabIndex = 213;
            this.but_print.UseVisualStyleBackColor = true;
            this.but_print.Click += new System.EventHandler(this.but_print_Click);
            // 
            // but_add
            // 
            this.but_add.BackgroundImage = global::Projects.Properties.Resources.add_icon;
            this.but_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_add.Location = new System.Drawing.Point(931, 121);
            this.but_add.Margin = new System.Windows.Forms.Padding(4);
            this.but_add.Name = "but_add";
            this.but_add.Size = new System.Drawing.Size(64, 62);
            this.but_add.TabIndex = 214;
            this.but_add.UseVisualStyleBackColor = true;
            this.but_add.Click += new System.EventHandler(this.but_add_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuToolStripMenuItem,
            this.MemberToolStripMenuItem,
            this.DepositeToolStripMenuItem,
            this.LoanToolStripMenuItem,
            this.DividendToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 108);
            this.menuStrip1.TabIndex = 310;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuToolStripMenuItem
            // 
            this.MenuToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuToolStripMenuItem.Image = global::Projects.Properties.Resources.home_icon;
            this.MenuToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem";
            this.MenuToolStripMenuItem.Size = new System.Drawing.Size(92, 104);
            this.MenuToolStripMenuItem.Text = "หน้าแรก";
            this.MenuToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuToolStripMenuItem.Click += new System.EventHandler(this.MenuToolStripMenuItem_Click);
            // 
            // MemberToolStripMenuItem
            // 
            this.MemberToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowMemberToolStripMenuItem,
            AddMemberToolStripMenuItem});
            this.MemberToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberToolStripMenuItem.Image = global::Projects.Properties.Resources.member_icon;
            this.MemberToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MemberToolStripMenuItem.Name = "MemberToolStripMenuItem";
            this.MemberToolStripMenuItem.Size = new System.Drawing.Size(92, 104);
            this.MemberToolStripMenuItem.Text = "สมาชิก";
            this.MemberToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ShowMemberToolStripMenuItem
            // 
            this.ShowMemberToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowMemberToolStripMenuItem.Name = "ShowMemberToolStripMenuItem";
            this.ShowMemberToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.ShowMemberToolStripMenuItem.Text = "สมาชิกทั้งหมด";
            this.ShowMemberToolStripMenuItem.Click += new System.EventHandler(this.ShowMemberToolStripMenuItem_Click);
            // 
            // DepositeToolStripMenuItem
            // 
            this.DepositeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowDepositeToolStripMenuItem,
            this.AddDepositeToolStripMenuItem});
            this.DepositeToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepositeToolStripMenuItem.Image = global::Projects.Properties.Resources.deposit_icon;
            this.DepositeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DepositeToolStripMenuItem.Name = "DepositeToolStripMenuItem";
            this.DepositeToolStripMenuItem.Size = new System.Drawing.Size(107, 104);
            this.DepositeToolStripMenuItem.Text = "ฝาก - ถอนเงิน";
            this.DepositeToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ShowDepositeToolStripMenuItem
            // 
            this.ShowDepositeToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowDepositeToolStripMenuItem.Name = "ShowDepositeToolStripMenuItem";
            this.ShowDepositeToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.ShowDepositeToolStripMenuItem.Text = "ข้อมูลเงินฝาก";
            this.ShowDepositeToolStripMenuItem.Click += new System.EventHandler(this.ShowDepositeToolStripMenuItem_Click);
            // 
            // AddDepositeToolStripMenuItem
            // 
            this.AddDepositeToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDepositeToolStripMenuItem.Name = "AddDepositeToolStripMenuItem";
            this.AddDepositeToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.AddDepositeToolStripMenuItem.Text = "ฝาก - ถอนเงิน";
            this.AddDepositeToolStripMenuItem.Click += new System.EventHandler(this.AddDepositeToolStripMenuItem_Click);
            // 
            // LoanToolStripMenuItem
            // 
            this.LoanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowLoan1ToolStripMenuItem,
            this.ShowLoan2ToolStripMenuItem,
            this.PaymentToolStripMenuItem,
            this.AddLoanToolStripMenuItem});
            this.LoanToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoanToolStripMenuItem.Image = global::Projects.Properties.Resources.loan_icon;
            this.LoanToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.LoanToolStripMenuItem.Name = "LoanToolStripMenuItem";
            this.LoanToolStripMenuItem.Size = new System.Drawing.Size(92, 104);
            this.LoanToolStripMenuItem.Text = "เงินกู้";
            this.LoanToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ShowLoan1ToolStripMenuItem
            // 
            this.ShowLoan1ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowLoan1ToolStripMenuItem.Name = "ShowLoan1ToolStripMenuItem";
            this.ShowLoan1ToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.ShowLoan1ToolStripMenuItem.Text = "ข้อมูลเงินกู้บัญชี 1";
            this.ShowLoan1ToolStripMenuItem.Click += new System.EventHandler(this.ShowLoan1ToolStripMenuItem_Click);
            // 
            // ShowLoan2ToolStripMenuItem
            // 
            this.ShowLoan2ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowLoan2ToolStripMenuItem.Name = "ShowLoan2ToolStripMenuItem";
            this.ShowLoan2ToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.ShowLoan2ToolStripMenuItem.Text = "ข้อมูลเงินกู้บัญชี 2";
            this.ShowLoan2ToolStripMenuItem.Click += new System.EventHandler(this.ShowLoan2ToolStripMenuItem_Click);
            // 
            // PaymentToolStripMenuItem
            // 
            this.PaymentToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentToolStripMenuItem.Name = "PaymentToolStripMenuItem";
            this.PaymentToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.PaymentToolStripMenuItem.Text = "ชำระเงินกู้";
            this.PaymentToolStripMenuItem.Click += new System.EventHandler(this.PaymentToolStripMenuItem_Click);
            // 
            // AddLoanToolStripMenuItem
            // 
            this.AddLoanToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddLoanToolStripMenuItem.Name = "AddLoanToolStripMenuItem";
            this.AddLoanToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.AddLoanToolStripMenuItem.Text = "เพิ่มรายชื่อผู้กู้";
            this.AddLoanToolStripMenuItem.Click += new System.EventHandler(this.AddLoanToolStripMenuItem_Click);
            // 
            // DividendToolStripMenuItem
            // 
            this.DividendToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowDividendToolStripMenuItem,
            this.Dividend1ToolStripMenuItem});
            this.DividendToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DividendToolStripMenuItem.Image = global::Projects.Properties.Resources.dividend_icon;
            this.DividendToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DividendToolStripMenuItem.Name = "DividendToolStripMenuItem";
            this.DividendToolStripMenuItem.Size = new System.Drawing.Size(92, 104);
            this.DividendToolStripMenuItem.Text = "ปันผล";
            this.DividendToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ShowDividendToolStripMenuItem
            // 
            this.ShowDividendToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowDividendToolStripMenuItem.Name = "ShowDividendToolStripMenuItem";
            this.ShowDividendToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.ShowDividendToolStripMenuItem.Text = "ข้อมูลดอกเบี้ยปันผล";
            this.ShowDividendToolStripMenuItem.Click += new System.EventHandler(this.ShowDividendToolStripMenuItem_Click);
            // 
            // Dividend1ToolStripMenuItem
            // 
            this.Dividend1ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dividend1ToolStripMenuItem.Name = "Dividend1ToolStripMenuItem";
            this.Dividend1ToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.Dividend1ToolStripMenuItem.Text = "แจกแจงรายการปันผล";
            this.Dividend1ToolStripMenuItem.Click += new System.EventHandler(this.Dividend1ToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitToolStripMenuItem.Image = global::Projects.Properties.Resources.exit_icon;
            this.ExitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(102, 104);
            this.ExitToolStripMenuItem.Text = "ออกจากระบบ";
            this.ExitToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // ShowDataAccout2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projects.Properties.Resources.background4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 601);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but_print);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.but_search);
            this.Controls.Add(this.but_add);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ShowDataAccout2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ข้อมูลเงินกู้บัญชี 2";
            this.Load += new System.EventHandler(this.ShowDataAccout2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button but_print;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Button but_search;
        private System.Windows.Forms.Button but_add;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DepositeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowDepositeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddDepositeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowLoan1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowLoan2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddLoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DividendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowDividendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Dividend1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
    }
}