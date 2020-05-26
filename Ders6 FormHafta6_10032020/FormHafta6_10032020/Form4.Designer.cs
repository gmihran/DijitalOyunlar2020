namespace FormHafta6_10032020
{
    partial class Form4
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pBall = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBall)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(506, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(8, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "label2";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(228, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(477, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 131);
            this.label5.TabIndex = 19;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(387, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 131);
            this.label6.TabIndex = 20;
            this.label6.Text = "label6";
            // 
            // pBall
            // 
            this.pBall.Image = global::FormHafta6_10032020.Properties.Resources.ball1;
            this.pBall.Location = new System.Drawing.Point(11, 44);
            this.pBall.Name = "pBall";
            this.pBall.Size = new System.Drawing.Size(45, 38);
            this.pBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBall.TabIndex = 15;
            this.pBall.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(411, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(388, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Program.cs Application.Run(new Form4()); yapılmalıdır";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(615, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 100);
            this.label7.TabIndex = 25;
            this.label7.Text = "Bu örnekte topun label nesnelerine çarpması durumunda konumunun ilk konuma dönmes" +
    "i sağlanmıştır.";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pBall);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form4_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pBall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pBall;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
    }
}