namespace KTDH
{
    partial class FormHinhCau
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
            this.Tamday_Label = new System.Windows.Forms.Label();
            this.BanKinh_Label = new System.Windows.Forms.Label();
            this.X_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Y_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Z_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BanKinh_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Ve_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.X_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Z_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BanKinh_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Tamday_Label
            // 
            this.Tamday_Label.AutoSize = true;
            this.Tamday_Label.Location = new System.Drawing.Point(28, 38);
            this.Tamday_Label.Name = "Tamday_Label";
            this.Tamday_Label.Size = new System.Drawing.Size(49, 13);
            this.Tamday_Label.TabIndex = 0;
            this.Tamday_Label.Text = "Tâm đáy";
            // 
            // BanKinh_Label
            // 
            this.BanKinh_Label.AutoSize = true;
            this.BanKinh_Label.Location = new System.Drawing.Point(28, 111);
            this.BanKinh_Label.Name = "BanKinh_Label";
            this.BanKinh_Label.Size = new System.Drawing.Size(52, 13);
            this.BanKinh_Label.TabIndex = 1;
            this.BanKinh_Label.Text = "Bán Kính";
            // 
            // X_numericUpDown
            // 
            this.X_numericUpDown.Location = new System.Drawing.Point(119, 12);
            this.X_numericUpDown.Name = "X_numericUpDown";
            this.X_numericUpDown.Size = new System.Drawing.Size(55, 20);
            this.X_numericUpDown.TabIndex = 2;
            // 
            // Y_numericUpDown
            // 
            this.Y_numericUpDown.Location = new System.Drawing.Point(119, 38);
            this.Y_numericUpDown.Name = "Y_numericUpDown";
            this.Y_numericUpDown.Size = new System.Drawing.Size(55, 20);
            this.Y_numericUpDown.TabIndex = 3;
            // 
            // Z_numericUpDown
            // 
            this.Z_numericUpDown.Location = new System.Drawing.Point(119, 64);
            this.Z_numericUpDown.Name = "Z_numericUpDown";
            this.Z_numericUpDown.Size = new System.Drawing.Size(55, 20);
            this.Z_numericUpDown.TabIndex = 4;
            // 
            // BanKinh_numericUpDown
            // 
            this.BanKinh_numericUpDown.Location = new System.Drawing.Point(119, 109);
            this.BanKinh_numericUpDown.Name = "BanKinh_numericUpDown";
            this.BanKinh_numericUpDown.Size = new System.Drawing.Size(55, 20);
            this.BanKinh_numericUpDown.TabIndex = 5;
            // 
            // Ve_Button
            // 
            this.Ve_Button.Location = new System.Drawing.Point(65, 147);
            this.Ve_Button.Name = "Ve_Button";
            this.Ve_Button.Size = new System.Drawing.Size(75, 23);
            this.Ve_Button.TabIndex = 6;
            this.Ve_Button.Text = "Vẽ";
            this.Ve_Button.UseVisualStyleBackColor = true;
            this.Ve_Button.Click += new System.EventHandler(this.Ve_Button_Click);
            // 
            // FormHinhCau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 192);
            this.Controls.Add(this.Ve_Button);
            this.Controls.Add(this.BanKinh_numericUpDown);
            this.Controls.Add(this.Z_numericUpDown);
            this.Controls.Add(this.Y_numericUpDown);
            this.Controls.Add(this.X_numericUpDown);
            this.Controls.Add(this.BanKinh_Label);
            this.Controls.Add(this.Tamday_Label);
            this.Name = "FormHinhCau";
            this.Text = "FormHinhCau";
            ((System.ComponentModel.ISupportInitialize)(this.X_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Z_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BanKinh_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Tamday_Label;
        private System.Windows.Forms.Label BanKinh_Label;
        private System.Windows.Forms.NumericUpDown X_numericUpDown;
        private System.Windows.Forms.NumericUpDown Y_numericUpDown;
        private System.Windows.Forms.NumericUpDown Z_numericUpDown;
        private System.Windows.Forms.NumericUpDown BanKinh_numericUpDown;
        private System.Windows.Forms.Button Ve_Button;
    }
}