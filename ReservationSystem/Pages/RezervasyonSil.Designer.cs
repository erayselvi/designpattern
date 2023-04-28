
namespace ReservationSystem
{
    partial class RezervasyonSil
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
            this.DGV_Konaklama = new System.Windows.Forms.DataGridView();
            this.DGV_Ulasim = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RezervasyonID_TB = new System.Windows.Forms.TextBox();
            this.KonaklamaSil = new System.Windows.Forms.RadioButton();
            this.UlasimSil = new System.Windows.Forms.RadioButton();
            this.Olustur_B = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Konaklama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Ulasim)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_Konaklama
            // 
            this.DGV_Konaklama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Konaklama.Location = new System.Drawing.Point(12, 251);
            this.DGV_Konaklama.Name = "DGV_Konaklama";
            this.DGV_Konaklama.RowHeadersWidth = 51;
            this.DGV_Konaklama.RowTemplate.Height = 29;
            this.DGV_Konaklama.Size = new System.Drawing.Size(706, 273);
            this.DGV_Konaklama.TabIndex = 0;
            // 
            // DGV_Ulasim
            // 
            this.DGV_Ulasim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Ulasim.Location = new System.Drawing.Point(724, 251);
            this.DGV_Ulasim.Name = "DGV_Ulasim";
            this.DGV_Ulasim.RowHeadersWidth = 51;
            this.DGV_Ulasim.RowTemplate.Height = 29;
            this.DGV_Ulasim.Size = new System.Drawing.Size(706, 273);
            this.DGV_Ulasim.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Unispace", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(24, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(571, 44);
            this.label5.TabIndex = 0;
            this.label5.Text = "REZERVASYON IPTAL EKRANI";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1438, 63);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.RezervasyonID_TB);
            this.groupBox1.Controls.Add(this.KonaklamaSil);
            this.groupBox1.Controls.Add(this.UlasimSil);
            this.groupBox1.Location = new System.Drawing.Point(24, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 125);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Unispace", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(246, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "SILMEK ISTEDIGINIZ REZERVE ID GIRINIZ";
            // 
            // RezervasyonID_TB
            // 
            this.RezervasyonID_TB.Location = new System.Drawing.Point(246, 56);
            this.RezervasyonID_TB.Name = "RezervasyonID_TB";
            this.RezervasyonID_TB.Size = new System.Drawing.Size(172, 27);
            this.RezervasyonID_TB.TabIndex = 2;
            // 
            // KonaklamaSil
            // 
            this.KonaklamaSil.AutoSize = true;
            this.KonaklamaSil.Location = new System.Drawing.Point(6, 76);
            this.KonaklamaSil.Name = "KonaklamaSil";
            this.KonaklamaSil.Size = new System.Drawing.Size(206, 24);
            this.KonaklamaSil.TabIndex = 1;
            this.KonaklamaSil.Text = "KONAKLAMA REZERVE SIL";
            this.KonaklamaSil.UseVisualStyleBackColor = true;
            // 
            // UlasimSil
            // 
            this.UlasimSil.AutoSize = true;
            this.UlasimSil.Checked = true;
            this.UlasimSil.Location = new System.Drawing.Point(3, 23);
            this.UlasimSil.Name = "UlasimSil";
            this.UlasimSil.Size = new System.Drawing.Size(169, 24);
            this.UlasimSil.TabIndex = 0;
            this.UlasimSil.TabStop = true;
            this.UlasimSil.Text = "ULASIM REZERVE SİL";
            this.UlasimSil.UseVisualStyleBackColor = true;
            // 
            // Olustur_B
            // 
            this.Olustur_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Olustur_B.ForeColor = System.Drawing.Color.White;
            this.Olustur_B.Location = new System.Drawing.Point(650, 128);
            this.Olustur_B.Name = "Olustur_B";
            this.Olustur_B.Size = new System.Drawing.Size(190, 61);
            this.Olustur_B.TabIndex = 21;
            this.Olustur_B.Text = "SIL";
            this.Olustur_B.UseVisualStyleBackColor = false;
            this.Olustur_B.Click += new System.EventHandler(this.RezerveSil_B_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Unispace", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(246, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "KONAKLAMA REZERVASYONLARI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Unispace", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(940, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "ULASIM REZERVASYONLARI";
            // 
            // RezervasyonSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1438, 536);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Olustur_B);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DGV_Ulasim);
            this.Controls.Add(this.DGV_Konaklama);
            this.Name = "RezervasyonSil";
            this.Text = "RezervasyonSil";
            this.Load += new System.EventHandler(this.RezervasyonSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Konaklama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Ulasim)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Konaklama;
        private System.Windows.Forms.DataGridView DGV_Ulasim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RezervasyonID_TB;
        private System.Windows.Forms.RadioButton KonaklamaSil;
        private System.Windows.Forms.RadioButton UlasimSil;
        private System.Windows.Forms.Button Olustur_B;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}