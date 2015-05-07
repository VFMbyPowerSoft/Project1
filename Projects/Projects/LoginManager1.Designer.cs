namespace Projects
{
    partial class LoginManager1
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
            this.text_manager = new System.Windows.Forms.TextBox();
            this.text_Passw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.but_loginmanager = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // text_manager
            // 
            this.text_manager.Location = new System.Drawing.Point(173, 170);
            this.text_manager.Name = "text_manager";
            this.text_manager.Size = new System.Drawing.Size(100, 20);
            this.text_manager.TabIndex = 0;
            // 
            // text_Passw
            // 
            this.text_Passw.Location = new System.Drawing.Point(173, 209);
            this.text_Passw.Name = "text_Passw";
            this.text_Passw.PasswordChar = '*';
            this.text_Passw.Size = new System.Drawing.Size(100, 20);
            this.text_Passw.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("RSU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "ผู้จัดการ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("RSU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "รหัสผ่าน";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Projects.Properties.Resources.manager_icon;
            this.pictureBox1.Location = new System.Drawing.Point(130, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // but_loginmanager
            // 
            this.but_loginmanager.BackgroundImage = global::Projects.Properties.Resources.login_button1;
            this.but_loginmanager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_loginmanager.Location = new System.Drawing.Point(112, 245);
            this.but_loginmanager.Name = "but_loginmanager";
            this.but_loginmanager.Size = new System.Drawing.Size(152, 58);
            this.but_loginmanager.TabIndex = 4;
            this.but_loginmanager.UseVisualStyleBackColor = true;
            this.but_loginmanager.Click += new System.EventHandler(this.but_loginmanager_Click);
            // 
            // LoginManager1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projects.Properties.Resources.mini_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(352, 329);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.but_loginmanager);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_Passw);
            this.Controls.Add(this.text_manager);
            this.Name = "LoginManager1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "เข้าสู้ระบบผู้จัดการ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_manager;
        private System.Windows.Forms.TextBox text_Passw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button but_loginmanager;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}