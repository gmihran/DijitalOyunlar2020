namespace Hafta3_FormApp
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBuyukHarf = new System.Windows.Forms.Button();
            this.labelKelime = new System.Windows.Forms.Label();
            this.labelRastK = new System.Windows.Forms.Label();
            this.buttonRastgele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hafta3_FormApp.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(39, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(193, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnBuyukHarf
            // 
            this.btnBuyukHarf.Location = new System.Drawing.Point(193, 74);
            this.btnBuyukHarf.Name = "btnBuyukHarf";
            this.btnBuyukHarf.Size = new System.Drawing.Size(124, 23);
            this.btnBuyukHarf.TabIndex = 2;
            this.btnBuyukHarf.Text = "Büyük harfe dönüştür";
            this.btnBuyukHarf.UseVisualStyleBackColor = true;
            this.btnBuyukHarf.Click += new System.EventHandler(this.btnBuyukHarf_Click);
            // 
            // labelKelime
            // 
            this.labelKelime.AutoSize = true;
            this.labelKelime.Location = new System.Drawing.Point(341, 41);
            this.labelKelime.Name = "labelKelime";
            this.labelKelime.Size = new System.Drawing.Size(38, 13);
            this.labelKelime.TabIndex = 3;
            this.labelKelime.Text = "Kelime";
            // 
            // labelRastK
            // 
            this.labelRastK.AutoSize = true;
            this.labelRastK.Location = new System.Drawing.Point(550, 45);
            this.labelRastK.Name = "labelRastK";
            this.labelRastK.Size = new System.Drawing.Size(35, 13);
            this.labelRastK.TabIndex = 4;
            this.labelRastK.Text = "label1";
            // 
            // buttonRastgele
            // 
            this.buttonRastgele.Location = new System.Drawing.Point(511, 74);
            this.buttonRastgele.Name = "buttonRastgele";
            this.buttonRastgele.Size = new System.Drawing.Size(116, 23);
            this.buttonRastgele.TabIndex = 5;
            this.buttonRastgele.Text = "Kelime Oluştur";
            this.buttonRastgele.UseVisualStyleBackColor = true;
            this.buttonRastgele.Click += new System.EventHandler(this.buttonRastgele_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 511);
            this.Controls.Add(this.buttonRastgele);
            this.Controls.Add(this.labelRastK);
            this.Controls.Add(this.labelKelime);
            this.Controls.Add(this.btnBuyukHarf);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBuyukHarf;
        private System.Windows.Forms.Label labelKelime;
        private System.Windows.Forms.Label labelRastK;
        private System.Windows.Forms.Button buttonRastgele;
    }
}

