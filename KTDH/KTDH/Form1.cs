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
        Color color = Color.Black;
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
            xoahinh();
            Form1.hinh = 1;
            DuongThang dt = new DuongThang();
            if (dt.ShowDialog() == DialogResult.Ignore) Form1.hinh = -1;
            int xa, xb, ya, yb;
            xa = dt.xA;
            ya = dt.yA;
            xb = dt.xB;
            yb = dt.yB;
            Point p1 = Point.FakeToReal(xa, ya); // gan toa do tren Oxy 
            Point p2 = Point.FakeToReal(xb, yb);
            AB = new Line(p1.getX(), p1.getY(), p2.getX(), p2.getY(), color); //tao AB 
            AB.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color); // ve dt AB bang DDA 
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
            xoahinh();
            Form1.hinh = 2;
            hcn = new HinhChuNhat();
            if (hcn.ShowDialog() == DialogResult.Cancel) Form1.hinh =-1;
            if (hcn.checkchange == false) return;
            hcn.AB.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
            hcn.CD.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
            hcn.BC.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
            hcn.AD.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
            labelChange();
            //test 1:
        }

        private void jbtnHinhTamGiac_Click(object sender, EventArgs e)
        {
            xoahinh();
            Form1.hinh = 3;
            htg = new HinhTamGiac();
            if (htg.ShowDialog() == DialogResult.Cancel) Form1.hinh = -1;
            if (htg.checkchange == false) return;
            htg.AB.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
            htg.AC.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
            htg.BC.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
            labelChange();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            xoahinh();
            Form1.hinh = 4;
            hinhtron = new HinhTron();
            if (hinhtron.ShowDialog() == DialogResult.Cancel) Form1.hinh = -1;
            if (hinhtron.checkchange == false) return;
            hinhtron.ht.Midpoint_htron(this.JpnLuoiGiaoDien.CreateGraphics(), color);
            labelChange();
        }

        private void jbtnHinhThoi_Click(object sender, EventArgs e)
        {
            xoahinh();
            Form1.hinh = 6;
            formHT = new FormHinhThoi();
            formHT.setluoigiaodien(this.JpnLuoiGiaoDien.CreateGraphics());
            if (formHT.ShowDialog() == DialogResult.Cancel) Form1.hinh = -1;
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
            xoahinh();
            Form1.hinh = 5;
            hinhvuong = new HinhVuong();
            if (hinhvuong.ShowDialog() == DialogResult.Cancel) Form1.hinh = -1;
            if (hinhvuong.checkchange == false) return;
            hinhvuong.AB.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
            hinhvuong.BC.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
            hinhvuong.CD.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
            hinhvuong.AD.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
            labelChange();
        }

        
        private void jbtnHinhElip_Click(object sender, EventArgs e)
        {
            xoahinh();
            Form1.hinh = 7;
            elip = new HinhElip();
            if (elip.ShowDialog() == DialogResult.Cancel) Form1.hinh = -1;
            if (elip.checkchange == false) return;
            elip.hinhelip.VeElip2(this.JpnLuoiGiaoDien.CreateGraphics(), color);
            labelChange();
            //Nam code
        }

        private void jbtnTamO_Click(object sender, EventArgs e)
        {

            if(Form1.hinh == 1)
            {
                xoahinh();
                AB.doiXungO();
                AB.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                labelChange();
            }
            else if(Form1.hinh == 2)
            {
                xoahinh();
                hcn.AB.doiXungO();
                hcn.BC.doiXungO();
                hcn.CD.doiXungO();
                hcn.AD.doiXungO();
                hcn.AB.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                hcn.BC.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                hcn.CD.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                hcn.AD.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                labelChange();
            }
            else if(Form1.hinh == 3)
            {
                xoahinh();
                htg.AB.doiXungO();
                htg.AC.doiXungO();
                htg.BC.doiXungO();
                htg.AB.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                htg.AC.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                htg.BC.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                labelChange();
            }
            else if(Form1.hinh == 4)
            {
                xoahinh();
                hinhtron.ht.tam.doiXungDiemO();
                hinhtron.ht.Midpoint_htron(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                labelChange();
            }
            else if(Form1.hinh == 5)
            {
                xoahinh();
                hinhvuong.AB.doiXungO();
                hinhvuong.BC.doiXungO();
                hinhvuong.CD.doiXungO();
                hinhvuong.AD.doiXungO();
                hinhvuong.AB.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                hinhvuong.BC.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                hinhvuong.CD.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                hinhvuong.AD.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                labelChange();
            }
            else if(Form1.hinh == 6)
            {
                xoahinh();
                formHT.setluoigiaodien(this.JpnLuoiGiaoDien.CreateGraphics());
                formHT.GetHinhThoi().getTam().doiXungDiemO();
                formHT.GetHinhThoi().getCheoA().doiXungO();
                formHT.GetHinhThoi().getCheoB().doiXungO();
                formHT.GetHinhThoi().Draw(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                labelChange();
            }
            else if(Form1.hinh == 7)
            {
                xoahinh();
                elip.hinhelip.tam.doiXungDiemO();
                elip.hinhelip.VeElip2(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                labelChange();
            }
        }

        private void jbtnOx_Click(object sender, EventArgs e)
        {
            if (Form1.hinh == 1)
            {
                xoahinh();
                AB.doiXungOx();
                AB.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                //labelChange();
            }
            else if (Form1.hinh == 2)
            {
                xoahinh();
                hcn.AB.doiXungOx();
                hcn.BC.doiXungOx();
                hcn.CD.doiXungOx();
                hcn.AD.doiXungOx();
                hcn.AB.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                hcn.BC.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                hcn.CD.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                hcn.AD.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                labelChange();
            }
            else if (Form1.hinh == 3)
            {
                xoahinh();
                htg.AB.doiXungOx();
                htg.AC.doiXungOx();
                htg.BC.doiXungOx();
                htg.AB.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                htg.AC.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                htg.BC.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                labelChange();
            }
            else if (Form1.hinh == 4)
            {
                xoahinh();
                hinhtron.ht.tam.doiXungTrucOx();
                hinhtron.ht.Midpoint_htron(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                labelChange();
            }
            else if (Form1.hinh == 5)
            {
                xoahinh();
                hinhvuong.AB.doiXungOx();
                hinhvuong.BC.doiXungOx();
                hinhvuong.CD.doiXungOx();
                hinhvuong.AD.doiXungOx();
                hinhvuong.AB.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                hinhvuong.BC.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                hinhvuong.CD.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                hinhvuong.AD.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                labelChange();
            }
            else if (Form1.hinh == 6)
            {
                xoahinh();
                formHT.setluoigiaodien(this.JpnLuoiGiaoDien.CreateGraphics());
                formHT.GetHinhThoi().getTam().doiXungTrucOx();
                formHT.GetHinhThoi().getCheoA().doiXungOx();
                formHT.GetHinhThoi().getCheoB().doiXungOx();
                formHT.GetHinhThoi().Draw(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                labelChange();
            }
            else if (Form1.hinh == 7)
            {
                xoahinh();
                elip.hinhelip.tam.doiXungTrucOx();
                elip.hinhelip.VeElip2(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                labelChange();
            }
        }

        private void jbtnOy_Click(object sender, EventArgs e)
        {
            if (Form1.hinh == 1)
            {
                this.xoahinh();
                AB.doiXungOy();
                AB.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                labelChange();
            }
            else if (Form1.hinh == 2)
            {
                xoahinh();
                hcn.AB.doiXungOy();
                hcn.BC.doiXungOy();
                hcn.CD.doiXungOy();
                hcn.AD.doiXungOy();
                hcn.AB.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                hcn.BC.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                hcn.CD.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                hcn.AD.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                labelChange();
            }
            else if (Form1.hinh == 3)
            {
                xoahinh();
                htg.AB.doiXungOy();
                htg.AC.doiXungOy();
                htg.BC.doiXungOy();
                htg.AB.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                htg.AC.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                htg.BC.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                labelChange();
            }
            else if (Form1.hinh == 4)
            {
                xoahinh();
                hinhtron.ht.tam.doiXungTrucOy();
                hinhtron.ht.Midpoint_htron(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                labelChange();
            }
            else if (Form1.hinh == 5)
            {
                xoahinh();
                hinhvuong.AB.doiXungOy();
                hinhvuong.BC.doiXungOy();
                hinhvuong.CD.doiXungOy();
                hinhvuong.AD.doiXungOy();
                hinhvuong.AB.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                hinhvuong.BC.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                hinhvuong.CD.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                hinhvuong.AD.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                labelChange();
            }
            else if (Form1.hinh == 6)
            {
                xoahinh();
                formHT.setluoigiaodien(this.JpnLuoiGiaoDien.CreateGraphics());
                formHT.GetHinhThoi().getTam().doiXungTrucOy();
                formHT.GetHinhThoi().getCheoA().doiXungOy();
                formHT.GetHinhThoi().getCheoB().doiXungOy();
                formHT.GetHinhThoi().Draw(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                labelChange();
            }
            else if (Form1.hinh == 7)
            {
                xoahinh();
                elip.hinhelip.tam.doiXungTrucOy();
                elip.hinhelip.VeElip2(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                labelChange();
            }
        }

        private void jbntQuay_Click(object sender, EventArgs e)
        {
            if (Form1.hinh == 1)
            {
                xoahinh();
                AB.QuayDT();
                AB.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                labelChange();
            }
            else if (Form1.hinh == 2)
            {
                xoahinh();
                hcn.AB.QuayDT();
                hcn.BC.QuayDT();
                hcn.CD.QuayDT();
                hcn.AD.QuayDT();

                hcn.AB.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                hcn.BC.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                hcn.CD.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                hcn.AD.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                labelChange();
            }
            else if (Form1.hinh == 3)
            {
                xoahinh();
                htg.AB.QuayDT();
                htg.AC.QuayDT();
                htg.BC.QuayDT();
                htg.AB.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                htg.AC.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                htg.BC.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                labelChange();
            }
            else if (Form1.hinh == 4)
            {
                xoahinh();
                hinhtron.ht.tam.QuayDiem();
                hinhtron.ht.Midpoint_htron(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                labelChange();
            }
            else if (Form1.hinh == 5)
            {
                xoahinh();
                hinhvuong.AB.QuayDT();
                hinhvuong.BC.QuayDT();
                hinhvuong.CD.QuayDT();
                hinhvuong.AD.QuayDT();
                hinhvuong.AB.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                hinhvuong.BC.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                hinhvuong.CD.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                hinhvuong.AD.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                labelChange();
            }
            else if (Form1.hinh == 6)
            {
                xoahinh();
                formHT.setluoigiaodien(this.JpnLuoiGiaoDien.CreateGraphics());
                formHT.GetHinhThoi().getTam().QuayDiem();
                formHT.GetHinhThoi().getCheoA().QuayDT();
                formHT.GetHinhThoi().getCheoB().QuayDT();
                formHT.GetHinhThoi().Draw(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                labelChange();
            }
            else if (Form1.hinh == 7)
            {
                xoahinh();
                elip.hinhelip.tam.QuayDiem();
                elip.hinhelip.VeElip2(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                labelChange();
            }
        }

        private void btnVeNha_Click(object sender, EventArgs e)
        {
            Graphics g = this.JpnLuoiGiaoDien.CreateGraphics();
            House nha = new House();
            int nhax=0, nhay=0, nhacao=20, nharong=20;
            nha.setThanNha(nhax, nhay, nhacao, nharong);
            nha.setFull();
            nha.VeFull(g,Color.Black);

            for(double i = 1; i > 0; i -= 0.1)
            {
                nha.setThanNha(nhax, nhay, nhacao, nharong);
                nha.getThanNha().TiLe(1, i, nha.getThanNha().getA().getX()+(nha.getThanNha().getB().getX() - nha.getThanNha().getA().getX()) / 2.0, nha.getThanNha().getA().getY());
                nha.setFull();
                nha.VeFull(g, Color.Black);
                this.Refresh();
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
                xoahinh();
                if (Form1.hinh == 6)
                {
                    //tỉ lệ làm theo cách mới
                    this.formHT.GetHinhThoi().getCheoA().TiLe(Sx, Sy);
                    this.formHT.GetHinhThoi().getCheoB().TiLe(Sx, Sy);
                    double GocX = formHT.GetHinhThoi().getTam().getX() * Sx;
                    double GocY = formHT.GetHinhThoi().getTam().getY() * Sy;
                    double Dentax = GocX - formHT.GetHinhThoi().getTam().getX();
                    double Dentay = GocY - formHT.GetHinhThoi().getTam().getY();
                    formHT.GetHinhThoi().getCheoA().TinhTien(-Dentax, -Dentay);
                    formHT.GetHinhThoi().getCheoB().TinhTien(-Dentax, -Dentay);
                    formHT.GetHinhThoi().Draw(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                }
                else if (Form1.hinh == 5)
                {
                    //tỉ lệ theo cách mới
                    hinhvuong.AB.RealtoFake();
                    hinhvuong.BC.RealtoFake();
                    hinhvuong.CD.RealtoFake();
                    hinhvuong.AD.RealtoFake();

                    double GocX0 = hinhvuong.AB.getFpoint().getX()+(hinhvuong.AB.getLpoint().getX() - hinhvuong.AB.getFpoint().getX()) / 2.0;
                    double GocY0 = hinhvuong.BC.getFpoint().getY()+(hinhvuong.BC.getLpoint().getY() - hinhvuong.BC.getFpoint().getY()) / 2.0;
                    double GocX = GocX0 * Sx;
                    double GocY = GocY0 * Sy;
                    double DentaX = GocX - GocX0;
                    double DentaY = GocY - GocY0;

                    hinhvuong.AB.TiLe(Sx, Sy);
                    hinhvuong.BC.TiLe(Sx, Sy);
                    hinhvuong.CD.TiLe(Sx, Sy);
                    hinhvuong.AD.TiLe(Sx, Sy);

                    hinhvuong.AB.TinhTien(-DentaX, -DentaY);
                    hinhvuong.BC.TinhTien(-DentaX, -DentaY);
                    hinhvuong.CD.TinhTien(-DentaX, -DentaY);
                    hinhvuong.AD.TinhTien(-DentaX, -DentaY);

                    hinhvuong.AB.FaketoReal();
                    hinhvuong.BC.FaketoReal();
                    hinhvuong.CD.FaketoReal();
                    hinhvuong.AD.FaketoReal();

                    hinhvuong.AB.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                    hinhvuong.CD.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                    hinhvuong.BC.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                    hinhvuong.AD.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);

                }
                else if (Form1.hinh == 2)
                {
                    hcn.AB.RealtoFake();
                    hcn.BC.RealtoFake();
                    hcn.CD.RealtoFake();
                    hcn.AD.RealtoFake();

                    double GocX0 = hcn.AB.getFpoint().getX() + (hcn.AB.getLpoint().getX() - hcn.AB.getFpoint().getX()) / 2.0;
                    double GocY0 = hcn.BC.getFpoint().getY() + (hcn.BC.getLpoint().getY() - hcn.BC.getFpoint().getY()) / 2.0;
                    double GocX = GocX0 * Sx;
                    double GocY = GocY0 * Sy;
                    double DentaX = GocX - GocX0;
                    double DentaY = GocY - GocY0;

                    hcn.AB.TiLe(Sx, Sy);
                    hcn.BC.TiLe(Sx, Sy);
                    hcn.CD.TiLe(Sx, Sy);
                    hcn.AD.TiLe(Sx, Sy);

                    hcn.AB.TinhTien(-DentaX, -DentaY);
                    hcn.BC.TinhTien(-DentaX, -DentaY);
                    hcn.CD.TinhTien(-DentaX, -DentaY);
                    hcn.AD.TinhTien(-DentaX, -DentaY);

                    hcn.AB.FaketoReal();
                    hcn.BC.FaketoReal();
                    hcn.CD.FaketoReal();
                    hcn.AD.FaketoReal();

                    hcn.AB.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                    hcn.CD.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                    hcn.BC.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                    hcn.AD.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                }
                else if (Form1.hinh == 7)
                {
                    Point A1 = new Point(elip.hinhelip.tam.getX() - elip.hinhelip.a, elip.hinhelip.tam.getY());
                    Point A2 = new Point(elip.hinhelip.tam.getX() + elip.hinhelip.a, elip.hinhelip.tam.getY());
                    Point B1 = new Point(elip.hinhelip.tam.getX(), elip.hinhelip.tam.getY() - elip.hinhelip.b);
                    Point B2 = new Point(elip.hinhelip.tam.getX(), elip.hinhelip.tam.getY() + elip.hinhelip.b);
                    Line A1A2 = new Line(A1.getX(), A1.getY(), A2.getX(), A2.getY(), Color.Black);
                    Line B1B2 = new Line(B1.getX(), B1.getY(), B2.getX(), B2.getY(), Color.Black);
                    A1A2.TiLe(Sx, Sy);
                    B1B2.TiLe(Sx, Sy);
                    double GocX = elip.hinhelip.tam.getX() * Sx;
                    double GocY = elip.hinhelip.tam.getY() * Sy;
                    double DentaX = GocX - elip.hinhelip.tam.getX();
                    double DentaY = GocY - elip.hinhelip.tam.getY();
                    A1A2.TinhTien(-DentaX, -DentaY);
                    B1B2.TinhTien(-DentaX, -DentaY);
                    // tính lại ab
                    elip.hinhelip.a = (int)Math.Round((A1A2.getLpoint().getX() - A1A2.getFpoint().getX())/2.0);
                    elip.hinhelip.b = (int)Math.Round((B1B2.getLpoint().getY() - B1B2.getFpoint().getY())/ 2.0);
                    elip.hinhelip.VeElip2(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                }
                else if (Form1.hinh == 4)
                {
                    if (Sx == Sy)
                    {

                        hinhtron.ht.R = Point.round(hinhtron.ht.R * Sx);
                        hinhtron.ht.Midpoint_htron(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                    }
                    else
                    {
                        Form1.hinh = 7;
                        Point A1 = new Point(hinhtron.ht.getTam().getX() - hinhtron.ht.getR(), hinhtron.ht.getTam().getY());
                        Point A2 = new Point(hinhtron.ht.getTam().getX() + hinhtron.ht.getR(), hinhtron.ht.getTam().getY());
                        Point B1 = new Point(hinhtron.ht.getTam().getX(), hinhtron.ht.getTam().getY() - hinhtron.ht.getR());
                        Point B2 = new Point(hinhtron.ht.getTam().getX(), hinhtron.ht.getTam().getY() + hinhtron.ht.getR());
                        Line A1A2 = new Line(A1.getX(), A1.getY(), A2.getX(), A2.getY(), Color.Black);
                        Line B1B2 = new Line(B1.getX(), B1.getY(), B2.getX(), B2.getY(), Color.Black);
                        A1A2.TiLe(Sx, Sy);
                        B1B2.TiLe(Sx, Sy);
                        double GocX = hinhtron.ht.getTam().getX() * Sx;
                        double GocY = hinhtron.ht.getTam().getY() * Sy;
                        double DentaX = GocX - hinhtron.ht.getTam().getX();
                        double DentaY = GocY - hinhtron.ht.getTam().getY();
                        A1A2.TinhTien(-DentaX, -DentaY);
                        B1B2.TinhTien(-DentaX, -DentaY);
                        // tính lại ab
                        elip = new HinhElip();
                        elip.hinhelip = new Elip(hinhtron.ht.getTam().getX(), hinhtron.ht.getTam().getY(), 0, 0);
                        elip.hinhelip.a = (int)Math.Round((A1A2.getLpoint().getX() - A1A2.getFpoint().getX()) / 2.0);
                        elip.hinhelip.b = (int)Math.Round((B1B2.getLpoint().getY() - B1B2.getFpoint().getY()) / 2.0);
                        elip.hinhelip.VeElip2(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                    }
                }
                else if (Form1.hinh == 3)
                {
                    Point A = new Point(htg.xA, htg.yA);
                    Point B = new Point(htg.xA + htg.rong, htg.yA);
                    Point C = new Point(htg.xA + (int)Math.Round(htg.rong / 2.0), htg.yA + htg.cao);
                    A.TileDiem(Sx, Sy);
                    B.TileDiem(Sx, Sy);
                    C.TileDiem(Sx, Sy);
                    double GocX0 = htg.xA + (int)Math.Round(htg.rong / 2.0);
                    double GocY0 = htg.yA + (int)Math.Round(htg.cao / 2.0);
                    double GocX = GocX0 * Sx;
                    double GocY = GocY0 * Sy;
                    double DentaX = GocX - GocX0;
                    double DentaY = GocY - GocY0;
                    A.TinhTienDiem(-DentaX, -DentaY);
                    B.TinhTienDiem(-DentaX, -DentaY);
                    C.TinhTienDiem(-DentaX, -DentaY);
                    Line AB = new Line(A.getX(), A.getY(), B.getX(), B.getY(), color);
                    Line BC = new Line(B.getX(), B.getY(), C.getX(), C.getY(), color);
                    Line AC = new Line(A.getX(), A.getY(), C.getX(), C.getY(), color);
                    //reset tamgiac
                    htg.AB = AB;
                    htg.AC = AC;
                    htg.BC = BC;
                    htg.xA = A.getX();
                    htg.yA = A.getY();
                    htg.cao = C.getY() - A.getY();
                    htg.rong = B.getX() - A.getX();
                    //vẽ
                    AB.FaketoReal();
                    BC.FaketoReal();
                    AC.FaketoReal();
                    AB.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                    BC.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                    AC.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);

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
                    xoahinh();

                    //AB = TinhTienDT(AB);
                    AB = AB.TinhTienDT(AB, k1, k2);

                    AB.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);

                    labelChange();

                }
                //hinh chu nhat
                else if (Form1.hinh == 2)
                {
                    xoahinh();

                    hcn.AB = hcn.AB.TinhTienDT(hcn.AB, k1, k2);
                    hcn.BC = hcn.BC.TinhTienDT(hcn.BC, k1, k2);
                    hcn.CD = hcn.CD.TinhTienDT(hcn.CD, k1, k2);
                    hcn.AD = hcn.AD.TinhTienDT(hcn.AD, k1, k2);
                    // hcn.bc = tinhtiendt(hcn.bc);
                    // hcn.cd = tinhtiendt(hcn.cd);
                    // hcn.ad = tinhtiendt(hcn.ad);

                    hcn.AB.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                    hcn.BC.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                    hcn.CD.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                    hcn.AD.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);

                    labelChange();

                }
                //hinh tam giac
                else if (Form1.hinh == 3)
                {
                    xoahinh();

                    htg.AB = htg.AB.TinhTienDT(htg.AB, k1, k2);
                    htg.AC = htg.AC.TinhTienDT(htg.AC, k1, k2);
                    htg.BC = htg.BC.TinhTienDT(htg.BC, k1, k2);

                    htg.AB.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                    htg.AC.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                    htg.BC.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);

                    labelChange();
                }
                //hinh tron
                else if (Form1.hinh == 4)
                {
                    xoahinh();

                    hinhtron.ht.tam = hinhtron.ht.tam.TinhTienDiem(hinhtron.ht.tam, k1, k2);

                    hinhtron.ht.Midpoint_htron(this.JpnLuoiGiaoDien.CreateGraphics(), color);

                    labelChange();
                }
                //hinh vuong
                else if (Form1.hinh == 5)
                {
                    xoahinh();

                    hinhvuong.AB = hinhvuong.AB.TinhTienDT(hinhvuong.AB, k1, k2);
                    hinhvuong.BC = hinhvuong.BC.TinhTienDT(hinhvuong.BC, k1, k2);
                    hinhvuong.CD = hinhvuong.CD.TinhTienDT(hinhvuong.CD, k1, k2);
                    hinhvuong.AD = hinhvuong.AD.TinhTienDT(hinhvuong.AD, k1, k2);

                    hinhvuong.AB.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                    hinhvuong.BC.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                    hinhvuong.CD.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                    hinhvuong.AD.DDA_Line(this.JpnLuoiGiaoDien.CreateGraphics(), color);

                    labelChange();
                }
                //hinh thoi
                else if (Form1.hinh == 6)
                {
                    xoahinh();

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

                    formHT.GetHinhThoi().Draw(this.JpnLuoiGiaoDien.CreateGraphics(), color);
                    labelChange();
                }
                //hinh elip
                else if (Form1.hinh == 7)
                {
                    xoahinh();

                    elip.hinhelip.tam = elip.hinhelip.tam.TinhTienDiem(elip.hinhelip.tam, k1, k2);

                    elip.hinhelip.VeElip2(this.JpnLuoiGiaoDien.CreateGraphics(), color);

                    labelChange();
                }
            }
                }
        private void btnVeNha_Click(object sender, EventArgs e)
        {
            XeTang xt = new XeTang(-37,2);
            xt.VeXeTang(this.JpnLuoiGiaoDien.CreateGraphics());
        }

        private void xoahinh()
        {
            Color xoa = Color.FromArgb(224, 224, 224);
            
            if (Form1.hinh == 1)
            {
                AB.DDA_Linexoa(this.JpnLuoiGiaoDien.CreateGraphics(), xoa);
            }
            else if (Form1.hinh == 2)
            {
                hcn.AB.DDA_Linexoa(this.JpnLuoiGiaoDien.CreateGraphics(), xoa);
                hcn.BC.DDA_Linexoa(this.JpnLuoiGiaoDien.CreateGraphics(), xoa);
                hcn.CD.DDA_Linexoa(this.JpnLuoiGiaoDien.CreateGraphics(), xoa);
                hcn.AD.DDA_Linexoa(this.JpnLuoiGiaoDien.CreateGraphics(), xoa);
            }
            else if (Form1.hinh == 3)
            {
                htg.AB.DDA_Linexoa(this.JpnLuoiGiaoDien.CreateGraphics(), xoa);
                htg.AC.DDA_Linexoa(this.JpnLuoiGiaoDien.CreateGraphics(), xoa);
                htg.BC.DDA_Linexoa(this.JpnLuoiGiaoDien.CreateGraphics(), xoa);
            }
            else if (Form1.hinh == 4)
            {
                hinhtron.ht.Midpoint_htronxoa(this.JpnLuoiGiaoDien.CreateGraphics(), xoa);
            }
            else if (Form1.hinh == 5)
            {
                hinhvuong.AB.DDA_Linexoa(this.JpnLuoiGiaoDien.CreateGraphics(), xoa);
                hinhvuong.BC.DDA_Linexoa(this.JpnLuoiGiaoDien.CreateGraphics(), xoa);
                hinhvuong.CD.DDA_Linexoa(this.JpnLuoiGiaoDien.CreateGraphics(), xoa);
                hinhvuong.AD.DDA_Linexoa(this.JpnLuoiGiaoDien.CreateGraphics(), xoa);
            }
            else if (Form1.hinh == 6)
            {
                formHT.setluoigiaodien(this.JpnLuoiGiaoDien.CreateGraphics());
                formHT.GetHinhThoi().Drawxoa(this.JpnLuoiGiaoDien.CreateGraphics(), xoa);
            }
            else if (Form1.hinh == 7)
            {
                elip.hinhelip.VeElip2xoa(this.JpnLuoiGiaoDien.CreateGraphics(), xoa);
            }
        }

    }
}
