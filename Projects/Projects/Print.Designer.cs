namespace Projects
{
    partial class Print
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.สมาชกToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.สมาชกทงหมดToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.เพมสมาชกเปดบญชToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ฝากถอนToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ขอมมลเงนฝากToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ฝากถอนเงนToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.เงนกToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ขอมลเงนกบญช1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ขอมลเงนกบญช2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ชำระคางวดToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.เพมรายชอผกToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ปนผลToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ขอมลดอกเบยปนผลToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.แจกแจงรายการปนผลToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ออกจากระบบToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Projects.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 114);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(716, 373);
            this.reportViewer1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.สมาชกToolStripMenuItem,
            this.ฝากถอนToolStripMenuItem,
            this.เงนกToolStripMenuItem,
            this.ปนผลToolStripMenuItem,
            this.ออกจากระบบToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(740, 108);
            this.menuStrip1.TabIndex = 179;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuToolStripMenuItem.Image = global::Projects.Properties.Resources.home_icon;
            this.menuToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(92, 104);
            this.menuToolStripMenuItem.Text = "หน้าแรก";
            this.menuToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // สมาชกToolStripMenuItem
            // 
            this.สมาชกToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.สมาชกทงหมดToolStripMenuItem,
            this.เพมสมาชกเปดบญชToolStripMenuItem});
            this.สมาชกToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.สมาชกToolStripMenuItem.Image = global::Projects.Properties.Resources.member_icon;
            this.สมาชกToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.สมาชกToolStripMenuItem.Name = "สมาชกToolStripMenuItem";
            this.สมาชกToolStripMenuItem.Size = new System.Drawing.Size(92, 104);
            this.สมาชกToolStripMenuItem.Text = "สมาชิก";
            this.สมาชกToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // สมาชกทงหมดToolStripMenuItem
            // 
            this.สมาชกทงหมดToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.สมาชกทงหมดToolStripMenuItem.Name = "สมาชกทงหมดToolStripMenuItem";
            this.สมาชกทงหมดToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.สมาชกทงหมดToolStripMenuItem.Text = "สมาชิกทั้งหมด";
            this.สมาชกทงหมดToolStripMenuItem.Click += new System.EventHandler(this.สมาชกทงหมดToolStripMenuItem_Click);
            // 
            // เพมสมาชกเปดบญชToolStripMenuItem
            // 
            this.เพมสมาชกเปดบญชToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.เพมสมาชกเปดบญชToolStripMenuItem.Name = "เพมสมาชกเปดบญชToolStripMenuItem";
            this.เพมสมาชกเปดบญชToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.เพมสมาชกเปดบญชToolStripMenuItem.Text = "เพิ่มสมาชิก/เปิดบัญชี";
            this.เพมสมาชกเปดบญชToolStripMenuItem.Click += new System.EventHandler(this.เพมสมาชกเปดบญชToolStripMenuItem_Click);
            // 
            // ฝากถอนToolStripMenuItem
            // 
            this.ฝากถอนToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ขอมมลเงนฝากToolStripMenuItem,
            this.ฝากถอนเงนToolStripMenuItem});
            this.ฝากถอนToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ฝากถอนToolStripMenuItem.Image = global::Projects.Properties.Resources.deposit_icon;
            this.ฝากถอนToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ฝากถอนToolStripMenuItem.Name = "ฝากถอนToolStripMenuItem";
            this.ฝากถอนToolStripMenuItem.Size = new System.Drawing.Size(107, 104);
            this.ฝากถอนToolStripMenuItem.Text = "ฝาก - ถอนเงิน";
            this.ฝากถอนToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ขอมมลเงนฝากToolStripMenuItem
            // 
            this.ขอมมลเงนฝากToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ขอมมลเงนฝากToolStripMenuItem.Name = "ขอมมลเงนฝากToolStripMenuItem";
            this.ขอมมลเงนฝากToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ขอมมลเงนฝากToolStripMenuItem.Text = "ข้อมูลเงินฝาก";
            this.ขอมมลเงนฝากToolStripMenuItem.Click += new System.EventHandler(this.ขอมมลเงนฝากToolStripMenuItem_Click);
            // 
            // ฝากถอนเงนToolStripMenuItem
            // 
            this.ฝากถอนเงนToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ฝากถอนเงนToolStripMenuItem.Name = "ฝากถอนเงนToolStripMenuItem";
            this.ฝากถอนเงนToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ฝากถอนเงนToolStripMenuItem.Text = "ฝาก - ถอนเงิน";
            this.ฝากถอนเงนToolStripMenuItem.Click += new System.EventHandler(this.ฝากถอนเงนToolStripMenuItem_Click);
            // 
            // เงนกToolStripMenuItem
            // 
            this.เงนกToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ขอมลเงนกบญช1ToolStripMenuItem,
            this.ขอมลเงนกบญช2ToolStripMenuItem,
            this.ชำระคางวดToolStripMenuItem,
            this.เพมรายชอผกToolStripMenuItem});
            this.เงนกToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.เงนกToolStripMenuItem.Image = global::Projects.Properties.Resources.loan_icon;
            this.เงนกToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.เงนกToolStripMenuItem.Name = "เงนกToolStripMenuItem";
            this.เงนกToolStripMenuItem.Size = new System.Drawing.Size(92, 104);
            this.เงนกToolStripMenuItem.Text = "เงินกู้";
            this.เงนกToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ขอมลเงนกบญช1ToolStripMenuItem
            // 
            this.ขอมลเงนกบญช1ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ขอมลเงนกบญช1ToolStripMenuItem.Name = "ขอมลเงนกบญช1ToolStripMenuItem";
            this.ขอมลเงนกบญช1ToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.ขอมลเงนกบญช1ToolStripMenuItem.Text = "ข้อมูลเงินกู้บัญชี 1";
            this.ขอมลเงนกบญช1ToolStripMenuItem.Click += new System.EventHandler(this.ขอมลเงนกบญช1ToolStripMenuItem_Click);
            // 
            // ขอมลเงนกบญช2ToolStripMenuItem
            // 
            this.ขอมลเงนกบญช2ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ขอมลเงนกบญช2ToolStripMenuItem.Name = "ขอมลเงนกบญช2ToolStripMenuItem";
            this.ขอมลเงนกบญช2ToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.ขอมลเงนกบญช2ToolStripMenuItem.Text = "ข้อมูลเงินกู้บัญชี 2";
            this.ขอมลเงนกบญช2ToolStripMenuItem.Click += new System.EventHandler(this.ขอมลเงนกบญช2ToolStripMenuItem_Click);
            // 
            // ชำระคางวดToolStripMenuItem
            // 
            this.ชำระคางวดToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ชำระคางวดToolStripMenuItem.Name = "ชำระคางวดToolStripMenuItem";
            this.ชำระคางวดToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.ชำระคางวดToolStripMenuItem.Text = "ชำระเงินกู้";
            this.ชำระคางวดToolStripMenuItem.Click += new System.EventHandler(this.ชำระคางวดToolStripMenuItem_Click);
            // 
            // เพมรายชอผกToolStripMenuItem
            // 
            this.เพมรายชอผกToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.เพมรายชอผกToolStripMenuItem.Name = "เพมรายชอผกToolStripMenuItem";
            this.เพมรายชอผกToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.เพมรายชอผกToolStripMenuItem.Text = "เพิ่มรายชื่อผู้กู้";
            this.เพมรายชอผกToolStripMenuItem.Click += new System.EventHandler(this.เพมรายชอผกToolStripMenuItem_Click);
            // 
            // ปนผลToolStripMenuItem
            // 
            this.ปนผลToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ขอมลดอกเบยปนผลToolStripMenuItem,
            this.แจกแจงรายการปนผลToolStripMenuItem});
            this.ปนผลToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ปนผลToolStripMenuItem.Image = global::Projects.Properties.Resources.dividend_icon;
            this.ปนผลToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ปนผลToolStripMenuItem.Name = "ปนผลToolStripMenuItem";
            this.ปนผลToolStripMenuItem.Size = new System.Drawing.Size(92, 104);
            this.ปนผลToolStripMenuItem.Text = "ปันผล";
            this.ปนผลToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ขอมลดอกเบยปนผลToolStripMenuItem
            // 
            this.ขอมลดอกเบยปนผลToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ขอมลดอกเบยปนผลToolStripMenuItem.Name = "ขอมลดอกเบยปนผลToolStripMenuItem";
            this.ขอมลดอกเบยปนผลToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.ขอมลดอกเบยปนผลToolStripMenuItem.Text = "ข้อมูลดอกเบี้ยปันผล";
            this.ขอมลดอกเบยปนผลToolStripMenuItem.Click += new System.EventHandler(this.ขอมลดอกเบยปนผลToolStripMenuItem_Click);
            // 
            // แจกแจงรายการปนผลToolStripMenuItem
            // 
            this.แจกแจงรายการปนผลToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.แจกแจงรายการปนผลToolStripMenuItem.Name = "แจกแจงรายการปนผลToolStripMenuItem";
            this.แจกแจงรายการปนผลToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.แจกแจงรายการปนผลToolStripMenuItem.Text = "แจกแจงรายการปันผล";
            this.แจกแจงรายการปนผลToolStripMenuItem.Click += new System.EventHandler(this.แจกแจงรายการปนผลToolStripMenuItem_Click);
            // 
            // ออกจากระบบToolStripMenuItem
            // 
            this.ออกจากระบบToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ออกจากระบบToolStripMenuItem.Image = global::Projects.Properties.Resources.exit_icon;
            this.ออกจากระบบToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ออกจากระบบToolStripMenuItem.Name = "ออกจากระบบToolStripMenuItem";
            this.ออกจากระบบToolStripMenuItem.Size = new System.Drawing.Size(102, 104);
            this.ออกจากระบบToolStripMenuItem.Text = "ออกจากระบบ";
            this.ออกจากระบบToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ออกจากระบบToolStripMenuItem.Click += new System.EventHandler(this.ออกจากระบบToolStripMenuItem_Click);
            // 
            // Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projects.Properties.Resources.background4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(740, 511);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Print";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print";
            this.Load += new System.EventHandler(this.Print_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem สมาชกToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem สมาชกทงหมดToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem เพมสมาชกเปดบญชToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ฝากถอนToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ขอมมลเงนฝากToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ฝากถอนเงนToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem เงนกToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ขอมลเงนกบญช1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ขอมลเงนกบญช2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ชำระคางวดToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem เพมรายชอผกToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ปนผลToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ขอมลดอกเบยปนผลToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem แจกแจงรายการปนผลToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ออกจากระบบToolStripMenuItem;
    }
}