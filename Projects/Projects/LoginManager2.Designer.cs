namespace Projects
{
    partial class LoginManager2
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
            this.label1 = new System.Windows.Forms.Label();
            this.but_Manager = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text_manager
            // 
            this.text_manager.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_manager.Location = new System.Drawing.Point(85, 82);
            this.text_manager.Multiline = true;
            this.text_manager.Name = "text_manager";
            this.text_manager.PasswordChar = '*';
            this.text_manager.Size = new System.Drawing.Size(205, 31);
            this.text_manager.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("RSU", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "รหัสผู้จัดการ";
            // 
            // but_Manager
            // 
            this.but_Manager.BackColor = System.Drawing.Color.Transparent;
            this.but_Manager.BackgroundImage = global::Projects.Properties.Resources.login_button1;
            this.but_Manager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_Manager.Location = new System.Drawing.Point(112, 128);
            this.but_Manager.Name = "but_Manager";
            this.but_Manager.Size = new System.Drawing.Size(152, 58);
            this.but_Manager.TabIndex = 2;
            this.but_Manager.UseVisualStyleBackColor = false;
            this.but_Manager.Click += new System.EventHandler(this.but_Manager_Click);
            // 
            // LoginManager2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projects.Properties.Resources.mini_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(373, 210);
            this.Controls.Add(this.but_Manager);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_manager);
            this.Name = "LoginManager2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "เข้าสู่ระบบผู้จัดการ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_manager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button but_Manager;
    }
}