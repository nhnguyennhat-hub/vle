using System.Drawing;
using System.Windows.Forms;

namespace PaintApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private Button btnXoa;
        private PictureBox pictureBox1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnXoa = new Button();
            this.pictureBox1 = new PictureBox();

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();

            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = Color.White;
            this.pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            this.pictureBox1.Location = new Point(20, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(700, 400);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;

            // 
            // btnXoa
            // 
            this.btnXoa.Location = new Point(20, 440);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new Size(100, 35);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(750, 500);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Paint đơn giản";

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }
    }
}