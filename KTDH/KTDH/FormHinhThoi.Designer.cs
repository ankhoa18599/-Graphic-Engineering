namespace KTDH
{
    partial class FormHinhThoi
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
            this.Tam_Label = new System.Windows.Forms.Label();
            this.a_Label = new System.Windows.Forms.Label();
            this.b_Label = new System.Windows.Forms.Label();
            this.Draw_Button = new System.Windows.Forms.Button();
            this.TamX_TextBox = new System.Windows.Forms.TextBox();
            this.a_TextBox = new System.Windows.Forms.TextBox();
            this.b_TextBox = new System.Windows.Forms.TextBox();
            this.Alert_Label = new System.Windows.Forms.Label();
            this.TamY_TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Tam_Label
            // 
            this.Tam_Label.AutoSize = true;
            this.Tam_Label.Location = new System.Drawing.Point(18, 49);
            this.Tam_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Tam_Label.Name = "Tam_Label";
            this.Tam_Label.Size = new System.Drawing.Size(97, 20);
            this.Tam_Label.TabIndex = 0;
            this.Tam_Label.Text = "Tọa độ tâm: ";
            // 
            // a_Label
            // 
            this.a_Label.AutoSize = true;
            this.a_Label.Location = new System.Drawing.Point(18, 97);
            this.a_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.a_Label.Name = "a_Label";
            this.a_Label.Size = new System.Drawing.Size(204, 20);
            this.a_Label.TabIndex = 1;
            this.a_Label.Text = "Độ dài đường chéo a( dọc): ";
            // 
            // b_Label
            // 
            this.b_Label.AutoSize = true;
            this.b_Label.Location = new System.Drawing.Point(18, 146);
            this.b_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.b_Label.Name = "b_Label";
            this.b_Label.Size = new System.Drawing.Size(223, 20);
            this.b_Label.TabIndex = 2;
            this.b_Label.Text = "Độ dài đường chéo b( ngang): ";
            // 
            // Draw_Button
            // 
            this.Draw_Button.Location = new System.Drawing.Point(102, 208);
            this.Draw_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Draw_Button.Name = "Draw_Button";
            this.Draw_Button.Size = new System.Drawing.Size(159, 63);
            this.Draw_Button.TabIndex = 3;
            this.Draw_Button.Text = "Vẽ";
            this.Draw_Button.UseVisualStyleBackColor = true;
            this.Draw_Button.Click += new System.EventHandler(this.Draw_Button_Click);
            // 
            // TamX_TextBox
            // 
            this.TamX_TextBox.Location = new System.Drawing.Point(253, 43);
            this.TamX_TextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TamX_TextBox.Name = "TamX_TextBox";
            this.TamX_TextBox.Size = new System.Drawing.Size(33, 26);
            this.TamX_TextBox.TabIndex = 4;
            // 
            // a_TextBox
            // 
            this.a_TextBox.Location = new System.Drawing.Point(262, 92);
            this.a_TextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.a_TextBox.Name = "a_TextBox";
            this.a_TextBox.Size = new System.Drawing.Size(54, 26);
            this.a_TextBox.TabIndex = 5;
            // 
            // b_TextBox
            // 
            this.b_TextBox.Location = new System.Drawing.Point(262, 142);
            this.b_TextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.b_TextBox.Name = "b_TextBox";
            this.b_TextBox.Size = new System.Drawing.Size(54, 26);
            this.b_TextBox.TabIndex = 6;
            // 
            // Alert_Label
            // 
            this.Alert_Label.AutoSize = true;
            this.Alert_Label.ForeColor = System.Drawing.Color.Red;
            this.Alert_Label.Location = new System.Drawing.Point(18, 180);
            this.Alert_Label.Name = "Alert_Label";
            this.Alert_Label.Size = new System.Drawing.Size(0, 20);
            this.Alert_Label.TabIndex = 7;
            // 
            // TamY_TextBox
            // 
            this.TamY_TextBox.Location = new System.Drawing.Point(294, 43);
            this.TamY_TextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TamY_TextBox.Name = "TamY_TextBox";
            this.TamY_TextBox.Size = new System.Drawing.Size(34, 26);
            this.TamY_TextBox.TabIndex = 8;
            // 
            // FormHinhThoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 289);
            this.Controls.Add(this.TamY_TextBox);
            this.Controls.Add(this.Alert_Label);
            this.Controls.Add(this.b_TextBox);
            this.Controls.Add(this.a_TextBox);
            this.Controls.Add(this.TamX_TextBox);
            this.Controls.Add(this.Draw_Button);
            this.Controls.Add(this.b_Label);
            this.Controls.Add(this.a_Label);
            this.Controls.Add(this.Tam_Label);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormHinhThoi";
            this.Text = "FormHinhThoi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Tam_Label;
        private System.Windows.Forms.Label a_Label;
        private System.Windows.Forms.Label b_Label;
        private System.Windows.Forms.Button Draw_Button;
        private System.Windows.Forms.TextBox TamX_TextBox;
        private System.Windows.Forms.TextBox a_TextBox;
        private System.Windows.Forms.TextBox b_TextBox;
        private System.Windows.Forms.Label Alert_Label;
        private System.Windows.Forms.TextBox TamY_TextBox;
    }
}