﻿using System;
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
        Line AB,CD,BC,AD;
        HinhChuNhat hcn;
        HinhTamGiac htg;
        HinhTron hinhtron;
        HinhVuong hinhvuong;
        HinhElip elip;
        FormHinhThoi formHT;
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
            else if (Form1.hinh == 1)
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
                label21.Text = (-(hcn.BC.getLpoint().getY() - 200) / 5).ToString();
            }
            else if (Form1.hinh == 3)
            {
                label5.Text = "Hình tam giác";
                label6.Text = "xA:";
                label7.Text = "yA:";
                label8.Text = ((htg.AB.getFpoint().getX() - 200) / 5).ToString();
                label9.Text = (-(htg.AB.getFpoint().getY() - 200) / 5).ToString();
                label10.Text = "xB:";
                label11.Text = "yB:";
                label12.Text = ((htg.AB.getLpoint().getX() - 200) / 5).ToString();
                label13.Text = (-(htg.AB.getLpoint().getY() - 200) / 5).ToString();
                label14.Text = "xC";
                label15.Text = "yC";
                label16.Text = ((htg.BC.getLpoint().getX() - 200) / 5).ToString();
                label17.Text = (-(htg.BC.getLpoint().getY() - 200) / 5).ToString();
                label18.Text = "";
                label19.Text = "";
                label20.Text = "";
                label21.Text = "";
            }
            else if (Form1.hinh == 4)
            {
                label5.Text = "HÌNH TRÒN";
                label6.Text = "xTam:";
                label7.Text = "yTam:";
                label8.Text = ((hinhtron.ht.tam.getX() - 200) / 5).ToString();
                label9.Text = (-(hinhtron.ht.tam.getY() - 200) / 5).ToString();
                label10.Text = "Bán kính:";
                label11.Text = "";
                label12.Text = (hinhtron.ht.getR()/5).ToString();
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
            else if (Form1.hinh == 7)
            {
                label5.Text = "Hình Elip";
                label6.Text = "xTam: ";
                label7.Text = "yTam: ";
                label8.Text = ((elip.hinhelip.tam.getX() - 200) / 5).ToString();
                label9.Text = (-(elip.hinhelip.tam.getY() - 200) / 5).ToString();
            }
            else if (Form1.hinh == 6)
            {
                label5.Text = "Hình thoi";
                label6.Text = "xA1:";
                label7.Text = "yA1:";
                label8.Text = ((formHT.GetHinhThoi().getCheoA().getFpoint().getX() - 200) / 5).ToString();
                label9.Text = ((formHT.GetHinhThoi().getCheoA().getFpoint().getY() - 200) / 5).ToString();
                label10.Text = "xA2:";
                label11.Text = "yA2:";
                label12.Text = ((formHT.GetHinhThoi().getCheoA().getLpoint().getX() - 200) / 5).ToString();
                label13.Text = ((formHT.GetHinhThoi().getCheoA().getLpoint().getY() - 200) / 5).ToString();
                label14.Text = "xB1";
                label15.Text = "yB1";
                label16.Text = ((formHT.GetHinhThoi().getCheoB().getFpoint().getX() - 200) / 5).ToString();
                label17.Text = ((formHT.GetHinhThoi().getCheoB().getFpoint().getY() - 200) / 5).ToString();
                label18.Text = "xB2";
                label19.Text = "yB2";
                label20.Text = ((formHT.GetHinhThoi().getCheoB().getLpoint().getX() - 200) / 5).ToString();
                label21.Text = ((formHT.GetHinhThoi().getCheoB().getLpoint().getY() - 200) / 5).ToString();
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
            AB.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics()); // ve dt AB bang DDA 
            labelChange(); // reset bang 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void jbtnXoa_Click(object sender, EventArgs e)
        {
            Form1.hinh = -1;
            labelChange();
            this.Refresh();
        }

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

        private void jbtnHinhTamGiac_Click(object sender, EventArgs e)
        {
            Form1.hinh = 3;
            htg = new HinhTamGiac();
            htg.ShowDialog();
            if (htg.checkchange == false) return;
            htg.AB.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
            htg.AC.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
            htg.BC.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
            labelChange();
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

        private void jbtnHinhThoi_Click(object sender, EventArgs e)
        {
            Form1.hinh = 6;
            formHT = new FormHinhThoi();
            formHT.setluoigiaodien(this.JpnLuoiGiaoDien.CreateGraphics());
            formHT.ShowDialog();
            if (formHT.getcheckchange() == false) return;
            this.labelChange();
        }


        private void jbtnHinhVuong_Click(object sender, EventArgs e)
        {
            Form1.hinh = 5;
            hinhvuong = new HinhVuong();
            hinhvuong.ShowDialog();
            if (hinhvuong.checkchange == false) return;
            hinhvuong.AB.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
            hinhvuong.BC.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
            hinhvuong.CD.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
            hinhvuong.AD.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
            labelChange();
        }
        private void jbtnHinhElip_Click(object sender, EventArgs e)
        {
            Form1.hinh = 7;
            elip = new HinhElip();
            elip.ShowDialog();
            if (elip.checkchange == false) return;
            elip.hinhelip.VeElip2(this.JpnLuoiGiaoDien.CreateGraphics());
            labelChange();
            //Nam code
        }
        private void jbntQuay_Click(object sender, EventArgs e)
        {
            if (Form1.hinh == 1)
            {
                this.Refresh();
                AB.QuayDT();
                AB.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
                labelChange();
            }
            else if (Form1.hinh == 2)
            {
                this.Refresh();
                hcn.AB.QuayDT();
                hcn.BC.QuayDT();
                hcn.CD.QuayDT();
                hcn.AD.QuayDT();

                hcn.AB.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
                hcn.BC.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
                hcn.CD.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
                hcn.AD.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
                labelChange();
            }
            else if (Form1.hinh == 3)
            {
                this.Refresh();
                htg.AB.QuayDT();
                htg.AC.QuayDT();
                htg.BC.QuayDT();
                htg.AB.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
                htg.AC.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
                htg.BC.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
                labelChange();
            }
            else if (Form1.hinh == 4)
            {
                this.Refresh();
                hinhtron.ht.tam.QuayDiem();
                hinhtron.ht.Midpoint_htron(this.JpnLuoiGiaoDien.CreateGraphics());
                labelChange();
            }
            else if (Form1.hinh == 5)
            {
                this.Refresh();
                hinhvuong.AB.QuayDT();
                hinhvuong.BC.QuayDT();
                hinhvuong.CD.QuayDT();
                hinhvuong.AD.QuayDT();
                hinhvuong.AB.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
                hinhvuong.BC.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
                hinhvuong.CD.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
                hinhvuong.AD.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
                labelChange();
            }
            else if (Form1.hinh == 6)
            {
                this.Refresh();
                formHT.setluoigiaodien(this.JpnLuoiGiaoDien.CreateGraphics());
                formHT.GetHinhThoi().getTam().QuayDiem();
                formHT.GetHinhThoi().getCheoA().QuayDT();
                formHT.GetHinhThoi().getCheoB().QuayDT();
                formHT.GetHinhThoi().Draw(this.JpnLuoiGiaoDien.CreateGraphics());
                labelChange();
            }
            else if (Form1.hinh == 7)
            {
                this.Refresh();
                elip.hinhelip.tam.QuayDiem();
                elip.hinhelip.VeElip2(this.JpnLuoiGiaoDien.CreateGraphics());
                labelChange();
            }
        }

        private void jbtnTamO_Click(object sender, EventArgs e)
        {

        }

        //Nam code module tinh tien
        public Line TinhTienDT(Line AB)
        {
            int xA = AB.getFpoint().getX() + Int32.Parse(numericUpDown1.Value.ToString()) * 5;
            int yA = AB.getFpoint().getY() + Int32.Parse(numericUpDown2.Value.ToString()) * -5;
            int xB = AB.getLpoint().getX() + Int32.Parse(numericUpDown1.Value.ToString()) * 5;
            int yB = AB.getLpoint().getY() + Int32.Parse(numericUpDown2.Value.ToString()) * -5;

            Point A = new Point(xA, yA);
            Point B = new Point(xB, yB);

            Line dt = new Line(A.getX(), A.getY(), B.getX(), B.getY(), Color.Black);

            return dt;
        }

        public Point TinhTienDiem(Point A)
        {
            int xA = A.getX() + Int32.Parse(numericUpDown1.Value.ToString()) * 5;
            int yA = A.getY() + Int32.Parse(numericUpDown2.Value.ToString()) * -5;

            Point x = new Point(xA, yA);

            return x;
        }

        private void jbtnTinhTien_Click(object sender, EventArgs e)
        {
            int k1, k2;
            k1 = Int32.Parse(numericUpDown1.Value.ToString());
            k2 = Int32.Parse(numericUpDown2.Value.ToString());
            if (k1 == 0 && k2==0)
            {
                MessageBox.Show("Bạn chưa nhập thông tin tịnh tiến", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (Form1.hinh == 1)    //duong thang
                {
                    this.Refresh();

                    //AB = TinhTienDT(AB);
                    AB = AB.TinhTienDT(AB,k1, k2);

                    AB.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());

                    labelChange();

                }
                //hinh chu nhat
                else if (Form1.hinh == 2)
                {
                    this.Refresh();

                    hcn.AB = hcn.AB.TinhTienDT(hcn.AB,k1,k2);
                    hcn.BC = hcn.BC.TinhTienDT(hcn.BC, k1, k2);
                    hcn.CD = hcn.CD.TinhTienDT(hcn.CD, k1, k2);
                    hcn.AD = hcn.AD.TinhTienDT(hcn.AD, k1, k2);
                   // hcn.bc = tinhtiendt(hcn.bc);
                   // hcn.cd = tinhtiendt(hcn.cd);
                   // hcn.ad = tinhtiendt(hcn.ad);

                    hcn.AB.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
                    hcn.BC.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
                    hcn.CD.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
                    hcn.AD.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());

                    labelChange();

                }
                //hinh tam giac
                else if (Form1.hinh == 3)
                {
                    this.Refresh();

                    htg.AB = htg.AB.TinhTienDT(htg.AB,k1,k2);
                    htg.AC = htg.AC.TinhTienDT(htg.AC,k1,k2);
                    htg.BC = htg.BC.TinhTienDT(htg.BC,k1,k2);

                    htg.AB.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
                    htg.AC.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
                    htg.BC.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());

                    labelChange();
                }
                //hinh tron
                else if (Form1.hinh == 4)
                {
                    this.Refresh();

                    hinhtron.ht.tam = hinhtron.ht.tam.TinhTienDiem(hinhtron.ht.tam,k1,k2);

                    hinhtron.ht.Midpoint_htron(this.JpnLuoiGiaoDien.CreateGraphics());

                    labelChange();
                }
                //hinh vuong
                else if (Form1.hinh == 5)
                {
                    this.Refresh();

                    hinhvuong.AB = hinhvuong.AB.TinhTienDT(hinhvuong.AB,k1,k2);
                    hinhvuong.BC = hinhvuong.BC.TinhTienDT(hinhvuong.BC,k1,k2);
                    hinhvuong.CD = hinhvuong.CD.TinhTienDT(hinhvuong.CD,k1,k2);
                    hinhvuong.AD = hinhvuong.AD.TinhTienDT(hinhvuong.AD,k1,k2);

                    hinhvuong.AB.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
                    hinhvuong.BC.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
                    hinhvuong.CD.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
                    hinhvuong.AD.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());

                    labelChange();
                }
                //hinh thoi
                else if (Form1.hinh == 6)
                {
                    this.Refresh();

                    formHT.setluoigiaodien(this.JpnLuoiGiaoDien.CreateGraphics());

                    Point tam = formHT.GetHinhThoi().getTam();

                    Line Cheo1=formHT.GetHinhThoi().getCheoA();

                    Line Cheo2 = formHT.GetHinhThoi().getCheoB();

                    tam = tam.TinhTienDiem(tam,k1,k2);
                    Cheo1 = Cheo1.TinhTienDT(Cheo1,k1,k2);
                    Cheo2 = Cheo2.TinhTienDT(Cheo2,k1,k2);

                    formHT.GetHinhThoi().setTam(tam.getX(), tam.getY());
                    formHT.GetHinhThoi().setCheoA(Cheo1);
                    formHT.GetHinhThoi().setCheoB(Cheo2);

                    formHT.GetHinhThoi().Draw(this.JpnLuoiGiaoDien.CreateGraphics());
                    labelChange();
                }
                //hinh elip
                else if (Form1.hinh == 7)
                {
                    this.Refresh();

                    elip.hinhelip.tam = elip.hinhelip.tam.TinhTienDiem(elip.hinhelip.tam,k1,k2);

                    elip.hinhelip.VeElip2(this.JpnLuoiGiaoDien.CreateGraphics());

                    labelChange();
                }
            }
            
        }
    }
}
