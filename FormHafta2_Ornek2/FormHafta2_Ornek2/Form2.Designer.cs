namespace FormHafta2_Ornek2
{
    partial class Form2
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
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIslem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelSure = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelPuan = new System.Windows.Forms.Label();
            this.labelislem = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonBasla = new System.Windows.Forms.Button();
            this.buttonBitir = new System.Windows.Forms.Button();
            this.txtDurum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtSonuc
            // 
            this.txtSonuc.Location = new System.Drawing.Point(147, 112);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(170, 20);
            this.txtSonuc.TabIndex = 11;
            // 
            // txtSayi2
            // 
            this.txtSayi2.Location = new System.Drawing.Point(147, 86);
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(170, 20);
            this.txtSayi2.TabIndex = 10;
            // 
            // txtSayi1
            // 
            this.txtSayi1.Location = new System.Drawing.Point(147, 38);
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(170, 20);
            this.txtSayi1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sonuç";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sayı 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sayı 1";
            // 
            // btnIslem
            // 
            this.btnIslem.Location = new System.Drawing.Point(173, 138);
            this.btnIslem.Name = "btnIslem";
            this.btnIslem.Size = new System.Drawing.Size(100, 22);
            this.btnIslem.TabIndex = 12;
            this.btnIslem.Text = "İşlem Yap";
            this.btnIslem.UseVisualStyleBackColor = true;
            this.btnIslem.Click += new System.EventHandler(this.btnIslem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(402, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Süre";
            // 
            // labelSure
            // 
            this.labelSure.AutoSize = true;
            this.labelSure.Location = new System.Drawing.Point(437, 23);
            this.labelSure.Name = "labelSure";
            this.labelSure.Size = new System.Drawing.Size(35, 13);
            this.labelSure.TabIndex = 14;
            this.labelSure.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(402, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Puan";
            // 
            // labelPuan
            // 
            this.labelPuan.AutoSize = true;
            this.labelPuan.Location = new System.Drawing.Point(437, 41);
            this.labelPuan.Name = "labelPuan";
            this.labelPuan.Size = new System.Drawing.Size(35, 13);
            this.labelPuan.TabIndex = 16;
            this.labelPuan.Text = "label7";
            // 
            // labelislem
            // 
            this.labelislem.AutoSize = true;
            this.labelislem.Location = new System.Drawing.Point(211, 65);
            this.labelislem.Name = "labelislem";
            this.labelislem.Size = new System.Drawing.Size(35, 13);
            this.labelislem.TabIndex = 17;
            this.labelislem.Text = "label5";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonBasla
            // 
            this.buttonBasla.Location = new System.Drawing.Point(368, 83);
            this.buttonBasla.Name = "buttonBasla";
            this.buttonBasla.Size = new System.Drawing.Size(75, 23);
            this.buttonBasla.TabIndex = 18;
            this.buttonBasla.Text = "Oyuna Başla";
            this.buttonBasla.UseVisualStyleBackColor = true;
            this.buttonBasla.Click += new System.EventHandler(this.buttonBasla_Click);
            // 
            // buttonBitir
            // 
            this.buttonBitir.Location = new System.Drawing.Point(462, 83);
            this.buttonBitir.Name = "buttonBitir";
            this.buttonBitir.Size = new System.Drawing.Size(75, 23);
            this.buttonBitir.TabIndex = 19;
            this.buttonBitir.Text = "Oyunu Bitir";
            this.buttonBitir.UseVisualStyleBackColor = true;
            this.buttonBitir.Click += new System.EventHandler(this.buttonBitir_Click);
            // 
            // txtDurum
            // 
            this.txtDurum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtDurum.Location = new System.Drawing.Point(387, 116);
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.Size = new System.Drawing.Size(100, 20);
            this.txtDurum.TabIndex = 20;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDurum);
            this.Controls.Add(this.buttonBitir);
            this.Controls.Add(this.buttonBasla);
            this.Controls.Add(this.labelislem);
            this.Controls.Add(this.labelPuan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelSure);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnIslem);
            this.Controls.Add(this.txtSonuc);
            this.Controls.Add(this.txtSayi2);
            this.Controls.Add(this.txtSayi1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "İşlem Oyunu";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIslem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelSure;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelPuan;
        private System.Windows.Forms.Label labelislem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonBasla;
        private System.Windows.Forms.Button buttonBitir;
        private System.Windows.Forms.TextBox txtDurum;
    }
}