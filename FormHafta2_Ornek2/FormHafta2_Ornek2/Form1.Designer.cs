namespace FormHafta2_Ornek2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.btnTopla = new System.Windows.Forms.Button();
            this.radioTopla = new System.Windows.Forms.RadioButton();
            this.radioCikar = new System.Windows.Forms.RadioButton();
            this.radioCarp = new System.Windows.Forms.RadioButton();
            this.radioBol = new System.Windows.Forms.RadioButton();
            this.btnIslem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayı 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sayı 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sonuç";
            // 
            // txtSayi1
            // 
            this.txtSayi1.Location = new System.Drawing.Point(154, 40);
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(170, 20);
            this.txtSayi1.TabIndex = 3;
            this.txtSayi1.TextChanged += new System.EventHandler(this.txtSayi1_TextChanged);
            // 
            // txtSayi2
            // 
            this.txtSayi2.Location = new System.Drawing.Point(154, 67);
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(170, 20);
            this.txtSayi2.TabIndex = 4;
            this.txtSayi2.TextChanged += new System.EventHandler(this.txtSayi2_TextChanged);
            // 
            // txtSonuc
            // 
            this.txtSonuc.Location = new System.Drawing.Point(154, 95);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(170, 20);
            this.txtSonuc.TabIndex = 5;
            // 
            // btnTopla
            // 
            this.btnTopla.Location = new System.Drawing.Point(265, 160);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(75, 23);
            this.btnTopla.TabIndex = 6;
            this.btnTopla.Text = "Topla";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // radioTopla
            // 
            this.radioTopla.AutoSize = true;
            this.radioTopla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioTopla.Location = new System.Drawing.Point(154, 121);
            this.radioTopla.Name = "radioTopla";
            this.radioTopla.Size = new System.Drawing.Size(36, 24);
            this.radioTopla.TabIndex = 7;
            this.radioTopla.TabStop = true;
            this.radioTopla.Text = "+";
            this.radioTopla.UseVisualStyleBackColor = true;
            // 
            // radioCikar
            // 
            this.radioCikar.AutoSize = true;
            this.radioCikar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioCikar.Location = new System.Drawing.Point(191, 121);
            this.radioCikar.Name = "radioCikar";
            this.radioCikar.Size = new System.Drawing.Size(32, 24);
            this.radioCikar.TabIndex = 8;
            this.radioCikar.TabStop = true;
            this.radioCikar.Text = "-";
            this.radioCikar.UseVisualStyleBackColor = true;
            // 
            // radioCarp
            // 
            this.radioCarp.AutoSize = true;
            this.radioCarp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioCarp.Location = new System.Drawing.Point(228, 121);
            this.radioCarp.Name = "radioCarp";
            this.radioCarp.Size = new System.Drawing.Size(33, 24);
            this.radioCarp.TabIndex = 9;
            this.radioCarp.TabStop = true;
            this.radioCarp.Text = "*";
            this.radioCarp.UseVisualStyleBackColor = true;
            // 
            // radioBol
            // 
            this.radioBol.AutoSize = true;
            this.radioBol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBol.Location = new System.Drawing.Point(265, 121);
            this.radioBol.Name = "radioBol";
            this.radioBol.Size = new System.Drawing.Size(31, 24);
            this.radioBol.TabIndex = 10;
            this.radioBol.TabStop = true;
            this.radioBol.Text = "/";
            this.radioBol.UseVisualStyleBackColor = true;
            // 
            // btnIslem
            // 
            this.btnIslem.Location = new System.Drawing.Point(144, 161);
            this.btnIslem.Name = "btnIslem";
            this.btnIslem.Size = new System.Drawing.Size(100, 22);
            this.btnIslem.TabIndex = 11;
            this.btnIslem.Text = "İşlem Yap";
            this.btnIslem.UseVisualStyleBackColor = true;
            this.btnIslem.Click += new System.EventHandler(this.btnIslem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIslem);
            this.Controls.Add(this.radioBol);
            this.Controls.Add(this.radioCarp);
            this.Controls.Add(this.radioCikar);
            this.Controls.Add(this.radioTopla);
            this.Controls.Add(this.btnTopla);
            this.Controls.Add(this.txtSonuc);
            this.Controls.Add(this.txtSayi2);
            this.Controls.Add(this.txtSayi1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.RadioButton radioTopla;
        private System.Windows.Forms.RadioButton radioCikar;
        private System.Windows.Forms.RadioButton radioCarp;
        private System.Windows.Forms.RadioButton radioBol;
        private System.Windows.Forms.Button btnIslem;
    }
}

