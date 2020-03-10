namespace FormHafta6_10032020
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
            this.btnSag = new System.Windows.Forms.Button();
            this.btnYukari = new System.Windows.Forms.Button();
            this.btnAsagi = new System.Windows.Forms.Button();
            this.btnSol = new System.Windows.Forms.Button();
            this.pBall = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBall)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSag
            // 
            this.btnSag.Location = new System.Drawing.Point(253, 339);
            this.btnSag.Name = "btnSag";
            this.btnSag.Size = new System.Drawing.Size(75, 23);
            this.btnSag.TabIndex = 7;
            this.btnSag.Text = "Sağ";
            this.btnSag.UseVisualStyleBackColor = true;
            this.btnSag.Click += new System.EventHandler(this.btnSag_Click);
            // 
            // btnYukari
            // 
            this.btnYukari.Location = new System.Drawing.Point(159, 298);
            this.btnYukari.Name = "btnYukari";
            this.btnYukari.Size = new System.Drawing.Size(75, 23);
            this.btnYukari.TabIndex = 6;
            this.btnYukari.Text = "Yukarı";
            this.btnYukari.UseVisualStyleBackColor = true;
            this.btnYukari.Click += new System.EventHandler(this.btnYukari_Click);
            // 
            // btnAsagi
            // 
            this.btnAsagi.Location = new System.Drawing.Point(159, 381);
            this.btnAsagi.Name = "btnAsagi";
            this.btnAsagi.Size = new System.Drawing.Size(75, 23);
            this.btnAsagi.TabIndex = 5;
            this.btnAsagi.Text = "Aşağı";
            this.btnAsagi.UseVisualStyleBackColor = true;
            this.btnAsagi.Click += new System.EventHandler(this.btnAsagi_Click);
            // 
            // btnSol
            // 
            this.btnSol.Location = new System.Drawing.Point(75, 339);
            this.btnSol.Name = "btnSol";
            this.btnSol.Size = new System.Drawing.Size(75, 23);
            this.btnSol.TabIndex = 4;
            this.btnSol.Text = "Sol";
            this.btnSol.UseVisualStyleBackColor = true;
            this.btnSol.Click += new System.EventHandler(this.btnSol_Click);
            // 
            // pBall
            // 
            this.pBall.Image = global::FormHafta6_10032020.Properties.Resources.ball1;
            this.pBall.Location = new System.Drawing.Point(145, 53);
            this.pBall.Name = "pBall";
            this.pBall.Size = new System.Drawing.Size(89, 83);
            this.pBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBall.TabIndex = 14;
            this.pBall.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(400, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(388, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Program.cs Application.Run(new Form1()); yapılmalıdır";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(610, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 91);
            this.label1.TabIndex = 23;
            this.label1.Text = "Bu örnekte buttonlar ile topun sadece bir kere hareket ettirilmesi sağlanmıştır.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pBall);
            this.Controls.Add(this.btnSag);
            this.Controls.Add(this.btnYukari);
            this.Controls.Add(this.btnAsagi);
            this.Controls.Add(this.btnSol);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pBall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSag;
        private System.Windows.Forms.Button btnYukari;
        private System.Windows.Forms.Button btnAsagi;
        private System.Windows.Forms.Button btnSol;
        private System.Windows.Forms.PictureBox pBall;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}

