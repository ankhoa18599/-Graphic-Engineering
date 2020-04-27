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
    public partial class Form1 : Form
    {
        public static int hinh = -1; // Xác định in hình nào để in thông số tọa độ hình đó ra 
        Line AB, BC, CD, DA;
        HinhChuNhat hcn;
        HinhElip elips;
        HinhTron hinhtron;
        private int luachonNet = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void JpnLuoiGiaoDien_Paint(object sender, PaintEventArgs e)
        {
            heToaDo();
        }
        void heToaDo()
        {
            Graphics g = this.JpnLuoiGiaoDien.CreateGraphics();
            for (int i = 0; i <= 80; i++)
            {
                g.DrawLine(new Pen(Color.White), 5 * i, 0, 5 * i, 400);
                g.DrawLine(new Pen(Color.White), 0, 5 * i, 400, 5 * i);
            }

            g.DrawLine(new Pen(Color.Black), 0, 200, 400, 200);
            g.DrawLine(new Pen(Color.Black), 200, 0, 200, 400);
        }

        void labelChange()
        {
            if (Form1.hinh == -1)
            {
                label5.Text = "";
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
            }
            else if(Form1.hinh == 1)
            {
                label5.Text = "Đường Thẳng";
                label6.Text = "xA:";
                label7.Text = "yA:";
                label8.Text = ((AB.getFpoint().getX() - 200) / 5).ToString();
                label9.Text = (-(AB.getFpoint().getY() - 200) / 5).ToString();
                label10.Text = "xB:";
                label11.Text = "yB:";
                label12.Text = ((AB.getLpoint().getX() - 200) / 5).ToString();
                label13.Text = (-(AB.getLpoint().getY() - 200) / 5).ToString();
                label14.Text = "";
                label15.Text = "";
                label16.Text = "";
                label17.Text = "";
                label18.Text = "";
                label19.Text = "";
                label20.Text = "";
                label21.Text = "";
            }
            else if (Form1.hinh == 2)
            {
                label5.Text = "Hình chữ nhật";
                label6.Text = "xA:";
                label7.Text = "yA:";
                label8.Text = ((hcn.AB.getFpoint().getX() - 200) / 5).ToString();
                label9.Text = (-(hcn.AB.getFpoint().getY() - 200) / 5).ToString();
                label10.Text = "xB:";
                label11.Text = "yB:";
                label12.Text = ((hcn.AB.getLpoint().getX() - 200) / 5).ToString();
                label13.Text = (-(hcn.AB.getLpoint().getY() - 200) / 5).ToString();
                label14.Text = "xC";
                label15.Text = "yC";
                label16.Text = ((hcn.BC.getLpoint().getX() - 200) / 5).ToString();
                label17.Text = (-(hcn.BC.getLpoint().getY() - 200) / 5).ToString();
                label18.Text = "xD";
                label19.Text = "yD";
                label20.Text = ((hcn.CD.getLpoint().getX() - 200) / 5).ToString();
                label21.Text = ((hcn.BC.getLpoint().getY() - 200) / 5).ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1.hinh = 1;
            DuongThang dt = new DuongThang();
            dt.ShowDialog();
            int xa, xb, ya, yb;
            xa = dt.xA;
            ya = dt.yA;
            xb = dt.xB;
            yb = dt.yB;
            Point p1 = Point.FakeToReal(xa, ya); // gan toa do tren Oxy 
            Point p2 = Point.FakeToReal(xb, yb);
            AB = new Line(p1.getX(), p1.getY(), p2.getX(), p2.getY(), Color.Red); //tao AB
            if (luachonNet == 0) // ve dut khuc
            {
                AB.DDA_Line_ngat(this.JpnLuoiGiaoDien.CreateGraphics()); // ve dt AB bang DDA 
            } else if (luachonNet == 1) // ve dut khuc
            {
                AB.DDA_Line_ngat_1cham(this.JpnLuoiGiaoDien.CreateGraphics()); // ve dt AB bang DDA 
            }
            else if (luachonNet == 2) // ve dut khuc
            {
                AB.DDA_Line_ngat_2cham(this.JpnLuoiGiaoDien.CreateGraphics()); // ve dt AB bang DDA 
            }else if (luachonNet == 3)
            {
                Test(AB);
            }
            else
            {
                AB.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics()); // ve dt AB bang DDA 
            }
            labelChange(); // reset bang 
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            luachonNet = 0;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            luachonNet = 1;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            luachonNet = 2;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            luachonNet = 3;
        }

        
        private void jbtnXoa_Click(object sender, EventArgs e)
        {
            Form1.hinh = -1;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            luachonNet = -1;
            labelChange();
            this.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.hinh = 4;
            hinhtron = new HinhTron();
            hinhtron.ShowDialog();
            if (hinhtron.checkchange == false) return;
            hinhtron.ht.Midpoint_htron(this.JpnLuoiGiaoDien.CreateGraphics());
            labelChange();
        }

        //ở đây khoa sẽ code một cái dòng lol gì đó để test xem nếu commit có bị đè code không
        private void JbntHInhChuNhat_Click(object sender, EventArgs e)
        {
            Form1.hinh = 2;
            hcn = new HinhChuNhat();
            hcn.ShowDialog();
            if (hcn.checkchange == false) return;
            hcn.AB.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
            hcn.CD.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
            hcn.BC.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
            hcn.AD.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
            labelChange();
            //test 1:
        }
        private void jbtnHinhElip_Click(object sender, EventArgs e)
        {
            Form1.hinh = 3;
            elips = new HinhElip();
            elips.ShowDialog();
            if (elips.checkchange == false) return;
            elips.hinhelip.MidPoint_Elip(this.JpnLuoiGiaoDien.CreateGraphics());
            labelChange();
        }
//Lại một dòng code lol test code
        private void Test(Line AB)
        {
            //Khoảng cách DX,DY
            double ABDx = Math.Abs(AB.getLpoint().getX() - AB.getFpoint().getX());
            double ABDy = Math.Abs(AB.getLpoint().getY() - AB.getFpoint().getY());
            //Độ dài AB
            double DAB = Math.Sqrt(Math.Pow(ABDx, 2) + Math.Pow(ABDy, 2));

            //chiều cao và cạnh đáy,góc tam giác mũi tên
            double HArrTri = 40;  //DAB / 5;
            double DayArrTri = 20;  //1.6;
            double CanhBArrTri = Math.Sqrt(Math.Pow(HArrTri, 2) + Math.Pow(DayArrTri / 2, 2));
            double G_Anpha = Math.Atan(DayArrTri / 2 / HArrTri) * 2 * 180 / Math.PI;
            // Tính chất tam giác cân;
            double G_Anpha1, G_Anpha2;
            G_Anpha1 = G_Anpha2 = G_Anpha / 2;

            //Góc B1 &B2
            double G_B1 = Math.Atan(ABDy / ABDx) * 180 / Math.PI;
            double G_B2 = Math.Atan(ABDx / ABDy) * 180 / Math.PI;

            //Góc Beta
            double G_Beta1, G_Beta2;
            G_Beta1 = Math.Abs(G_B1 - G_Anpha1);
            G_Beta2 = Math.Abs(G_B2 - G_Anpha2);

            //Khoảng cách dy dx
            double Dx1, Dy1, Dx2, Dy2;
            Dy1 = Math.Sin(G_Beta1 * Math.PI / 180) * CanhBArrTri;
            Dx1 = Math.Sqrt(Math.Pow(CanhBArrTri, 2) - Math.Pow(Dy1, 2));
            Dx2 = Math.Sin(G_Beta2 * Math.PI / 180) * CanhBArrTri;
            Dy2 = Math.Sqrt(Math.Pow(CanhBArrTri, 2) - Math.Pow(Dx2, 2));


            Point MT1 = new Point();
            Point MT2 = new Point();
            if (AB.getLpoint().getX() > AB.getFpoint().getX())
            {
                Dx1 = -Dx1;
                Dy1 = -Dy1;
                Dx2 = -Dx2;
                Dy2 = -Dy2;
            }
            double x1, x2, y1, y2;
            x1 = Math.Round(AB.getLpoint().getX() + Dx1);
            y1 = Math.Round(AB.getLpoint().getY() + Dy1);
            x2 = Math.Round(AB.getLpoint().getX() + Dx2);
            y2 = Math.Round(AB.getLpoint().getY() + Dy2);

            MT1.setPoint((int)x1, (int)y1);
            MT2.setPoint((int)x2, (int)y2);

            Line Arrow1 = new Line(AB.getLpoint().getX(), AB.getLpoint().getY(), MT1.getX(), MT1.getY(), Color.HotPink);
            Line Arrow2 = new Line(AB.getLpoint().getX(), AB.getLpoint().getY(), MT2.getX(), MT2.getY(), Color.HotPink);

            Arrow1.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
            Arrow2.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
        }
    }
}
//test commit code
//test commit code
//test commit code
//test commit code
//test commit code
//test commit code
//test commit code

//Và ở đây cũng thế. Sẽ có một dòng code lol
//test commit code2
//test commit code2
//test commit code2
//test commit code2
//test commit code2
//test commit code2
//test commit code2
//test commit code2