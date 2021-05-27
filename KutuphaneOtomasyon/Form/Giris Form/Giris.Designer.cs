
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
            this.btnGiris = new System.Windows.Forms.Button();
            this.rdUsers = new System.Windows.Forms.RadioButton();
            this.rdAdmins = new System.Windows.Forms.RadioButton();
            this.cikisButton = new System.Windows.Forms.Button();
            this.txtLogPass = new System.Windows.Forms.TextBox();
            this.txtLogMail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGiris.BackgroundImage")));
            this.btnGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGiris.FlatAppearance.BorderSize = 0;
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiris.ForeColor = System.Drawing.Color.White;
            this.btnGiris.Location = new System.Drawing.Point(762, 462);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(118, 37);
            this.btnGiris.TabIndex = 1;
            this.btnGiris.Text = "GİRİŞ";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // rdUsers
            // 
            this.rdUsers.AutoSize = true;
            this.rdUsers.BackColor = System.Drawing.Color.Transparent;
            this.rdUsers.Location = new System.Drawing.Point(728, 295);
            this.rdUsers.Name = "rdUsers";
            this.rdUsers.Size = new System.Drawing.Size(67, 17);
            this.rdUsers.TabIndex = 2;
            this.rdUsers.TabStop = true;
            this.rdUsers.Text = "Kullanıcı ";
            this.rdUsers.UseVisualStyleBackColor = false;
            // 
            // rdAdmins
            // 
            this.rdAdmins.AutoSize = true;
            this.rdAdmins.BackColor = System.Drawing.Color.Transparent;
            this.rdAdmins.Location = new System.Drawing.Point(833, 295);
            this.rdAdmins.Name = "rdAdmins";
            this.rdAdmins.Size = new System.Drawing.Size(63, 17);
            this.rdAdmins.TabIndex = 2;
            this.rdAdmins.TabStop = true;
            this.rdAdmins.Text = "Yönetici";
            this.rdAdmins.UseVisualStyleBackColor = false;
            // 
            // cikisButton
            // 
            this.cikisButton.AutoEllipsis = true;
            this.cikisButton.BackColor = System.Drawing.Color.White;
            this.cikisButton.BackgroundImage = global::KutuphaneOtomasyon.Properties.Resources.giriş_butonu0_400x94;
            this.cikisButton.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.cikisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikisButton.ForeColor = System.Drawing.Color.White;
            this.cikisButton.Location = new System.Drawing.Point(766, 505);
            this.cikisButton.Name = "cikisButton";
            this.cikisButton.Size = new System.Drawing.Size(109, 29);
            this.cikisButton.TabIndex = 3;
            this.cikisButton.Text = "ÇIKIŞ";
            this.cikisButton.UseVisualStyleBackColor = false;
            this.cikisButton.Click += new System.EventHandler(this.cikisButton_Click);
            // 
            // txtLogPass
            // 
            this.txtLogPass.BackColor = System.Drawing.Color.White;
            this.txtLogPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogPass.ForeColor = System.Drawing.Color.Gray;
            this.txtLogPass.Location = new System.Drawing.Point(743, 415);
            this.txtLogPass.Name = "txtLogPass";
            this.txtLogPass.PasswordChar = '*';
            this.txtLogPass.Size = new System.Drawing.Size(152, 20);
            this.txtLogPass.TabIndex = 4;
            this.txtLogPass.Click += new System.EventHandler(this.txtLogPass_Click);
            // 
            // txtLogMail
            // 
            this.txtLogMail.BackColor = System.Drawing.Color.White;
            this.txtLogMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLogMail.ForeColor = System.Drawing.Color.Black;
            this.txtLogMail.Location = new System.Drawing.Point(743, 339);
            this.txtLogMail.Name = "txtLogMail";
            this.txtLogMail.Size = new System.Drawing.Size(152, 20);
            this.txtLogMail.TabIndex = 4;
            this.txtLogMail.Click += new System.EventHandler(this.txtLogMail_Click);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.txtLogMail);
            this.Controls.Add(this.txtLogPass);
            this.Controls.Add(this.cikisButton);
            this.Controls.Add(this.rdAdmins);
            this.Controls.Add(this.rdUsers);
            this.Controls.Add(this.btnGiris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GİRİŞ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Giris_FormClosing);
            this.Load += new System.EventHandler(this.Giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.RadioButton rdUsers;
        private System.Windows.Forms.RadioButton rdAdmins;
        private System.Windows.Forms.Button cikisButton;
        private System.Windows.Forms.TextBox txtLogPass;
        private System.Windows.Forms.TextBox txtLogMail;
    }
}