namespace Projects
{
    partial class Memumain
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
            this.components = new System.ComponentModel.Container();
            this.but_end = new System.Windows.Forms.Button();
            this.but_Loan = new System.Windows.Forms.Button();
            this.but_menber = new System.Windows.Forms.Button();
            this.but_Dividend = new System.Windows.Forms.Button();
            this.but_Deposite = new System.Windows.Forms.Button();
            this.but_Manager = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // but_end
            // 
            this.but_end.BackColor = System.Drawing.Color.Transparent;
            this.but_end.BackgroundImage = global::Projects.Properties.Resources.exit_icon1;
            this.but_end.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.but_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_end.Location = new System.Drawing.Point(768, 197);
            this.but_end.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.but_end.Name = "but_end";
            this.but_end.Size = new System.Drawing.Size(120, 120);
            this.but_end.TabIndex = 5;
            this.but_end.Text = "ออกจากระบบ";
            this.but_end.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_end.UseVisualStyleBackColor = false;
            this.but_end.Click += new System.EventHandler(this.but_end_Click);
            // 
            // but_Loan
            // 
            this.but_Loan.BackColor = System.Drawing.Color.Transparent;
            this.but_Loan.BackgroundImage = global::Projects.Properties.Resources.loan_icon1;
            this.but_Loan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.but_Loan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_Loan.Location = new System.Drawing.Point(522, 197);
            this.but_Loan.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.but_Loan.Name = "but_Loan";
            this.but_Loan.Size = new System.Drawing.Size(120, 120);
            this.but_Loan.TabIndex = 3;
            this.but_Loan.Text = "เงินกู้";
            this.but_Loan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_Loan.UseVisualStyleBackColor = false;
            this.but_Loan.Click += new System.EventHandler(this.but_Loan_Click);
            // 
            // but_menber
            // 
            this.but_menber.BackColor = System.Drawing.Color.Transparent;
            this.but_menber.BackgroundImage = global::Projects.Properties.Resources.member_icon1;
            this.but_menber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.but_menber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_menber.Location = new System.Drawing.Point(282, 368);
            this.but_menber.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.but_menber.Name = "but_menber";
            this.but_menber.Size = new System.Drawing.Size(120, 120);
            this.but_menber.TabIndex = 2;
            this.but_menber.Text = "สมาชิก";
            this.but_menber.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_menber.UseVisualStyleBackColor = false;
            this.but_menber.Click += new System.EventHandler(this.but_menber_Click);
            // 
            // but_Dividend
            // 
            this.but_Dividend.BackColor = System.Drawing.Color.Transparent;
            this.but_Dividend.BackgroundImage = global::Projects.Properties.Resources.dividend_icon1;
            this.but_Dividend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.but_Dividend.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_Dividend.Location = new System.Drawing.Point(282, 197);
            this.but_Dividend.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.but_Dividend.Name = "but_Dividend";
            this.but_Dividend.Size = new System.Drawing.Size(120, 120);
            this.but_Dividend.TabIndex = 1;
            this.but_Dividend.Text = "ปันผล";
            this.but_Dividend.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_Dividend.UseVisualStyleBackColor = false;
            this.but_Dividend.Click += new System.EventHandler(this.but_Dividend_Click);
            // 
            // but_Deposite
            // 
            this.but_Deposite.BackColor = System.Drawing.Color.Transparent;
            this.but_Deposite.BackgroundImage = global::Projects.Properties.Resources.deposit_icon1;
            this.but_Deposite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.but_Deposite.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_Deposite.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.but_Deposite.Location = new System.Drawing.Point(34, 197);
            this.but_Deposite.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.but_Deposite.Name = "but_Deposite";
            this.but_Deposite.Size = new System.Drawing.Size(120, 120);
            this.but_Deposite.TabIndex = 0;
            this.but_Deposite.Text = "ฝาก-ถอน";
            this.but_Deposite.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_Deposite.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.but_Deposite.UseVisualStyleBackColor = false;
            this.but_Deposite.Click += new System.EventHandler(this.but_Deposite_Click);
            // 
            // but_Manager
            // 
            this.but_Manager.BackColor = System.Drawing.Color.Transparent;
            this.but_Manager.BackgroundImage = global::Projects.Properties.Resources.manager_icon;
            this.but_Manager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.but_Manager.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_Manager.Location = new System.Drawing.Point(522, 368);
            this.but_Manager.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.but_Manager.Name = "but_Manager";
            this.but_Manager.Size = new System.Drawing.Size(120, 120);
            this.but_Manager.TabIndex = 6;
            this.but_Manager.Text = "ผู้จัดการ";
            this.but_Manager.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_Manager.UseVisualStyleBackColor = false;
            this.but_Manager.Click += new System.EventHandler(this.but_Manager_Click);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.time.Font = new System.Drawing.Font("RSU", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.Color.Red;
            this.time.Location = new System.Drawing.Point(836, 30);
            this.time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(52, 30);
            this.time.TabIndex = 7;
            this.time.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(853, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // Memumain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projects.Properties.Resources.background3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 601);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.time);
            this.Controls.Add(this.but_Manager);
            this.Controls.Add(this.but_end);
            this.Controls.Add(this.but_Loan);
            this.Controls.Add(this.but_menber);
            this.Controls.Add(this.but_Dividend);
            this.Controls.Add(this.but_Deposite);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Memumain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "หน้าหลัก";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_Deposite;
        private System.Windows.Forms.Button but_Dividend;
        private System.Windows.Forms.Button but_menber;
        private System.Windows.Forms.Button but_Loan;
        private System.Windows.Forms.Button but_end;
        private System.Windows.Forms.Button but_Manager;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;

    }
}