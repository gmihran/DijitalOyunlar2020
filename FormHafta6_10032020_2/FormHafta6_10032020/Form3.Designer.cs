namespace FormHafta6_10032020
{
    partial class Form3
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
            this.LabelKonum = new System.Windows.Forms.Label();
            this.pBall = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBall)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelKonum
            // 
            this.LabelKonum.AutoSize = true;
            this.LabelKonum.Location = new System.Drawing.Point(455, 42);
            this.LabelKonum.Name = "LabelKonum";
            this.LabelKonum.Size = new System.Drawing.Size(40, 13);
            this.LabelKonum.TabIndex = 15;
            this.LabelKonum.Text = "Konum";
            // 
            // pBall
            // 
            this.pBall.Image = global::FormHafta6_10032020.Properties.Resources.ball1;
            this.pBall.Location = new System.Drawing.Point(126, 80);
            this.pBall.Name = "pBall";
            this.pBall.Size = new System.Drawing.Size(89, 83);
            this.pBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBall.TabIndex = 14;
            this.pBall.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(379, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Program.cs Application.Run(new Form3()); yapılmalıdır";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(615, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 94);
            this.label2.TabIndex = 24;
            this.label2.Text = "Bu örnekte klavyedeki ok tuşları ile topun hareket ettirilmesi sağlanmıştır.";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 485);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelKonum);
            this.Controls.Add(this.pBall);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form3_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pBall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBall;
        private System.Windows.Forms.Label LabelKonum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}