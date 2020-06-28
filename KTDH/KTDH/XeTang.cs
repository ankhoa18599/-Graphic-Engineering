using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace KTDH
{
    public class XeTang
    {
        private Point xe;
        public XeTang(int x, int y)
        {
            xe = new Point(x, y);
        }
        public Point getXe()
        {
            return this.xe;
        }
        public void VeXeTang(Graphics g)
        {
            Point Z = Point.FakeToReal(xe.getX(), xe.getY());
            HT banhxe1 = new HT(Z.getX(), Z.getY(), 15);
            HT banhxe2 = new HT(Z.getX()+33*5, Z.getY(), 15);
            banhxe1.Midpoint_htron(g,Color.Black);
            banhxe2.Midpoint_htron(g,Color.Black);
            Elip xich = new Elip(Z.getX() + 16 * 5, Z.getY(), 14 * 5, 2 * 5);
            xich.VeElip(g,Color.Green);
            Line AB, BC, CD, DA;
            int xa, xb, xc, xd, ya, yb, yc, yd;
            xa = xe.getX()+19;
            ya = xe.getY()+18;
            xb = xa + 10;
            yb = ya;
            xc = xa + 10;
            yc = ya + 2;
            xd = xa;
            yd = ya + 2;

            Point A = Point.FakeToReal(xa, ya);
            Point B = Point.FakeToReal(xb, yb);
            Point C = Point.FakeToReal(xc, yc);
            Point D = Point.FakeToReal(xd, yd);
            AB = new Line(A.getX(), A.getY(), B.getX(), B.getY(), Color.Red);
            BC = new Line(B.getX(), B.getY(), C.getX(), C.getY(), Color.Red);
            CD = new Line(C.getX(), C.getY(), D.getX(), D.getY(), Color.Red);
            DA = new Line(A.getX(), A.getY(), D.getX(), D.getY(), Color.Red);
            AB.DDA_Line(g, Color.Red);
            CD.DDA_Line(g, Color.Red);
            BC.DDA_Line(g, Color.Red);
            DA.DDA_Line(g, Color.Red);
            xa = xe.getX() + 7;
            ya = xe.getY() + 3;
            xb = xa + 18;
            yb = ya;
            xc = xa + 18;
            yc = ya + 10;
            xd = xa;
            yd = ya + 10;
            A = Point.FakeToReal(xa, ya);
            B = Point.FakeToReal(xb, yb);
            C = Point.FakeToReal(xc, yc);
            D = Point.FakeToReal(xd, yd);
            AB = new Line(A.getX(), A.getY(), B.getX(), B.getY(), Color.Red);
            BC = new Line(B.getX(), B.getY(), C.getX(), C.getY(), Color.Red);
            CD = new Line(C.getX(), C.getY(), D.getX(), D.getY(), Color.Red);
            DA = new Line(A.getX(), A.getY(), D.getX(), D.getY(), Color.Red);
            AB.DDA_Line(g, Color.Red);
            CD.DDA_Line(g, Color.Red);
            BC.DDA_Line(g, Color.Red);
            DA.DDA_Line(g, Color.Red);
            HT nap = new HT(Z.getX() + 16 * 5, Z.getY()-13*5,7*5);
            nap.Midpoint_htron2(g, Color.BlueViolet);
        }

    }
}
