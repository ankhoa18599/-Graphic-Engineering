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
    public partial class HinhTamGiac : Form
    {
        public int xA, yA, cao, rong; // dai cạnh, rộng đáy
        public Line AB, BC, AC;
        public Boolean checkchange = false;
        private void jbntVeHTG_Click(object sender, EventArgs e)
        {
            xA = Int32.Parse(ToadoXa.Value.ToString());
            yA = Int32.Parse(ToadoYa.Value.ToString());
            cao = Int32.Parse(ChieuCao.Value.ToString());
            rong = Int32.Parse(RongDay.Value.ToString());
            int xa, xb, xc, ya, yb, yc;
            xa = xA;
            ya = yA;
            xb = xa + rong;
            yb = ya;
            xc = xa + rong/2;
            yc = ya + cao;

            Point A = Point.FakeToReal(xa, ya);
            Point B = Point.FakeToReal(xb, yb);
            Point C = Point.FakeToReal(xc, yc);

            AB = new Line(A.getX(), A.getY(), B.getX(), B.getY(), Color.Red);
            BC = new Line(B.getX(), B.getY(), C.getX(), C.getY(), Color.Red);
            AC = new Line(C.getX(), C.getY(), A.getX(), A.getY(), Color.Red);
            this.checkchange = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        
        public HinhTamGiac()
        {
            InitializeComponent();
        }
    }
}
