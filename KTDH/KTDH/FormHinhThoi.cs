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
            hinhthoi.setTam(Tam);
            int Cheoa = Int32.Parse(this.a_TextBox.Text);
            int Cheob = Int32.Parse(this.b_TextBox.Text);
            Point a1, a2, b1, b2;
            a1 = new Point(Tam.getX(), Tam.getY() + Cheoa / 2);
            a2 = new Point(Tam.getX(), Tam.getY() - Cheoa / 2);
            b1 = new Point(Tam.getX() - Cheob / 2, Tam.getY());
            b2 = new Point(Tam.getX() + Cheob / 2, Tam.getY());
            Line DCA = new Line(a1.getX(), a1.getY(), a2.getX(), a2.getY(), Color.Black);
            Line DCB = new Line(b1.getX(), b1.getY(), b2.getX(), b2.getY(), Color.Black);
            hinhthoi.setCheo(DCA, DCB);
            hinhthoi.Draw(g);
        }
    }
}
