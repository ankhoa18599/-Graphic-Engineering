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
        Line AB, CD, BC, AD;
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
                    label21.Text = ((hcn.BC.getLpoint().getY() - 200) / 5).ToString();
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
                label12.Text = (hinhtron.ht.getR() / 5).ToString();
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
        private void jbtnVe3D_Click(object sender, EventArgs e)
        {
            Form3D ve3d = new Form3D();
            ve3d.ShowDialog();
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

        private void jbtnTamO_Click(object sender, EventArgs e)
        {
            if(Form1.hinh == 1)
            {
                this.Refresh();
                AB.doiXungO();
                AB.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
                labelChange();
            }
            else if(Form1.hinh == 2)
            {
                this.Refresh();
                hcn.AB.doiXungO();
                hcn.BC.doiXungO();
                hcn.CD.doiXungO();
                hcn.AD.doiXungO();
                hcn.AB.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
                hcn.BC.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
                hcn.CD.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
                hcn.AD.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
                labelChange();
            }
            else if(Form1.hinh == 3)
            {
                this.Refresh();
                htg.AB.doiXungO();
                htg.AC.doiXungO();
                htg.BC.doiXungO();
                htg.AB.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
                htg.AC.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
                htg.BC.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
                labelChange();
            }
            else if(Form1.hinh == 4)
            {
                this.Refresh();
                hinhtron.ht.tam.doiXungDiemO();
                hinhtron.ht.Midpoint_htron(this.JpnLuoiGiaoDien.CreateGraphics());
                labelChange();
            }
            else if(Form1.hinh == 5)
            {
                this.Refresh();
                hinhvuong.AB.doiXungO();
                hinhvuong.BC.doiXungO();
                hinhvuong.CD.doiXungO();
                hinhvuong.AD.doiXungO();
                hinhvuong.AB.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
                hinhvuong.BC.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
                hinhvuong.CD.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
                hinhvuong.AD.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
                labelChange();
            }
            else if(Form1.hinh == 6)
            {
                this.Refresh();
                formHT.setluoigiaodien(this.JpnLuoiGiaoDien.CreateGraphics());
                formHT.GetHinhThoi().getTam().doiXungDiemO();
                formHT.GetHinhThoi().getCheoA().doiXungO();
                formHT.GetHinhThoi().getCheoB().doiXungO();
                formHT.GetHinhThoi().Draw(this.JpnLuoiGiaoDien.CreateGraphics());
                labelChange();
            }
            else if(Form1.hinh == 7)
            {
                this.Refresh();
                elip.hinhelip.tam.doiXungDiemO();
                elip.hinhelip.VeElip2(this.JpnLuoiGiaoDien.CreateGraphics());
                labelChange();
            }
        }

        private void jbtnOx_Click(object sender, EventArgs e)
        {
            if (Form1.hinh == 1)
            {
                this.Refresh();
                AB.doiXungOx();
                AB.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
                labelChange();
            }
            else if (Form1.hinh == 2)
            {
                this.Refresh();
                hcn.AB.doiXungOx();
                hcn.BC.doiXungOx();
                hcn.CD.doiXungOx();
                hcn.AD.doiXungOx();
                hcn.AB.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
                hcn.BC.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
                hcn.CD.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
                hcn.AD.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
                labelChange();
            }
            else if (Form1.hinh == 3)
            {
                this.Refresh();
                htg.AB.doiXungOx();
                htg.AC.doiXungOx();
                htg.BC.doiXungOx();
                htg.AB.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
                htg.AC.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
                htg.BC.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
                labelChange();
            }
            else if (Form1.hinh == 4)
            {
                this.Refresh();
                hinhtron.ht.tam.doiXungTrucOx();
                hinhtron.ht.Midpoint_htron(this.JpnLuoiGiaoDien.CreateGraphics());
                labelChange();
            }
            else if (Form1.hinh == 5)
            {
                this.Refresh();
                hinhvuong.AB.doiXungOx();
                hinhvuong.BC.doiXungOx();
                hinhvuong.CD.doiXungOx();
                hinhvuong.AD.doiXungOx();
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
                formHT.GetHinhThoi().getTam().doiXungTrucOx();
                formHT.GetHinhThoi().getCheoA().doiXungOx();
                formHT.GetHinhThoi().getCheoB().doiXungOx();
                formHT.GetHinhThoi().Draw(this.JpnLuoiGiaoDien.CreateGraphics());
                labelChange();
            }
            else if (Form1.hinh == 7)
            {
                this.Refresh();
                elip.hinhelip.tam.doiXungTrucOx();
                elip.hinhelip.VeElip2(this.JpnLuoiGiaoDien.CreateGraphics());
                labelChange();
            }
        }

        private void jbtnOy_Click(object sender, EventArgs e)
        {
            if (Form1.hinh == 1)
            {
                this.Refresh();
                AB.doiXungOy();
                AB.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
                labelChange();
            }
            else if (Form1.hinh == 2)
            {
                this.Refresh();
                hcn.AB.doiXungOy();
                hcn.BC.doiXungOy();
                hcn.CD.doiXungOy();
                hcn.AD.doiXungOy();
                hcn.AB.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
                hcn.BC.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
                hcn.CD.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
                hcn.AD.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
                labelChange();
            }
            else if (Form1.hinh == 3)
            {
                this.Refresh();
                htg.AB.doiXungOy();
                htg.AC.doiXungOy();
                htg.BC.doiXungOy();
                htg.AB.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
                htg.AC.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
                htg.BC.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
                labelChange();
            }
            else if (Form1.hinh == 4)
            {
                this.Refresh();
                hinhtron.ht.tam.doiXungTrucOy();
                hinhtron.ht.Midpoint_htron(this.JpnLuoiGiaoDien.CreateGraphics());
                labelChange();
            }
            else if (Form1.hinh == 5)
            {
                this.Refresh();
                hinhvuong.AB.doiXungOy();
                hinhvuong.BC.doiXungOy();
                hinhvuong.CD.doiXungOy();
                hinhvuong.AD.doiXungOy();
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
                formHT.GetHinhThoi().getTam().doiXungTrucOy();
                formHT.GetHinhThoi().getCheoA().doiXungOy();
                formHT.GetHinhThoi().getCheoB().doiXungOy();
                formHT.GetHinhThoi().Draw(this.JpnLuoiGiaoDien.CreateGraphics());
                labelChange();
            }
            else if (Form1.hinh == 7)
            {
                this.Refresh();
                elip.hinhelip.tam.doiXungTrucOy();
                elip.hinhelip.VeElip2(this.JpnLuoiGiaoDien.CreateGraphics());
                labelChange();
            }
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
                //this.Refresh();
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

        private void jbtntiLe_Click(object sender, EventArgs e)
        {
            if (Form1.hinh == -1) return;
            else
            {
                double Sx, Sy;
                Sx = (double)this.Sx_numeric.Value;
                Sy = (double)this.Sy_numeric.Value;
                this.Refresh();
                if (Form1.hinh == 6)
                {
                    this.formHT.GetHinhThoi().getCheoA().TileSy(Sy);
                    this.formHT.GetHinhThoi().getCheoB().TiLeSx(Sx);
                    this.formHT.GetHinhThoi().Draw(this.JpnLuoiGiaoDien.CreateGraphics());
                }
                else if (Form1.hinh == 5)
                {
                    hinhvuong.AB.TiLeSx(Sx);
                    hinhvuong.CD.TiLeSx(Sx);
                    hinhvuong.BC.TileSy(Sy);
                    hinhvuong.AD.TileSy(Sy);

                    hinhvuong.AB.getFpoint().setY(hinhvuong.AD.getFpoint().getY());
                    hinhvuong.AB.getLpoint().setY(hinhvuong.AB.getFpoint().getY());
                    hinhvuong.CD.getFpoint().setY(hinhvuong.AD.getLpoint().getY());
                    hinhvuong.CD.getLpoint().setY(hinhvuong.CD.getFpoint().getY());
                    hinhvuong.BC.getFpoint().setX(hinhvuong.CD.getFpoint().getX());
                    hinhvuong.BC.getLpoint().setX(hinhvuong.BC.getFpoint().getX());
                    hinhvuong.AD.getFpoint().setX(hinhvuong.AB.getFpoint().getX());
                    hinhvuong.AD.getLpoint().setX(hinhvuong.AD.getFpoint().getX());

                    hinhvuong.AB.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
                    hinhvuong.CD.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
                    hinhvuong.BC.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
                    hinhvuong.AD.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
                }
                else if (Form1.hinh == 2)
                {
                    hcn.AB.TiLeSx(Sx);
                    hcn.CD.TiLeSx(Sx);
                    hcn.BC.TileSy(Sy);
                    hcn.AD.TileSy(Sy);

                    hcn.AB.getFpoint().setY(hcn.AD.getFpoint().getY());
                    hcn.AB.getLpoint().setY(hcn.AB.getFpoint().getY());
                    hcn.CD.getFpoint().setY(hcn.AD.getLpoint().getY());
                    hcn.CD.getLpoint().setY(hcn.CD.getFpoint().getY());
                    hcn.BC.getFpoint().setX(hcn.CD.getFpoint().getX());
                    hcn.BC.getLpoint().setX(hcn.BC.getFpoint().getX());
                    hcn.AD.getFpoint().setX(hcn.AB.getFpoint().getX());
                    hcn.AD.getLpoint().setX(hcn.AD.getFpoint().getX());

                    hcn.AB.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
                    hcn.CD.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
                    hcn.BC.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
                    hcn.AD.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
                }
                else if (Form1.hinh == 7)
                {
                    elip.hinhelip.a = Point.round(elip.hinhelip.a * Sx);
                    elip.hinhelip.b = Point.round(elip.hinhelip.b * Sy);
                    elip.hinhelip.VeElip2(this.JpnLuoiGiaoDien.CreateGraphics());
                }
                else if (Form1.hinh == 4)
                {
                    if (Sx == Sy)
                    {
                        hinhtron.ht.R = Point.round(hinhtron.ht.R * Sx);
                        hinhtron.ht.Midpoint_htron(this.JpnLuoiGiaoDien.CreateGraphics());
                    }
                    else
                    {
                        Form1.hinh = 7;
                        int a = Point.round(hinhtron.ht.R * Sx);
                        int b = Point.round(hinhtron.ht.R * Sy);
                        elip = new HinhElip();
                        elip.hinhelip = new Elip(hinhtron.ht.getTam().getX(), hinhtron.ht.getTam().getY(), a, b);
                        elip.hinhelip.VeElip2(this.JpnLuoiGiaoDien.CreateGraphics());
                    }
                }
                else if (Form1.hinh == 3)
                {
                    Line canhday = new Line(htg.xA, htg.yA, (int)(htg.xA + htg.rong), htg.yA, Color.Black);
                    Point midpointday = new Point((htg.xA + htg.rong) / 2, htg.yA);
                    Point midpointcao = new Point(midpointday.getX(), midpointday.getY() + htg.cao);
                    Line duongcao = new Line(midpointcao.getX(), midpointcao.getY(), midpointday.getX(), midpointday.getY(), Color.Black);
                    canhday.TiLeSx(Sx);
                    duongcao.TileSy(Sy);
                    Point A = new Point(canhday.getFpoint().getX(), duongcao.getLpoint().getY());
                    Point B = new Point(canhday.getLpoint().getX(), duongcao.getLpoint().getY());
                    Point C = new Point((canhday.getLpoint().getX() - Math.Abs(canhday.getFpoint().getX())) / 2, duongcao.getFpoint().getY());

                    htg.xA = A.getX();
                    htg.yA = A.getY();
                    htg.rong = canhday.getLpoint().getX() - canhday.getFpoint().getX();
                    htg.cao = duongcao.getFpoint().getY() - duongcao.getLpoint().getY(); ;

                    A = Point.FakeToReal(A.getX(), A.getY());
                    B = Point.FakeToReal(B.getX(), B.getY());
                    C = Point.FakeToReal(C.getX(), C.getY());


                    Line AB = new Line(A.getX(), A.getY(), B.getX(), B.getY(), Color.Black);
                    Line BC = new Line(B.getX(), B.getY(), C.getX(), C.getY(), Color.Black);
                    Line CA = new Line(C.getX(), C.getY(), A.getX(), A.getY(), Color.Black);

                    AB.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
                    BC.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
                    CA.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());

                }
                this.labelChange();
            }
        }
        private void jbtnTinhTien_Click(object sender, EventArgs e)
        {
            //abc
            int k1, k2;
            k1 = Int32.Parse(numericUpDown1.Value.ToString());
            k2 = Int32.Parse(numericUpDown2.Value.ToString());
            if (k1 == 0 && k2 == 0)
            {
                MessageBox.Show("Bạn chưa nhập thông tin tịnh tiến", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (Form1.hinh == 1)    //duong thang
                {
                    this.Refresh();

                    //AB = TinhTienDT(AB);
                    AB = AB.TinhTienDT(AB, k1, k2);

                    AB.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());

                    labelChange();

                }
                //hinh chu nhat
                else if (Form1.hinh == 2)
                {
                    this.Refresh();

                    hcn.AB = hcn.AB.TinhTienDT(hcn.AB, k1, k2);
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

                    htg.AB = htg.AB.TinhTienDT(htg.AB, k1, k2);
                    htg.AC = htg.AC.TinhTienDT(htg.AC, k1, k2);
                    htg.BC = htg.BC.TinhTienDT(htg.BC, k1, k2);

                    htg.AB.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
                    htg.AC.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());
                    htg.BC.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics());

                    labelChange();
                }
                //hinh tron
                else if (Form1.hinh == 4)
                {
                    this.Refresh();

                    hinhtron.ht.tam = hinhtron.ht.tam.TinhTienDiem(hinhtron.ht.tam, k1, k2);

                    hinhtron.ht.Midpoint_htron(this.JpnLuoiGiaoDien.CreateGraphics());

                    labelChange();
                }
                //hinh vuong
                else if (Form1.hinh == 5)
                {
                    this.Refresh();

                    hinhvuong.AB = hinhvuong.AB.TinhTienDT(hinhvuong.AB, k1, k2);
                    hinhvuong.BC = hinhvuong.BC.TinhTienDT(hinhvuong.BC, k1, k2);
                    hinhvuong.CD = hinhvuong.CD.TinhTienDT(hinhvuong.CD, k1, k2);
                    hinhvuong.AD = hinhvuong.AD.TinhTienDT(hinhvuong.AD, k1, k2);

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

                    Line Cheo1 = formHT.GetHinhThoi().getCheoA();

                    Line Cheo2 = formHT.GetHinhThoi().getCheoB();

                    tam = tam.TinhTienDiem(tam, k1, k2);
                    Cheo1 = Cheo1.TinhTienDT(Cheo1, k1, k2);
                    Cheo2 = Cheo2.TinhTienDT(Cheo2, k1, k2);

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

                    elip.hinhelip.tam = elip.hinhelip.tam.TinhTienDiem(elip.hinhelip.tam, k1, k2);

                    elip.hinhelip.VeElip2(this.JpnLuoiGiaoDien.CreateGraphics());

                    labelChange();
                }
            }
        }

    }
}
