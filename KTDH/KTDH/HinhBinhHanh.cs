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
    public partial class HinhBinhHanh : Form
    {
        public int xa, ya, xb,yb,xc,yc,xd,yd;
        public Line AB, BC, CD, AD;
        public Boolean checkchange = false;

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Ve(object sender, EventArgs e)
        {
            xa = Int32.Parse(numericUpDown1.Value.ToString());
            ya = Int32.Parse(numericUpDown2.Value.ToString());
            xb = Int32.Parse(numericUpDown3.Value.ToString());
            yb = Int32.Parse(numericUpDown4.Value.ToString());
            xc = Int32.Parse(numericUpDown5.Value.ToString());
            yc = Int32.Parse(numericUpDown6.Value.ToString());
            if ((xa == xb && ya == yb) || (xa == xc && ya == yc) || (xb == xc && yb == yc))
            {
                MessageBox.Show("Sai thông số đầu vào", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                xd = xc - xb + xa;
                yd = yc - yb + ya;

                Point A = Point.FakeToReal(xa, ya);
                Point B = Point.FakeToReal(xb, yb);
                Point C = Point.FakeToReal(xc, yc);
                Point D = Point.FakeToReal(xd, yd);

                AB = new Line(A.getX(), A.getY(), B.getX(), B.getY(), Color.Red);
                BC = new Line(B.getX(), B.getY(), C.getX(), C.getY(), Color.Red);
                CD = new Line(C.getX(), C.getY(), D.getX(), D.getY(), Color.Red);
                AD = new Line(A.getX(), A.getY(), D.getX(), D.getY(), Color.Red);

                this.checkchange = true;
                this.Close();
            }
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

       
        public HinhBinhHanh()
        {
            InitializeComponent();
        }
    }
}
