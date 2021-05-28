
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace KutuphaneOtomasyon
{
    partial class FormProfil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelUserSurname = new System.Windows.Forms.Label();
            this.labelUserBirthDate = new System.Windows.Forms.Label();
            this.labelUserTckn = new System.Windows.Forms.Label();
            this.labelUserId = new System.Windows.Forms.Label();
            this.labelUserMail = new System.Windows.Forms.Label();
            this.labelUserPhone = new System.Windows.Forms.Label();
            this.labelUserStatus = new System.Windows.Forms.Label();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.labelUserRegisterDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(37)))), ((int)(((byte)(87)))));
            this.label2.Location = new System.Drawing.Point(22, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 42);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kullanıcı Bilgileri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(25, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "İSİM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(25, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "SOYİSİM";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(25, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "DOĞUM TARİHİ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(25, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "TC KİMLİK NO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(25, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "KULLANICI ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(25, 367);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "KAYIT TARİHİ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(25, 415);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "E-POSTA";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(25, 462);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 24);
            this.label10.TabIndex = 0;
            this.label10.Text = "CEP TELEFONU";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(25, 508);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 24);
            this.label11.TabIndex = 0;
            this.label11.Text = "DURUMU";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.BackColor = System.Drawing.Color.Transparent;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelUserName.ForeColor = System.Drawing.Color.Black;
            this.labelUserName.Location = new System.Drawing.Point(363, 106);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(65, 24);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "YASİN";
            this.labelUserName.Click += new System.EventHandler(this.label12_Click);
            // 
            // labelUserSurname
            // 
            this.labelUserSurname.AutoSize = true;
            this.labelUserSurname.BackColor = System.Drawing.Color.Transparent;
            this.labelUserSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelUserSurname.ForeColor = System.Drawing.Color.Black;
            this.labelUserSurname.Location = new System.Drawing.Point(363, 161);
            this.labelUserSurname.Name = "labelUserSurname";
            this.labelUserSurname.Size = new System.Drawing.Size(53, 24);
            this.labelUserSurname.TabIndex = 0;
            this.labelUserSurname.Text = "KILIÇ";
            // 
            // labelUserBirthDate
            // 
            this.labelUserBirthDate.AutoSize = true;
            this.labelUserBirthDate.BackColor = System.Drawing.Color.Transparent;
            this.labelUserBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelUserBirthDate.ForeColor = System.Drawing.Color.Black;
            this.labelUserBirthDate.Location = new System.Drawing.Point(363, 211);
            this.labelUserBirthDate.Name = "labelUserBirthDate";
            this.labelUserBirthDate.Size = new System.Drawing.Size(100, 24);
            this.labelUserBirthDate.TabIndex = 0;
            this.labelUserBirthDate.Text = "25.03.1998";
            // 
            // labelUserTckn
            // 
            this.labelUserTckn.AutoSize = true;
            this.labelUserTckn.BackColor = System.Drawing.Color.Transparent;
            this.labelUserTckn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelUserTckn.ForeColor = System.Drawing.Color.Black;
            this.labelUserTckn.Location = new System.Drawing.Point(363, 267);
            this.labelUserTckn.Name = "labelUserTckn";
            this.labelUserTckn.Size = new System.Drawing.Size(120, 24);
            this.labelUserTckn.TabIndex = 0;
            this.labelUserTckn.Text = "72919084358";
            // 
            // labelUserId
            // 
            this.labelUserId.AutoSize = true;
            this.labelUserId.BackColor = System.Drawing.Color.Transparent;
            this.labelUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelUserId.ForeColor = System.Drawing.Color.Black;
            this.labelUserId.Location = new System.Drawing.Point(363, 314);
            this.labelUserId.Name = "labelUserId";
            this.labelUserId.Size = new System.Drawing.Size(116, 24);
            this.labelUserId.TabIndex = 0;
            this.labelUserId.Text = "m195036049";
            // 
            // labelUserMail
            // 
            this.labelUserMail.AutoSize = true;
            this.labelUserMail.BackColor = System.Drawing.Color.Transparent;
            this.labelUserMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelUserMail.ForeColor = System.Drawing.Color.Black;
            this.labelUserMail.Location = new System.Drawing.Point(363, 415);
            this.labelUserMail.Name = "labelUserMail";
            this.labelUserMail.Size = new System.Drawing.Size(191, 24);
            this.labelUserMail.TabIndex = 0;
            this.labelUserMail.Text = "kilic.yasn@gmail.com";
            // 
            // labelUserPhone
            // 
            this.labelUserPhone.AutoSize = true;
            this.labelUserPhone.BackColor = System.Drawing.Color.Transparent;
            this.labelUserPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelUserPhone.ForeColor = System.Drawing.Color.Black;
            this.labelUserPhone.Location = new System.Drawing.Point(363, 462);
            this.labelUserPhone.Name = "labelUserPhone";
            this.labelUserPhone.Size = new System.Drawing.Size(130, 24);
            this.labelUserPhone.TabIndex = 0;
            this.labelUserPhone.Text = "0534 697 0287";
            // 
            // labelUserStatus
            // 
            this.labelUserStatus.AutoSize = true;
            this.labelUserStatus.BackColor = System.Drawing.Color.Transparent;
            this.labelUserStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelUserStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(37)))), ((int)(((byte)(87)))));
            this.labelUserStatus.Location = new System.Drawing.Point(363, 508);
            this.labelUserStatus.Name = "labelUserStatus";
            this.labelUserStatus.Size = new System.Drawing.Size(128, 24);
            this.labelUserStatus.TabIndex = 0;
            this.labelUserStatus.Text = "Devam Ediyor";
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Location = new System.Drawing.Point(999, 84);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(143, 162);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImage.TabIndex = 2;
            this.pictureBoxImage.TabStop = false;
            // 
            // labelUserRegisterDate
            // 
            this.labelUserRegisterDate.AutoSize = true;
            this.labelUserRegisterDate.BackColor = System.Drawing.Color.Transparent;
            this.labelUserRegisterDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelUserRegisterDate.ForeColor = System.Drawing.Color.Black;
            this.labelUserRegisterDate.Location = new System.Drawing.Point(363, 367);
            this.labelUserRegisterDate.Name = "labelUserRegisterDate";
            this.labelUserRegisterDate.Size = new System.Drawing.Size(100, 24);
            this.labelUserRegisterDate.TabIndex = 0;
            this.labelUserRegisterDate.Text = "15.04.2021";
            // 
            // FormProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 561);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelUserStatus);
            this.Controls.Add(this.labelUserPhone);
            this.Controls.Add(this.labelUserMail);
            this.Controls.Add(this.labelUserRegisterDate);
            this.Controls.Add(this.labelUserId);
            this.Controls.Add(this.labelUserTckn);
            this.Controls.Add(this.labelUserBirthDate);
            this.Controls.Add(this.labelUserSurname);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "FormProfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KullanıcıAl";
            this.Load += new System.EventHandler(this.FormProfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label labelUserName;
        private Label labelUserSurname;
        private Label labelUserBirthDate;
        private Label labelUserTckn;
        private Label labelUserId;
        private Label labelUserMail;
        private Label labelUserPhone;
        private Label labelUserStatus;
        private PictureBox pictureBoxImage;
        private Label labelUserRegisterDate;
    }
}