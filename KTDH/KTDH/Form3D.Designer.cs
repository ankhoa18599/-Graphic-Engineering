﻿namespace KTDH
{
    partial class Form3D
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
            this.jbtHopVuong = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.jbtnXoa = new System.Windows.Forms.Button();
            this.jbtCau = new System.Windows.Forms.Button();
            this.jbtHopCN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.jbtTru = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // jbtHopVuong
            // 
            this.jbtHopVuong.BackColor = System.Drawing.Color.White;
            this.jbtHopVuong.Location = new System.Drawing.Point(42, 143);
            this.jbtHopVuong.Margin = new System.Windows.Forms.Padding(2);
            this.jbtHopVuong.Name = "jbtHopVuong";
            this.jbtHopVuong.Size = new System.Drawing.Size(119, 50);
            this.jbtHopVuong.TabIndex = 15;
            this.jbtHopVuong.Text = "Hình Hộp Vuông";
            this.jbtHopVuong.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "z";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(619, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "x";
            // 
            // jbtnXoa
            // 
            this.jbtnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.jbtnXoa.Location = new System.Drawing.Point(347, 432);
            this.jbtnXoa.Name = "jbtnXoa";
            this.jbtnXoa.Size = new System.Drawing.Size(119, 50);
            this.jbtnXoa.TabIndex = 11;
            this.jbtnXoa.Text = "Xóa";
            this.jbtnXoa.UseVisualStyleBackColor = false;
            // 
            // jbtCau
            // 
            this.jbtCau.BackColor = System.Drawing.Color.White;
            this.jbtCau.Location = new System.Drawing.Point(42, 248);
            this.jbtCau.Name = "jbtCau";
            this.jbtCau.Size = new System.Drawing.Size(119, 50);
            this.jbtCau.TabIndex = 10;
            this.jbtCau.Text = "Hình Cầu";
            this.jbtCau.UseVisualStyleBackColor = false;
            this.jbtCau.Click += new System.EventHandler(this.jbtCau_Click);
            // 
            // jbtHopCN
            // 
            this.jbtHopCN.BackColor = System.Drawing.Color.White;
            this.jbtHopCN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.jbtHopCN.Location = new System.Drawing.Point(42, 38);
            this.jbtHopCN.Name = "jbtHopCN";
            this.jbtHopCN.Size = new System.Drawing.Size(119, 50);
            this.jbtHopCN.TabIndex = 9;
            this.jbtHopCN.Text = "Hình Hộp Chữ Nhật";
            this.jbtHopCN.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(208, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 401);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // jbtTru
            // 
            this.jbtTru.BackColor = System.Drawing.Color.White;
            this.jbtTru.Location = new System.Drawing.Point(42, 353);
            this.jbtTru.Name = "jbtTru";
            this.jbtTru.Size = new System.Drawing.Size(119, 50);
            this.jbtTru.TabIndex = 10;
            this.jbtTru.Text = "Hình Trụ";
            this.jbtTru.UseVisualStyleBackColor = false;
            // 
            // Form3D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 497);
            this.Controls.Add(this.jbtHopVuong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jbtnXoa);
            this.Controls.Add(this.jbtTru);
            this.Controls.Add(this.jbtCau);
            this.Controls.Add(this.jbtHopCN);
            this.Controls.Add(this.panel1);
            this.Name = "Form3D";
            this.Text = "Form3D";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button jbtHopVuong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button jbtnXoa;
        private System.Windows.Forms.Button jbtCau;
        private System.Windows.Forms.Button jbtHopCN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button jbtTru;
    }
}