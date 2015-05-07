namespace Projects
{
    partial class ShowEmployee
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.but_search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addemployee = new System.Windows.Forms.Button();
            this.but_print = new System.Windows.Forms.Button();
            this.but_search1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addemployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showemployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(984, 410);
            this.dataGridView1.TabIndex = 196;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(237, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 195;
            this.label2.Text = "ค้นหาสมาชิก";
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(309, 140);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(100, 20);
            this.tb_search.TabIndex = 194;
            // 
            // but_search
            // 
            this.but_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_search.Location = new System.Drawing.Point(525, 138);
            this.but_search.Name = "but_search";
            this.but_search.Size = new System.Drawing.Size(109, 23);
            this.but_search.TabIndex = 193;
            this.but_search.Text = "แสดงทั้งหมด";
            this.but_search.UseVisualStyleBackColor = true;
            this.but_search.Click += new System.EventHandler(this.but_search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 192;
            this.label1.Text = "รายชื่อสมาชิกทั้งหมด";
            // 
            // addemployee
            // 
            this.addemployee.BackgroundImage = global::Projects.Properties.Resources.add_icon;
            this.addemployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addemployee.Location = new System.Drawing.Point(932, 110);
            this.addemployee.Name = "addemployee";
            this.addemployee.Size = new System.Drawing.Size(64, 62);
            this.addemployee.TabIndex = 198;
            this.addemployee.UseVisualStyleBackColor = true;
            this.addemployee.Click += new System.EventHandler(this.addemployee_Click);
            // 
            // but_print
            // 
            this.but_print.BackgroundImage = global::Projects.Properties.Resources.print_icon;
            this.but_print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_print.Location = new System.Drawing.Point(862, 110);
            this.but_print.Name = "but_print";
            this.but_print.Size = new System.Drawing.Size(64, 62);
            this.but_print.TabIndex = 197;
            this.but_print.UseVisualStyleBackColor = true;
            this.but_print.Click += new System.EventHandler(this.but_print_Click);
            // 
            // but_search1
            // 
            this.but_search1.BackColor = System.Drawing.Color.Transparent;
            this.but_search1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_search1.Location = new System.Drawing.Point(425, 138);
            this.but_search1.Name = "but_search1";
            this.but_search1.Size = new System.Drawing.Size(82, 23);
            this.but_search1.TabIndex = 232;
            this.but_search1.Text = "ค้นหา";
            this.but_search1.UseVisualStyleBackColor = false;
            this.but_search1.Click += new System.EventHandler(this.but_search1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.managerToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 108);
            this.menuStrip1.TabIndex = 233;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.menuToolStripMenuItem.Image = global::Projects.Properties.Resources.home_icon;
            this.menuToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(92, 104);
            this.menuToolStripMenuItem.Text = "หน้าแรก";
            this.menuToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addemployeeToolStripMenuItem,
            this.showemployeeToolStripMenuItem});
            this.employeeToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.employeeToolStripMenuItem.Image = global::Projects.Properties.Resources.employee_icon;
            this.employeeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(92, 104);
            this.employeeToolStripMenuItem.Text = "พนักงาน";
            this.employeeToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // addemployeeToolStripMenuItem
            // 
            this.addemployeeToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.addemployeeToolStripMenuItem.Name = "addemployeeToolStripMenuItem";
            this.addemployeeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addemployeeToolStripMenuItem.Text = "เพิ่มพนักงาน";
            this.addemployeeToolStripMenuItem.Click += new System.EventHandler(this.addemployeeToolStripMenuItem_Click);
            // 
            // showemployeeToolStripMenuItem
            // 
            this.showemployeeToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.showemployeeToolStripMenuItem.Name = "showemployeeToolStripMenuItem";
            this.showemployeeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.showemployeeToolStripMenuItem.Text = "ข้อมูลพนักงาน";
            this.showemployeeToolStripMenuItem.Click += new System.EventHandler(this.showemployeeToolStripMenuItem_Click);
            // 
            // managerToolStripMenuItem
            // 
            this.managerToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.managerToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.managerToolStripMenuItem.Image = global::Projects.Properties.Resources.manager_icon_mini;
            this.managerToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.managerToolStripMenuItem.Name = "managerToolStripMenuItem";
            this.managerToolStripMenuItem.Size = new System.Drawing.Size(92, 104);
            this.managerToolStripMenuItem.Text = "ผู้จัดการ";
            this.managerToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.managerToolStripMenuItem.Click += new System.EventHandler(this.managerToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.exitToolStripMenuItem.Image = global::Projects.Properties.Resources.exit_icon;
            this.exitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(102, 104);
            this.exitToolStripMenuItem.Text = "ออกจากระบบ";
            this.exitToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ShowEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projects.Properties.Resources.background4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 601);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.but_search1);
            this.Controls.Add(this.addemployee);
            this.Controls.Add(this.but_print);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.but_search);
            this.Controls.Add(this.label1);
            this.Name = "ShowEmployee";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ข้อมูลพนักงาน";
            this.Load += new System.EventHandler(this.ShowEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addemployee;
        private System.Windows.Forms.Button but_print;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Button but_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button but_search1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addemployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showemployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}