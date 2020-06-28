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
    public partial class Form3D : Form
    {
        public static int hinh = -1;
        HinhHopChuNhat hhcn;
        public Form3D()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            heToaDo();
        }
        void heToaDo()
        {
            Graphics g = this.panel1.CreateGraphics();
            int temp2 = 0;
            for (int i = 40; i <= 140; i++)
            {
                g.DrawLine(new Pen(Color.White), 5 * i, 0, 5 * i, 200);
                g.DrawLine(new Pen(Color.White), 200, temp2, 0, i * 5);
                g.DrawLine(new Pen(Color.White), 5 * i, 200, 0+temp2, 400);
                g.DrawLine(new Pen(Color.White), (i-40)*5,400-temp2, 400, 400 - temp2);
                temp2 += 5;
            }
            int temp = 10;
            for (int i = 0; i <= 40; i++)
            {
                g.DrawLine(new Pen(Color.White), 200, 5 * i, 400, 5 * i);
                g.DrawLine(new Pen(Color.White), i*5,0, 5*i, 400 - i*5);
                if (i > 20)
                {
                    g.DrawLine(new Pen(Color.White), 200, temp , 0, i * 10);
                    g.DrawLine(new Pen(Color.White), i * 5, 0, 0, i * 5);
                    temp += 10;
                }
                else
                {
                    g.DrawLine(new Pen(Color.White), i * 10, 0, 0, i * 10);
                    g.DrawLine(new Pen(Color.White), i * 5, 0, 0, i * 5);
                }
                
            }
            for (int i = 0; i < 40; i++)
            {
               
            }

            //ba đường đỏ
            g.DrawLine(new Pen(Color.Red), 200, 200, 400, 200);
            g.DrawLine(new Pen(Color.Red), 200, 0, 200, 200);
            g.DrawLine(new Pen(Color.Red), 200, 200, 0, 400);
        }

        void labelChange()
        {
            if (Form3D.hinh == -1)
            {
                label4.Text = "";
                label6.Text = "";
                label7.Text = "";
                label8.Text = "";
                label9.Text = "";
                label10.Text = "";
                label11.Text = "";
                label12.Text = "";
                label13.Text = "";
                label14.Text = "";
                label15.Text = "";
                label16.Text = "";
                label17.Text = "";
                label18.Text = "";
                label19.Text = "";
                label20.Text = "";
                label21.Text = "";
                label22.Text = "";
                label23.Text = "";
                label24.Text = "";
                label25.Text = "";
                label26.Text = "";
                label27.Text = "";
                label28.Text = "";
                label29.Text = "";
                label30.Text = "";
                label31.Text = "";
                label32.Text = "";
                label33.Text = "";
                label34.Text = "";
                label35.Text = "";
                label36.Text = "";
                label37.Text = "";
                label38.Text = "";
                label39.Text = "";
                label40.Text = "";
            }
            else if (Form3D.hinh == 1)
            {
                label38.Text = "Hình Hộp Chữ Nhật";
                label40.Text = "xA: ";
                label7.Text = ((hhcn.AB.getFpoint().getX()-200)/5).ToString();
                label8.Text = "xB: ";
                label9.Text = ((hhcn.AB.getLpoint().getX() - 200) / 5).ToString();
                label10.Text = "xC: ";
                label11.Text = ((hhcn.CD.getFpoint().getX() - 200) / 5).ToString();
                label12.Text = "yA: ";
                label13.Text = (-(hhcn.AB.getFpoint().getY() - 200) / 5).ToString();
                label14.Text = "yB: ";
                label15.Text = (-(hhcn.AB.getLpoint().getY() - 200) / 5).ToString();
                label16.Text = "yC: ";
                label17.Text = (-(hhcn.CD.getFpoint().getY() - 200) / 5).ToString();
                label18.Text = "xD: ";
                label19.Text = ((hhcn.CD.getLpoint().getX() - 200) / 5).ToString();
                label20.Text = "xE: ";
                label21.Text = ((hhcn.AE.getLpoint().getX() - 200) / 5).ToString();
                label22.Text = "xF; ";
                label23.Text = ((hhcn.EF.getLpoint().getX() - 200) / 5).ToString();
                label24.Text = "yD: ";
                label25.Text = (-(hhcn.CD.getLpoint().getY() - 200) / 5).ToString();
                label26.Text = "yE: ";
                label27.Text = (-(hhcn.AE.getLpoint().getY() - 200) / 5).ToString();
                label28.Text = "yF: ";
                label29.Text = (-(hhcn.EF.getLpoint().getY() - 200) / 5).ToString();
                label30.Text = "xG";
                label31.Text = ((hhcn.GH.getFpoint().getX() - 200) / 5).ToString();
                label32.Text = "xH: ";
                label33.Text = ((hhcn.GH.getLpoint().getX() - 200) / 5).ToString();
                label34.Text = "yG: ";
                label35.Text = (-(hhcn.GH.getFpoint().getY() - 200) / 5).ToString();
                label36.Text = "yH: ";
                label37.Text = (-(hhcn.GH.getLpoint().getY() - 200) / 5).ToString();
            }
        }

        private void jbtHopCN_Click(object sender, EventArgs e)
        {
            //Nam code
            
            Color c = Color.Black;
            hhcn = new HinhHopChuNhat();
            hhcn.ShowDialog();
            if (hhcn.check == false) return;
            else
            {
                Form3D.hinh = 1;
                //Đáy dưới
                hhcn.AB.DDA_Line(this.panel1.CreateGraphics(),c);
                hhcn.BC.Ve_Net_Dut(this.panel1.CreateGraphics());
                hhcn.CD.Ve_Net_Dut(this.panel1.CreateGraphics());
                hhcn.DA.DDA_Line(this.panel1.CreateGraphics(),c);
                //Đáy trên
                hhcn.EF.DDA_Line(this.panel1.CreateGraphics(),c);
                hhcn.FG.DDA_Line(this.panel1.CreateGraphics(),c);
               hhcn.GH.DDA_Line(this.panel1.CreateGraphics(),c);
               hhcn.HE.DDA_Line(this.panel1.CreateGraphics(),c);
                //cac duong cao
                hhcn.AE.DDA_Line(this.panel1.CreateGraphics(),c);
                hhcn.BF.DDA_Line(this.panel1.CreateGraphics(),c);
                hhcn.CG.Ve_Net_Dut(this.panel1.CreateGraphics());
                hhcn.DH.DDA_Line(this.panel1.CreateGraphics(),c);
            }
            labelChange();
           
        }

        private void jbtnXoa_Click(object sender, EventArgs e)
        {
            this.Refresh();
            Form3D.hinh = -1;
            labelChange();
        }
        private void jbtCau_Click(object sender, EventArgs e)
        {
            FormHinhCau formhc = new FormHinhCau();
            formhc.Setluoigiaodien(this.panel1.CreateGraphics());
            formhc.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }
    }
}
