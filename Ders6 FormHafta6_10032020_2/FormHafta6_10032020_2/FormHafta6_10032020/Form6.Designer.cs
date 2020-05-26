namespace FormHafta6_10032020
{
    partial class Form6
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
            this.btnDur = new System.Windows.Forms.Button();
            this.btnSag = new System.Windows.Forms.Button();
            this.btnYukari = new System.Windows.Forms.Button();
            this.btnAsagi = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnSol = new System.Windows.Forms.Button();
            this.btnSolYukari = new System.Windows.Forms.Button();
            this.btnSagYukari = new System.Windows.Forms.Button();
            this.btnSolAsagi = new System.Windows.Forms.Button();
            this.btnSagAsagi = new System.Windows.Forms.Button();
            this.pBall = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBall)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDur
            // 
            this.btnDur.Location = new System.Drawing.Point(138, 303);
            this.btnDur.Name = "btnDur";
            this.btnDur.Size = new System.Drawing.Size(75, 23);
            this.btnDur.TabIndex = 24;
            this.btnDur.Text = "Dur";
            this.btnDur.UseVisualStyleBackColor = true;
            this.btnDur.Click += new System.EventHandler(this.btnDur_Click);
            // 
            // btnSag
            // 
            this.btnSag.Location = new System.Drawing.Point(232, 303);
            this.btnSag.Name = "btnSag";
            this.btnSag.Size = new System.Drawing.Size(75, 23);
            this.btnSag.TabIndex = 23;
            this.btnSag.Text = "Sağ";
            this.btnSag.UseVisualStyleBackColor = true;
            this.btnSag.Click += new System.EventHandler(this.btnSag_Click);
            // 
            // btnYukari
            // 
            this.btnYukari.Location = new System.Drawing.Point(138, 262);
            this.btnYukari.Name = "btnYukari";
            this.btnYukari.Size = new System.Drawing.Size(75, 23);
            this.btnYukari.TabIndex = 22;
            this.btnYukari.Text = "Yukarı";
            this.btnYukari.UseVisualStyleBackColor = true;
            this.btnYukari.Click += new System.EventHandler(this.btnYukari_Click);
            // 
            // btnAsagi
            // 
            this.btnAsagi.Location = new System.Drawing.Point(138, 345);
            this.btnAsagi.Name = "btnAsagi";
            this.btnAsagi.Size = new System.Drawing.Size(75, 23);
            this.btnAsagi.TabIndex = 21;
            this.btnAsagi.Text = "Aşağı";
            this.btnAsagi.UseVisualStyleBackColor = true;
            this.btnAsagi.Click += new System.EventHandler(this.btnAsagi_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnSol
            // 
            this.btnSol.Location = new System.Drawing.Point(54, 303);
            this.btnSol.Name = "btnSol";
            this.btnSol.Size = new System.Drawing.Size(75, 23);
            this.btnSol.TabIndex = 20;
            this.btnSol.Text = "Sol";
            this.btnSol.UseVisualStyleBackColor = true;
            this.btnSol.Click += new System.EventHandler(this.btnSol_Click);
            // 
            // btnSolYukari
            // 
            this.btnSolYukari.Location = new System.Drawing.Point(54, 262);
            this.btnSolYukari.Name = "btnSolYukari";
            this.btnSolYukari.Size = new System.Drawing.Size(75, 23);
            this.btnSolYukari.TabIndex = 25;
            this.btnSolYukari.Text = "Sol Yukarı";
            this.btnSolYukari.UseVisualStyleBackColor = true;
            this.btnSolYukari.Click += new System.EventHandler(this.btnSolYukari_Click);
            // 
            // btnSagYukari
            // 
            this.btnSagYukari.Location = new System.Drawing.Point(232, 262);
            this.btnSagYukari.Name = "btnSagYukari";
            this.btnSagYukari.Size = new System.Drawing.Size(75, 23);
            this.btnSagYukari.TabIndex = 26;
            this.btnSagYukari.Text = "Sağ Yukarı";
            this.btnSagYukari.UseVisualStyleBackColor = true;
            this.btnSagYukari.Click += new System.EventHandler(this.btnSagYukari_Click);
            // 
            // btnSolAsagi
            // 
            this.btnSolAsagi.Location = new System.Drawing.Point(54, 345);
            this.btnSolAsagi.Name = "btnSolAsagi";
            this.btnSolAsagi.Size = new System.Drawing.Size(75, 23);
            this.btnSolAsagi.TabIndex = 27;
            this.btnSolAsagi.Text = "Sol Aşağı";
            this.btnSolAsagi.UseVisualStyleBackColor = true;
            this.btnSolAsagi.Click += new System.EventHandler(this.btnSolAsagi_Click);
            // 
            // btnSagAsagi
            // 
            this.btnSagAsagi.Location = new System.Drawing.Point(232, 345);
            this.btnSagAsagi.Name = "btnSagAsagi";
            this.btnSagAsagi.Size = new System.Drawing.Size(75, 23);
            this.btnSagAsagi.TabIndex = 28;
            this.btnSagAsagi.Text = "Sağ Aşağı";
            this.btnSagAsagi.UseVisualStyleBackColor = true;
            this.btnSagAsagi.Click += new System.EventHandler(this.btnSagAsagi_Click);
            // 
            // pBall
            // 
            this.pBall.Image = global::FormHafta6_10032020.Properties.Resources.ball1;
            this.pBall.Location = new System.Drawing.Point(138, 35);
            this.pBall.Name = "pBall";
            this.pBall.Size = new System.Drawing.Size(89, 83);
            this.pBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBall.TabIndex = 19;
            this.pBall.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(569, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 78);
            this.label2.TabIndex = 29;
            this.label2.Text = "Bu örnekte buttonlar ile topun sürekli hareket ettirilmesi sağlanmıştır.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(400, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Program.cs Application.Run(new Form6()); yapılmalıdır";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 447);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSagAsagi);
            this.Controls.Add(this.btnSolAsagi);
            this.Controls.Add(this.btnSagYukari);
            this.Controls.Add(this.btnSolYukari);
            this.Controls.Add(this.btnDur);
            this.Controls.Add(this.btnSag);
            this.Controls.Add(this.btnYukari);
            this.Controls.Add(this.btnAsagi);
            this.Controls.Add(this.btnSol);
            this.Controls.Add(this.pBall);
            this.Name = "Form6";
            this.Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)(this.pBall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDur;
        private System.Windows.Forms.Button btnSag;
        private System.Windows.Forms.Button btnYukari;
        private System.Windows.Forms.Button btnAsagi;
        private System.Windows.Forms.PictureBox pBall;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnSol;
        private System.Windows.Forms.Button btnSolYukari;
        private System.Windows.Forms.Button btnSagYukari;
        private System.Windows.Forms.Button btnSolAsagi;
        private System.Windows.Forms.Button btnSagAsagi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}