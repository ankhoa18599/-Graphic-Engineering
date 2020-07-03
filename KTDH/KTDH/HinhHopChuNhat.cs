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
    public partial class HinhHopChuNhat : Form
    {
        public Line AB, BC, CD, DA, EF, FG, GH, HE, AE, BF, CG, DH;
        public Boolean check = false;
        private void button1_Click(object sender, EventArgs e)
        {
            check = true;
            //nam code
            //Su dung phep chieu Cavalier
            Double a = Math.Sqrt(2.0) / 2;
            int x, y, z, cd, cr, cc;
            
            //Hinh hop co 8 diem
            int xA, xB, xC, xD, xE, xF, xG, xH;
            int yA, yB, yC, yD, yE, yF, yG, yH;

            x = Int32.Parse(numericUpDown1.Value.ToString());
            y = Int32.Parse(numericUpDown2.Value.ToString());
            z = Int32.Parse(numericUpDown3.Value.ToString());
            cd = Int32.Parse(numericUpDown4.Value.ToString());
            cr= Int32.Parse(numericUpDown5.Value.ToString());
            cc = Int32.Parse(numericUpDown6.Value.ToString());

            if (cd == 0 || cr == 0 || cc == 0)
            {
                MessageBox.Show("Sai thông số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //diem ban dau nam o truc duong x
                //truc am y
                xA = (int)((x + cd / 2) - (y + cr / 2) * a);
                yA = (int)(z - (y + cr / 2) * a);

                //yA = yB
                //truc am x, am y
                xB = (int)((x - cd / 2) - (y + cr / 2) * a);
                yB = yA;

                //truc am x, truc duong y
                xC = (int)((x - cd / 2) - (y - cr / 2) * a);
                yC = (int)(z - (y - cr / 2) * a);

                //yC = yD
                //truc duong x, duong y
                xD = (int)((x + cd / 2) - (y - cr / 2) * a);
                yD = yC;

                /////////////////////
                // xE = xA, yE=yA + chieucao
                xE = (int)((x + cd / 2) - (y + cr / 2) * a);
                yE = (int)(z+cc - (y + cr / 2) * a);

                //Tuong tu diem B
                xF = (int)((x - cd / 2) - (y + cr / 2) * a);
                yF = (int)(z + cc - (y + cr / 2) * a);

                //Tuong tu diem C
                xG = (int)((x - cd / 2) - (y - cr / 2) * a); 
                yG = (int)(z + cc - (y - cr / 2) * a);

                //Tuong tu diem D
                xH = (int)((x + cd / 2) - (y - cr / 2) * a); 
                yH = (int)(z + cc - (y - cr / 2) * a);

                Point A = Point.FakeToReal(xA, yA);
                Point B = Point.FakeToReal(xB, yB);
                Point C = Point.FakeToReal(xC, yC);
                Point D = Point.FakeToReal(xD, yD);
                Point E = Point.FakeToReal(xE, yE);
                Point F = Point.FakeToReal(xF, yF);
                Point G = Point.FakeToReal(xG, yG);
                Point H = Point.FakeToReal(xH, yH);

                AB = new Line(A.getX(), A.getY(), B.getX(), B.getY(), Color.Black);
                BC = new Line(B.getX(), B.getY(), C.getX(), C.getY(), Color.Black);
                CD = new Line(C.getX(), C.getY(), D.getX(), D.getY(), Color.Black);
                DA = new Line(D.getX(), D.getY(), A.getX(), A.getY(), Color.Black);
                EF = new Line(E.getX(), E.getY(), F.getX(), F.getY(), Color.Black);
                FG = new Line(F.getX(), F.getY(), G.getX(), G.getY(), Color.Black);
                GH = new Line(G.getX(), G.getY(), H.getX(), H.getY(), Color.Black);
                HE = new Line(H.getX(), H.getY(), E.getX(), E.getY(), Color.Black);
                AE = new Line(A.getX(), A.getY(), E.getX(), E.getY(), Color.Black);
                BF = new Line(B.getX(), B.getY(), F.getX(), F.getY(), Color.Black);
                CG = new Line(C.getX(), C.getY(), G.getX(), G.getY(), Color.Black);
                DH = new Line(D.getX(), D.getY(), H.getX(), H.getY(), Color.Black);

                this.Close();
            }
        }

        public HinhHopChuNhat()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
