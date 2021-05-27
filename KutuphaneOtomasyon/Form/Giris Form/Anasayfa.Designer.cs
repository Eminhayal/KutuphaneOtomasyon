
namespace KutuphaneOtomasyon
{
    partial class Anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.profilButton = new System.Windows.Forms.Button();
            this.kitapAraAlButton = new System.Windows.Forms.Button();
            this.kitapTeslimButton = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panelKullanici = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // profilButton
            // 
            this.profilButton.BackColor = System.Drawing.Color.Transparent;
            this.profilButton.BackgroundImage = global::KutuphaneOtomasyon.Properties.Resources.giriş_butonu0_450x30;
            this.profilButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profilButton.ForeColor = System.Drawing.Color.White;
            this.profilButton.Image = global::KutuphaneOtomasyon.Properties.Resources.giriş_butonu0_400x94;
            this.profilButton.Location = new System.Drawing.Point(0, 99);
            this.profilButton.Name = "profilButton";
            this.profilButton.Size = new System.Drawing.Size(337, 30);
            this.profilButton.TabIndex = 0;
            this.profilButton.Text = "PROFİL";
            this.profilButton.UseVisualStyleBackColor = false;
            this.profilButton.Click += new System.EventHandler(this.profilButton_Click);
            // 
            // kitapAraAlButton
            // 
            this.kitapAraAlButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.kitapAraAlButton.BackgroundImage = global::KutuphaneOtomasyon.Properties.Resources.giriş_butonu0_450x30;
            this.kitapAraAlButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kitapAraAlButton.ForeColor = System.Drawing.Color.White;
            this.kitapAraAlButton.Location = new System.Drawing.Point(327, 99);
            this.kitapAraAlButton.Name = "kitapAraAlButton";
            this.kitapAraAlButton.Size = new System.Drawing.Size(345, 30);
            this.kitapAraAlButton.TabIndex = 1;
            this.kitapAraAlButton.Text = "KİTAP ARA / AL";
            this.kitapAraAlButton.UseVisualStyleBackColor = false;
            this.kitapAraAlButton.Click += new System.EventHandler(this.kitapAraAlButton_Click_1);
            // 
            // kitapTeslimButton
            // 
            this.kitapTeslimButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.kitapTeslimButton.BackgroundImage = global::KutuphaneOtomasyon.Properties.Resources.giriş_butonu0_450x30;
            this.kitapTeslimButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kitapTeslimButton.ForeColor = System.Drawing.Color.White;
            this.kitapTeslimButton.Location = new System.Drawing.Point(670, 99);
            this.kitapTeslimButton.Name = "kitapTeslimButton";
            this.kitapTeslimButton.Size = new System.Drawing.Size(345, 30);
            this.kitapTeslimButton.TabIndex = 3;
            this.kitapTeslimButton.Text = "KİTAP TESLİM ETME";
            this.kitapTeslimButton.UseVisualStyleBackColor = false;
            this.kitapTeslimButton.Click += new System.EventHandler(this.kitapTeslimButton_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(-1, 637);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(400, 94);
            this.button7.TabIndex = 6;
            this.button7.Text = "ÇIKIŞ";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // panelKullanici
            // 
            this.panelKullanici.Location = new System.Drawing.Point(0, 134);
            this.panelKullanici.Margin = new System.Windows.Forms.Padding(2);
            this.panelKullanici.Name = "panelKullanici";
            this.panelKullanici.Size = new System.Drawing.Size(1350, 600);
            this.panelKullanici.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(398, 19);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.BackgroundImage = global::KutuphaneOtomasyon.Properties.Resources.giriş_butonu0_400x94;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::KutuphaneOtomasyon.Properties.Resources.exit_butonu0;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(1013, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(337, 30);
            this.button2.TabIndex = 14;
            this.button2.Text = "ÇIKIŞ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KutuphaneOtomasyon.Properties.Resources.arkaplan_50;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.kitapTeslimButton);
            this.Controls.Add(this.kitapAraAlButton);
            this.Controls.Add(this.profilButton);
            this.Controls.Add(this.panelKullanici);
            this.Controls.Add(this.button7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button profilButton;
        private System.Windows.Forms.Button kitapAraAlButton;
        private System.Windows.Forms.Button kitapTeslimButton;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panelKullanici;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}