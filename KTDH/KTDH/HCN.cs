using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace KTDH
{
    class HCN
    {
        private Point A, B, C, D;
        public void setA(Point a) { A = a; }
        public void setB(Point b) { A = b; }
        public void setC(Point c) { A = c; }
        public void setD(Point d) { A = d; }
        public Point getA() { return this.A; }
        public Point getB() { return this.B; }
        public Point getC() { return this.C; }
        public Point getD() { return this.D; }
        public HCN(Point A,Point B,Point C,Point D)
        {
            this.A = new Point(A);
            this.B= new Point(B);
            this.C = new Point(C);
            this.D = new Point(D);
        }
        public HCN() { }
        public void Draw(Graphics g, Color c)
        {
            Point Atemp = Point.FakeToReal(A.getX(), A.getY());
            Point Btemp = Point.FakeToReal(B.getX(), B.getY());
            Point Ctemp = Point.FakeToReal(C.getX(), C.getY());
            Point Dtemp = Point.FakeToReal(D.getX(), D.getY());
            Line AB = new Line(Atemp.getX(), Atemp.getY(), Btemp.getX(), Btemp.getY(), c);
            Line BC = new Line(Btemp.getX(), Btemp.getY(), Ctemp.getX(), Ctemp.getY(), c);
            Line DC = new Line(Dtemp.getX(), Dtemp.getY(), Ctemp.getX(), Ctemp.getY(), c);
            Line AD = new Line(Atemp.getX(), Atemp.getY(), Dtemp.getX(), Dtemp.getY(), c);
            AB.DDA_Line(g, c);
            BC.DDA_Line(g, c);
            DC.DDA_Line(g, c);
            AD.DDA_Line(g, c);
        }
        public void TiLe(double Sx, double Sy, double GocX0, double GocY0)
        {
            //Gốc tọa độ sau khi tỉ lệ
            double GocX = GocX0 * Sx;
            double GocY = GocY0 * Sy;
            //Độ lệch so với gốc tọa độ cũ
            double DentaX = Math.Abs(GocX - GocX0);
            double DentaY = Math.Abs(GocY - GocY0);
            //Tỉ lệ các điểm của hình
            this.A.TileDiem(Sx, Sy);
            this.B.TileDiem(Sx, Sy);
            this.C.TileDiem(Sx, Sy);
            this.D.TileDiem(Sx, Sy);
            //Nếu phóng to thì dịch tâm ngược lại, phóng nhỏ thì dịch tăng
            if (Sx > 1) DentaX = -DentaX;
            if (Sy > 1) DentaY = -DentaY;
            //// Dịch chuyển các điểm
            this.A.TinhTienDiem(DentaX, DentaY);
            this.B.TinhTienDiem(DentaX, DentaY);
            this.C.TinhTienDiem(DentaX, DentaY);
            this.D.TinhTienDiem(DentaX, DentaY);
        }
    }
}
