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
    public partial class HinhVuong : Form
    {
        public int xA, yA;
        public int doDai;
        public Line AB, BC, CD, AD;
        public Boolean checkchange = false;
        public HinhVuong()
        {
            InitializeComponent();
        }

        private void jbtnVe_Click(object sender, EventArgs e)
        {
            xA = Int32.Parse(numericUpDown1.Value.ToString());
            yA = Int32.Parse(numericUpDown2.Value.ToString());
            doDai = Int32.Parse(numericUpDown3.Value.ToString());
            int xa, xb, xc, xd, ya, yb, yc, yd;
            xa = xA;
            ya = yA;
            xb = xa + doDai;
            yb = ya;
            xc = xa + doDai;
            yc = ya + doDai;
            xd = xa;
            yd = ya + doDai;
            Point A = Point.FakeToReal(xa, ya);
            Point B = Point.FakeToReal(xb, yb);
            Point C = Point.FakeToReal(xc, yc);
            Point D = Point.FakeToReal(xd, yd);
            // MessageBox.Show(a.ToString());
            AB = new Line(A.getX(), A.getY(), B.getX(), B.getY(), Color.Red);
            BC = new Line(B.getX(), B.getY(), C.getX(), C.getY(), Color.Red);
            CD = new Line(C.getX(), C.getY(), D.getX(), D.getY(), Color.Red);
            AD = new Line(A.getX(), A.getY(), D.getX(), D.getY(), Color.Red);
            this.checkchange = true;
            this.Close();
        }
    }
}
