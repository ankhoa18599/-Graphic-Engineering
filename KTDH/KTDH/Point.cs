using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace KTDH
{
    public class Point
    {
        private int X;
        private int Y;
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public Point(Point a)
        {
            this.X = a.X;
            this.Y = a.Y;
        }
        public Point() { }
        public int getX() { return this.X; }
        public int getY() { return this.Y; }
        public void setX(int value) { this.X = value; }
        public void setY(int value) { this.Y = value; }
        public void setPoint(int x, int y)
        {
            setX(x); setY(y);
        }
        public static void putpixel(int x, int y, Graphics grfx)
        {
            if (x < 0 || x > 400 || y < 0 || y > 400) return;
            Pen p = new Pen(Color.Black);
            SolidBrush b = new SolidBrush(Color.Black);// Brush dùng để tô vùng bên trong của một hình 
            // Lớp Brush là một lớp Abstract • Các lớp kế thừ từ lớp Brush 
            //Một Solid Brush là một brush dùng để tô một vùng với một màu đơn.
            grfx.DrawRectangle(p, x, y, 2, 2);//        |
            ////////////////////////////////////---điểm click ---
            ////////////////////////////////////        | tô ở đây
            grfx.FillRectangle(b, x, y, 2, 2);

            grfx.DrawRectangle(p, x - 2, y - 2, 2, 2); //     tô thêm ở đây   |
            ////////////////////////////////////                       ---điểm click ---
            ////////////////////////////////////                              | tô ở đây
            grfx.FillRectangle(b, x - 2, y - 2, 2, 2);

            grfx.DrawRectangle(p, x, y - 2, 2, 2);//     tô thêm ở đây   | tô ở đây
            ////////////////////////////////////                   ---điểm click ---
            ////////////////////////////////////                         | tô ở đây
            grfx.FillRectangle(b, x, y - 2, 2, 2);

            grfx.DrawRectangle(p, x - 2, y, 2, 2);//     tô thêm ở đây   | tô ở đây
            ////////////////////////////////////                   ---điểm click ---
            ////////////////////////////////////         tô ở đây        | tô ở đây
            grfx.FillRectangle(b, x - 2, y, 2, 2);
            // và ta đã có 1 điểm pixel "fake" cấu thành từ 4 pixel nhỏ.
        }
        public static int round(double inP)
        {
            int outP;
            double sodu = inP % 5;
            if (sodu != 0)
            {
                if (sodu >= 3) outP = (int)(inP + 5 - sodu); // làm tròn lên nếu gần phía trên hơn. 278 % 5 = 3 => out 278+5-3 =280
                else outP = (int)(inP - sodu); // làm tròn xuống 272 % 5 = 2 => out 272 -2  =270
            }
            else outP = (int)inP; // 275 vẫn là 275
            if (outP > 400) outP = 400; //nếu tọa độ lớn hơn 400 thì trả về 400
            return outP;
        }
        public void QuayDiem()
        {
            double sin = Math.Sin(Math.PI * 60.0 / 180.0);
            double cos = Math.Cos(Math.PI * 60.0 / 180.0);
            Point p;
            p = Point.RealToFake(this.X, this.Y);

            this.X = Convert.ToInt32(p.getX() * cos - sin * p.getY());
            this.Y = Convert.ToInt32(p.getX() * sin + cos * p.getY());

            p = Point.FakeToReal(this.X, this.Y);
            this.X = p.getX();
            this.Y = p.getY();
        }
        public Point TinhTienDiem(Point A, int x, int y)
        {
            int xA = A.getX() + x * 5;
            int yA = A.getY() + y * -5;

            Point x1 = new Point(xA, yA);
            return x1;
        }
        public static Point RealToFake(int x, int y)//lon ra nho
        {
            return new Point(x / 5 - 40, 40 - y / 5);//voi x va y deu chia het cho 5
        }
        public static Point FakeToReal(int x, int y)//nho ra lon
        {

            return new Point((x + 40) * 5, (40 - y) * 5);
        }
    }
}
