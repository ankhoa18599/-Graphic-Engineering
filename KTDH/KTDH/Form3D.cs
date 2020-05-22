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
            for (int i = 40; i <= 80; i++)
            {
                g.DrawLine(new Pen(Color.White), 5 * i, 0, 5 * i, 200);
                g.DrawLine(new Pen(Color.White), 200, temp2, 0, i * 5);
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

            g.DrawLine(new Pen(Color.Red), 200, 200, 400, 200);
            g.DrawLine(new Pen(Color.Red), 200, 0, 200, 200);
            g.DrawLine(new Pen(Color.Red), 200, 200, 0, 400);
        }

    }
}
