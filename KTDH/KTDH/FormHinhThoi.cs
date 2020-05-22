using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KTDH
{
    public partial class FormHinhThoi : Form
    {
        private Boolean checkchange = false;
        private Graphics luoigiaodien;
        private TextBox TamX_TextBox;
        private TextBox TamY_TextBox;
        private TextBox a_TextBox;
        private TextBox b_TextBox;
        private Label Tam_Label;
        private Label CheoA_label;
        private Label label1;
        private Label Alert_Label;
        private Button Draw_Button;
        private HinhThoi hinhthoi;
        
        public FormHinhThoi()
        {
            InitializeComponent();
            checkchange = false;
        }
        public void setluoigiaodien(Graphics p)
        {
            this.luoigiaodien = p;
        }
        public Boolean getcheckchange()
        {
            return this.checkchange;
        }
        private Boolean IsEmpty()
        {
            if (this.TamX_TextBox.Text == "" || this.TamY_TextBox.Text == "" || this.a_TextBox.Text == "" || this.b_TextBox.Text == "")
            {
                this.Alert_Label.Text = "Không được bỏ trống";
                return true;
            }
            return false;
        }
        public Boolean Isvalid()
        {
            if (IsEmpty() == false)
            {
                if (Int32.Parse(this.a_TextBox.Text) <= 0 || Int32.Parse(this.b_TextBox.Text) <= 0)
                {
                    this.Alert_Label.Text = "Các thông số đường chéo phải là số dương";
                    return false;
                }
                if (Int32.Parse(this.TamX_TextBox.Text) >= 40 || Int32.Parse(this.TamX_TextBox.Text) <= -40 || Int32.Parse(this.TamY_TextBox.Text) >= 40 || Int32.Parse(this.TamY_TextBox.Text) <= -40)
                {
                    this.Alert_Label.Text = "Tâm không được vượt qua khỏi map";
                    return false;
                }
                return true;
            }return false;
        }
        private void Draw_Button_Click(object sender, EventArgs e)
        {
            checkchange = true;
            this.Alert_Label.Text = "";
            if (Isvalid() == true)
            {
                DrawHinhThoi(this.luoigiaodien);
                this.Close();
            }
        }
        public void DrawHinhThoi(Graphics g)
        {
            hinhthoi = new HinhThoi();
            Point Tam = new Point(Int32.Parse(this.TamX_TextBox.Text), Int32.Parse(this.TamY_TextBox.Text));
            int Cheoa = Int32.Parse(this.a_TextBox.Text);
            int Cheob = Int32.Parse(this.b_TextBox.Text);

            Point a1, a2, b1, b2;
            a1 = new Point(Tam.getX(), Tam.getY() + Cheoa / 2);
            a2 = new Point(Tam.getX(), Tam.getY() - Cheoa / 2);
            b1 = new Point(Tam.getX() - Cheob / 2, Tam.getY());
            b2 = new Point(Tam.getX() + Cheob / 2, Tam.getY());

            a1 = Point.FakeToReal(a1.getX(), a1.getY());
            a2 = Point.FakeToReal(a2.getX(), a2.getY());
            b1 = Point.FakeToReal(b1.getX(), b1.getY());
            b2 = Point.FakeToReal(b2.getX(), b2.getY());
            Tam = Point.FakeToReal(Tam.getX(), Tam.getY());
            hinhthoi.setTam(Tam);

            Line DCA = new Line(a1.getX(), a1.getY(), a2.getX(), a2.getY(), Color.Black);
            Line DCB = new Line(b1.getX(), b1.getY(), b2.getX(), b2.getY(), Color.Black);
            hinhthoi.setCheo(DCA, DCB);
            hinhthoi.Draw(g);
        }

        private void InitializeComponent()
        {
            this.TamX_TextBox = new System.Windows.Forms.TextBox();
            this.TamY_TextBox = new System.Windows.Forms.TextBox();
            this.a_TextBox = new System.Windows.Forms.TextBox();
            this.b_TextBox = new System.Windows.Forms.TextBox();
            this.Tam_Label = new System.Windows.Forms.Label();
            this.CheoA_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Alert_Label = new System.Windows.Forms.Label();
            this.Draw_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TamX_TextBox
            // 
            this.TamX_TextBox.Location = new System.Drawing.Point(181, 32);
            this.TamX_TextBox.Name = "TamX_TextBox";
            this.TamX_TextBox.Size = new System.Drawing.Size(26, 20);
            this.TamX_TextBox.TabIndex = 0;
            this.TamX_TextBox.Text = "0";
            this.TamX_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TamY_TextBox
            // 
            this.TamY_TextBox.Location = new System.Drawing.Point(213, 32);
            this.TamY_TextBox.Name = "TamY_TextBox";
            this.TamY_TextBox.Size = new System.Drawing.Size(26, 20);
            this.TamY_TextBox.TabIndex = 1;
            this.TamY_TextBox.Text = "0";
            this.TamY_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // a_TextBox
            // 
            this.a_TextBox.Location = new System.Drawing.Point(189, 58);
            this.a_TextBox.Name = "a_TextBox";
            this.a_TextBox.Size = new System.Drawing.Size(37, 20);
            this.a_TextBox.TabIndex = 2;
            this.a_TextBox.Text = "20";
            this.a_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // b_TextBox
            // 
            this.b_TextBox.Location = new System.Drawing.Point(189, 84);
            this.b_TextBox.Name = "b_TextBox";
            this.b_TextBox.Size = new System.Drawing.Size(37, 20);
            this.b_TextBox.TabIndex = 3;
            this.b_TextBox.Text = "20";
            this.b_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Tam_Label
            // 
            this.Tam_Label.AutoSize = true;
            this.Tam_Label.Location = new System.Drawing.Point(34, 32);
            this.Tam_Label.Name = "Tam_Label";
            this.Tam_Label.Size = new System.Drawing.Size(65, 13);
            this.Tam_Label.TabIndex = 4;
            this.Tam_Label.Text = "Tọa độ tâm:";
            // 
            // CheoA_label
            // 
            this.CheoA_label.AutoSize = true;
            this.CheoA_label.Location = new System.Drawing.Point(34, 61);
            this.CheoA_label.Name = "CheoA_label";
            this.CheoA_label.Size = new System.Drawing.Size(138, 13);
            this.CheoA_label.TabIndex = 5;
            this.CheoA_label.Text = "Độ dài đường chéo a (dọc):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Độ dài đường chéo b (ngang):";
            // 
            // Alert_Label
            // 
            this.Alert_Label.AutoSize = true;
            this.Alert_Label.Location = new System.Drawing.Point(34, 111);
            this.Alert_Label.Name = "Alert_Label";
            this.Alert_Label.Size = new System.Drawing.Size(0, 13);
            this.Alert_Label.TabIndex = 7;
            // 
            // Draw_Button
            // 
            this.Draw_Button.Location = new System.Drawing.Point(97, 127);
            this.Draw_Button.Name = "Draw_Button";
            this.Draw_Button.Size = new System.Drawing.Size(75, 30);
            this.Draw_Button.TabIndex = 8;
            this.Draw_Button.Text = "Vẽ";
            this.Draw_Button.UseVisualStyleBackColor = true;
            this.Draw_Button.Click += new System.EventHandler(this.Draw_Button_Click);
            // 
            // FormHinhThoi
            // 
            this.ClientSize = new System.Drawing.Size(260, 169);
            this.Controls.Add(this.Draw_Button);
            this.Controls.Add(this.Alert_Label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CheoA_label);
            this.Controls.Add(this.Tam_Label);
            this.Controls.Add(this.b_TextBox);
            this.Controls.Add(this.a_TextBox);
            this.Controls.Add(this.TamY_TextBox);
            this.Controls.Add(this.TamX_TextBox);
            this.Name = "FormHinhThoi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal HinhThoi GetHinhThoi()
        {
            return this.hinhthoi;
        }

    }
}
