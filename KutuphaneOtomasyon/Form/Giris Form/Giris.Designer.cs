
namespace KutuphaneOtomasyon
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.button1 = new System.Windows.Forms.Button();
            this.Users = new System.Windows.Forms.RadioButton();
            this.Admins = new System.Windows.Forms.RadioButton();
            this.cikisButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(762, 500);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "GİRİŞ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Users
            // 
            this.Users.AutoSize = true;
            this.Users.BackColor = System.Drawing.Color.Transparent;
            this.Users.Location = new System.Drawing.Point(728, 295);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(67, 17);
            this.Users.TabIndex = 2;
            this.Users.TabStop = true;
            this.Users.Text = "Kullanıcı ";
            this.Users.UseVisualStyleBackColor = false;
            // 
            // Admins
            // 
            this.Admins.AutoSize = true;
            this.Admins.BackColor = System.Drawing.Color.Transparent;
            this.Admins.Location = new System.Drawing.Point(833, 295);
            this.Admins.Name = "Admins";
            this.Admins.Size = new System.Drawing.Size(63, 17);
            this.Admins.TabIndex = 2;
            this.Admins.TabStop = true;
            this.Admins.Text = "Yönetici";
            this.Admins.UseVisualStyleBackColor = false;
            // 
            // cikisButton
            // 
            this.cikisButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.cikisButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cikisButton.BackgroundImage")));
            this.cikisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikisButton.ForeColor = System.Drawing.Color.White;
            this.cikisButton.Location = new System.Drawing.Point(783, 469);
            this.cikisButton.Name = "cikisButton";
            this.cikisButton.Size = new System.Drawing.Size(85, 25);
            this.cikisButton.TabIndex = 3;
            this.cikisButton.Text = "Çıkış";
            this.cikisButton.UseVisualStyleBackColor = false;
            this.cikisButton.Click += new System.EventHandler(this.cikisButton_Click);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.cikisButton);
            this.Controls.Add(this.Admins);
            this.Controls.Add(this.Users);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Giris";
            this.Text = "Giris";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Giris_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton Users;
        private System.Windows.Forms.RadioButton Admins;
        private System.Windows.Forms.Button cikisButton;
    }
}