﻿
namespace Fuction4
{
    partial class Truong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TenTruong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(14, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            // 
            // TenTruong
            // 
            this.TenTruong.AutoEllipsis = true;
            this.TenTruong.Font = new System.Drawing.Font("Roboto Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenTruong.ForeColor = System.Drawing.Color.Black;
            this.TenTruong.Location = new System.Drawing.Point(23, 149);
            this.TenTruong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TenTruong.Name = "TenTruong";
            this.TenTruong.Size = new System.Drawing.Size(167, 57);
            this.TenTruong.TabIndex = 1;
            this.TenTruong.Text = "Đại học Công nghệ thông tin";
            this.TenTruong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TenTruong.UseCompatibleTextRendering = true;
            this.TenTruong.Click += new System.EventHandler(this.TenTruong_Click);
            this.TenTruong.MouseEnter += new System.EventHandler(this.TenTruong_MouseEnter);
            // 
            // Truong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.TenTruong);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Truong";
            this.Size = new System.Drawing.Size(213, 221);
            this.Load += new System.EventHandler(this.Truong_Load);
            this.Click += new System.EventHandler(this.Truong_Click);
            this.MouseEnter += new System.EventHandler(this.Truong_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Truong_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label TenTruong;
    }
}
