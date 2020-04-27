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
    public partial class HinhChuNhat : Form
    {
        public int xA, yA, a, b; //a dài, b rộng
        public Line AB, BC, CD, AD;

        private void jbntVeHCN_Click(object sender, EventArgs e)
        {
            xA = Int32.Parse(numericUpDown1.Value.ToString());
            yA = Int32.Parse(numericUpDown2.Value.ToString());
            a = Int32.Parse(numericUpDown3.Value.ToString());
            b = Int32.Parse(numericUpDown4.Value.ToString());
            int xa, xb, xc, xd, ya, yb, yc, yd;
            xa = xA;
            ya = yA;
            xb = xa + a;
            yb = ya;
            xc = xa + a;
            yc = ya + b;
            xd = xa;
            yd = ya + b;

            Point A = Point.FakeToReal(xa, ya);
            Point B = Point.FakeToReal(xb, yb);
            Point C = Point.FakeToReal(xc, yc);
            Point D = Point.FakeToReal(xd, yd);

            AB = new Line(A.getX(), A.getY(), B.getX(), B.getY(), Color.Red);
            BC = new Line(B.getX(), B.getY(), C.getX(), C.getY(), Color.Red);
            CD = new Line(C.getX(), C.getY(), D.getX(), D.getY(), Color.Red);
            AD = new Line(A.getX(), A.getY(), D.getX(), D.getY(), Color.Red);
            this.Close();
        }

        private void HinhChuNhat_Load(object sender, EventArgs e)
        {

        }

        public HinhChuNhat()
        {
            InitializeComponent();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
