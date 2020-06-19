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
    public partial class FormHinhCau : Form
    {
        private HinhCau hinhcau;
        private Graphics luoigiaodien;

        public FormHinhCau()
        {
            InitializeComponent();
        }
        public void Setluoigiaodien(Graphics g)
        {
            this.luoigiaodien = g;
        }
        private void Ve_Button_Click(object sender, EventArgs e)
        {
            Double a = Math.Sqrt(2.0) / 2;
            int x1, y1;
            int x, y, z, r;
            x = Int32.Parse(X_numericUpDown.Value.ToString());
            y = Int32.Parse(Y_numericUpDown.Value.ToString());
            z = Int32.Parse(Z_numericUpDown.Value.ToString());
            r = Int32.Parse(BanKinh_numericUpDown.Value.ToString());

            x1 = (int)(x - y * a);
            y1 = (int)(z - y * a);
            Color black = Color.Black;
            Point tam = Point.FakeToReal(x1, y1);

            hinhcau = new HinhCau();
            hinhcau.KhoitaoHT(tam.getX(), tam.getY(), r);
            hinhcau.GetHT().Midpoint_htron(luoigiaodien,black);

            int Cheoa = r;
            int Cheob = r/2;
            hinhcau.KhotaoElip(tam.getX(), tam.getY(),Cheoa,Cheob);
            hinhcau.GetElip().VeElip_netdut(luoigiaodien,black);
            

            //Point point = Line.toado2(x1, y1);
            //ht = new HT(p1.X, p1.Y, r);
            //el = new Hinhelip(p1.X, p1.Y, r, r / 2);
            this.Close();
        }
    }
}
