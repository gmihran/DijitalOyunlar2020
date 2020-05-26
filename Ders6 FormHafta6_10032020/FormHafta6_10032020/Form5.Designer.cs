namespace FormHafta6_10032020
{
    partial class Form5
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
            this.pBall = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBall)).BeginInit();
            this.SuspendLayout();
            // 
            // pBall
            // 
            this.pBall.Image = global::FormHafta6_10032020.Properties.Resources.ball1;
            this.pBall.Location = new System.Drawing.Point(299, 23);
            this.pBall.Name = "pBall";
            this.pBall.Size = new System.Drawing.Size(64, 53);
            this.pBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBall.TabIndex = 0;
            this.pBall.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(440, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(388, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Program.cs Application.Run(new Form5()); yapılmalıdır";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(643, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 94);
            this.label2.TabIndex = 25;
            this.label2.Text = "Bu örnekte mouse imlecinin konumuna göre topun hareket ettirilmesi sağlanmıştır.";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 471);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pBall);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form5_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pBall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBall;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}