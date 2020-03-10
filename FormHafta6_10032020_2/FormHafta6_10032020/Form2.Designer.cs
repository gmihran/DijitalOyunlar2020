namespace FormHafta6_10032020
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
            this.btnSag = new System.Windows.Forms.Button();
            this.btnYukari = new System.Windows.Forms.Button();
            this.btnAsagi = new System.Windows.Forms.Button();
            this.btnSol = new System.Windows.Forms.Button();
            this.btnDur = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pBall = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBall)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSag
            // 
            this.btnSag.Location = new System.Drawing.Point(272, 326);
            this.btnSag.Name = "btnSag";
            this.btnSag.Size = new System.Drawing.Size(75, 23);
            this.btnSag.TabIndex = 17;
            this.btnSag.Text = "Sağ";
            this.btnSag.UseVisualStyleBackColor = true;
            this.btnSag.Click += new System.EventHandler(this.btnSag_Click);
            // 
            // btnYukari
            // 
            this.btnYukari.Location = new System.Drawing.Point(178, 285);
            this.btnYukari.Name = "btnYukari";
            this.btnYukari.Size = new System.Drawing.Size(75, 23);
            this.btnYukari.TabIndex = 16;
            this.btnYukari.Text = "Yukarı";
            this.btnYukari.UseVisualStyleBackColor = true;
            this.btnYukari.Click += new System.EventHandler(this.btnYukari_Click);
            // 
            // btnAsagi
            // 
            this.btnAsagi.Location = new System.Drawing.Point(178, 368);
            this.btnAsagi.Name = "btnAsagi";
            this.btnAsagi.Size = new System.Drawing.Size(75, 23);
            this.btnAsagi.TabIndex = 15;
            this.btnAsagi.Text = "Aşağı";
            this.btnAsagi.UseVisualStyleBackColor = true;
            this.btnAsagi.Click += new System.EventHandler(this.btnAsagi_Click);
            // 
            // btnSol
            // 
            this.btnSol.Location = new System.Drawing.Point(94, 326);
            this.btnSol.Name = "btnSol";
            this.btnSol.Size = new System.Drawing.Size(75, 23);
            this.btnSol.TabIndex = 14;
            this.btnSol.Text = "Sol";
            this.btnSol.UseVisualStyleBackColor = true;
            this.btnSol.Click += new System.EventHandler(this.btnSol_Click);
            // 
            // btnDur
            // 
            this.btnDur.Location = new System.Drawing.Point(178, 326);
            this.btnDur.Name = "btnDur";
            this.btnDur.Size = new System.Drawing.Size(75, 23);
            this.btnDur.TabIndex = 18;
            this.btnDur.Text = "Dur";
            this.btnDur.UseVisualStyleBackColor = true;
            this.btnDur.Click += new System.EventHandler(this.btnDur_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pBall
            // 
            this.pBall.Image = global::FormHafta6_10032020.Properties.Resources.ball1;
            this.pBall.Location = new System.Drawing.Point(178, 58);
            this.pBall.Name = "pBall";
            this.pBall.Size = new System.Drawing.Size(89, 83);
            this.pBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBall.TabIndex = 13;
            this.pBall.TabStop = false;
            this.pBall.Click += new System.EventHandler(this.pBall_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(412, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Program.cs Application.Run(new Form2()); yapılmalıdır";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(615, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 78);
            this.label2.TabIndex = 24;
            this.label2.Text = "Bu örnekte buttonlar ile topun sürekli hareket ettirilmesi sağlanmıştır.";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 459);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDur);
            this.Controls.Add(this.btnSag);
            this.Controls.Add(this.btnYukari);
            this.Controls.Add(this.btnAsagi);
            this.Controls.Add(this.btnSol);
            this.Controls.Add(this.pBall);
            this.Name = "Form2";
            this.Text = "Form2";
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
        private System.Windows.Forms.Button btnDur;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}