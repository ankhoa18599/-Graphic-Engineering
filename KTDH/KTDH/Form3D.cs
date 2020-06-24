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
    public partial class Form3D : Form
    {
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

        private void jbtHopCN_Click(object sender, EventArgs e)
        {
            //Nam code
            Color c = Color.Black;
            hhcn = new HinhHopChuNhat();
            hhcn.ShowDialog();
            if (hhcn.check == false) return;
            else
            {
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
           
        }

        private void jbtnXoa_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
        private void jbtCau_Click(object sender, EventArgs e)
        {
            FormHinhCau formhc = new FormHinhCau();
            formhc.Setluoigiaodien(this.panel1.CreateGraphics());
            formhc.ShowDialog();
        }
    }
}
