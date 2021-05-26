
namespace KutuphaneOtomasyon
{
    partial class KitapTeslimEtme
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewDataEn = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataEn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitap Teslim";
            // 
            // dataGridViewDataEn
            // 
            this.dataGridViewDataEn.AllowUserToResizeRows = false;
            this.dataGridViewDataEn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDataEn.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDataEn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewDataEn.ColumnHeadersHeight = 30;
            this.dataGridViewDataEn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewDataEn.Location = new System.Drawing.Point(19, 75);
            this.dataGridViewDataEn.Name = "dataGridViewDataEn";
            this.dataGridViewDataEn.Size = new System.Drawing.Size(659, 458);
            this.dataGridViewDataEn.TabIndex = 8;
            // 
            // KitapTeslimEtme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1334, 561);
            this.Controls.Add(this.dataGridViewDataEn);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(37)))), ((int)(((byte)(87)))));
            this.Name = "KitapTeslimEtme";
            this.Text = "KitapTeslimEtme";
            this.Load += new System.EventHandler(this.KitapTeslimEtme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataEn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewDataEn;
    }
}