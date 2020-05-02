namespace KTDH
{
    partial class HinhTamGiac
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
            this.jbntVeHTG = new System.Windows.Forms.Button();
            this.RongDay = new System.Windows.Forms.NumericUpDown();
            this.ChieuCao = new System.Windows.Forms.NumericUpDown();
            this.ToadoYa = new System.Windows.Forms.NumericUpDown();
            this.ToadoXa = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RongDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChieuCao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToadoYa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToadoXa)).BeginInit();
            this.SuspendLayout();
            // 
            // jbntVeHTG
            // 
            this.jbntVeHTG.Location = new System.Drawing.Point(171, 145);
            this.jbntVeHTG.Name = "jbntVeHTG";
            this.jbntVeHTG.Size = new System.Drawing.Size(75, 23);
            this.jbntVeHTG.TabIndex = 41;
            this.jbntVeHTG.Text = "Vẽ";
            this.jbntVeHTG.UseVisualStyleBackColor = true;
            this.jbntVeHTG.Click += new System.EventHandler(this.jbntVeHTG_Click);
            // 
            // RongDay
            // 
            this.RongDay.Location = new System.Drawing.Point(287, 91);
            this.RongDay.Maximum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.RongDay.Name = "RongDay";
            this.RongDay.Size = new System.Drawing.Size(50, 20);
            this.RongDay.TabIndex = 40;
            this.RongDay.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // ChieuCao
            // 
            this.ChieuCao.Location = new System.Drawing.Point(287, 65);
            this.ChieuCao.Maximum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.ChieuCao.Name = "ChieuCao";
            this.ChieuCao.Size = new System.Drawing.Size(50, 20);
            this.ChieuCao.TabIndex = 39;
            this.ChieuCao.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // ToadoYa
            // 
            this.ToadoYa.Location = new System.Drawing.Point(89, 91);
            this.ToadoYa.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.ToadoYa.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            -2147483648});
            this.ToadoYa.Name = "ToadoYa";
            this.ToadoYa.Size = new System.Drawing.Size(50, 20);
            this.ToadoYa.TabIndex = 38;
            // 
            // ToadoXa
            // 
            this.ToadoXa.Location = new System.Drawing.Point(89, 65);
            this.ToadoXa.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.ToadoXa.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            -2147483648});
            this.ToadoXa.Name = "ToadoXa";
            this.ToadoXa.Size = new System.Drawing.Size(50, 20);
            this.ToadoXa.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Chiều rộng cạnh đáy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Chiều cao";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "yB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "xA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(262, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Thông số hình";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Tọa độ điểm A";
            // 
            // HinhTamGiac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 191);
            this.Controls.Add(this.jbntVeHTG);
            this.Controls.Add(this.RongDay);
            this.Controls.Add(this.ChieuCao);
            this.Controls.Add(this.ToadoYa);
            this.Controls.Add(this.ToadoXa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "HinhTamGiac";
            this.Text = "Hinh Tam Giac";
            ((System.ComponentModel.ISupportInitialize)(this.RongDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChieuCao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToadoYa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToadoXa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button jbntVeHTG;
        private System.Windows.Forms.NumericUpDown RongDay;
        private System.Windows.Forms.NumericUpDown ChieuCao;
        private System.Windows.Forms.NumericUpDown ToadoYa;
        private System.Windows.Forms.NumericUpDown ToadoXa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
    }
}