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
        public void putpixel(Graphics grfx, Color color)
        {
            if (X < 0 || X > 400 || Y < 0 || Y > 400) return;
            Pen p = new Pen(color);
            SolidBrush b = new SolidBrush(color);
            grfx.FillRectangle(b, X - 2, Y - 2, 5, 5);
        }
        public void xoapixel(Graphics grfx, Color color,bool noToado)
        {
            if (X < 0 || X > 400 || Y < 0 || Y > 400) return;
            Pen p = new Pen(color);
            SolidBrush b = new SolidBrush(color);// Brush dùng để tô vùng bên trong của một hình 
            SolidBrush b3 = new SolidBrush(Color.White);
            grfx.FillRectangle(b, X - 2, Y - 2, 5, 5);
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        if ((X + i - 2) % 5 != 0 && (Y + j - 2) % 5 != 0)
            //            grfx.FillRectangle(b, X + i - 2, Y + j - 2, 1, 1);
            //        else grfx.FillRectangle(b3, X + i - 2, Y + j - 2, 1, 1);
            //    }
            //}
        }
        public static void putpixel(int x, int y, Graphics grfx,Color color)
        {
            if (x < 0 || x > 400 || y < 0 || y > 400) return;
            Pen p = new Pen(color);
            SolidBrush b = new SolidBrush(color);// Brush dùng để tô vùng bên trong của một hình 
            // Lớp Brush là một lớp Abstract • Các lớp kế thừ từ lớp Brush 
            //Một Solid Brush là một brush dùng để tô một vùng với một màu đơn.
           // grfx.DrawRectangle(p, x, y, 2, 2);//        |
            ////////////////////////////////////---điểm click ---
            ////////////////////////////////////        | tô ở đây
            //grfx.FillRectangle(b, x, y, 2, 2);

            //grfx.DrawRectangle(p, x - 2, y - 2, 2, 2); //     tô thêm ở đây   |
            ////////////////////////////////////                       ---điểm click ---
            ////////////////////////////////////                              | tô ở đây
            grfx.FillRectangle(b, x - 2, y - 2, 5, 5);

            //grfx.DrawRectangle(p, x, y - 2, 2, 2);//     tô thêm ở đây   | tô ở đây
            ////////////////////////////////////                   ---điểm click ---
            ////////////////////////////////////                         | tô ở đây
            //grfx.FillRectangle(b, x, y - 2, 2, 2);

            //grfx.DrawRectangle(p, x - 2, y, 2, 2);//     tô thêm ở đây   | tô ở đây
            ////////////////////////////////////                   ---điểm click ---
            ////////////////////////////////////         tô ở đây        | tô ở đây
            //grfx.FillRectangle(b, x - 2, y, 2, 2);
            // và ta đã có 1 điểm pixel "fake" cấu thành từ 4 pixel nhỏ.
           // test grfx.FillRectangle(b, x - 10, y, 5, 5);
        }
        public static void xoapixel(int x, int y, Graphics grfx, Color color)
        {
            if (x < 0 || x > 400 || y < 0 || y > 400) return;
            Pen p = new Pen(color);
            SolidBrush b = new SolidBrush(color);// Brush dùng để tô vùng bên trong của một hình 
            SolidBrush b2 = new SolidBrush(Color.Black);
            SolidBrush b3 = new SolidBrush(Color.White);
            for (int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    if ((x + i - 2) % 5 != 0 && (y + j - 2) % 5 != 0)
                    grfx.FillRectangle(b, x + i - 2, y + j - 2, 1, 1);
                    else if((x+i-2)==200 || (y + j - 2) == 200)
                    grfx.FillRectangle(b2, x + i - 2, y + j - 2, 1, 1);
                    else grfx.FillRectangle(b3, x + i - 2, y + j - 2, 1, 1);
                }
            }    
        }
        public static void xoapixel(int x, int y, Graphics grfx, Color color,bool noToado)
        {
            if (x < 0 || x > 400 || y < 0 || y > 400) return;
            Pen p = new Pen(color);
            SolidBrush b = new SolidBrush(color);// Brush dùng để tô vùng bên trong của một hình 
            SolidBrush b3 = new SolidBrush(Color.White);
            grfx.FillRectangle(b, x - 2, y - 2, 5, 5);
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {

            //        if ((x + i - 2) % 5 != 0 && (y + j - 2) % 5 != 0)
            //            grfx.FillRectangle(b, x + i - 2, y + j - 2, 1, 1);
            //        else grfx.FillRectangle(b3, x + i - 2, y + j - 2, 1, 1);
            //    }
            //}
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
            //if (outP > 400) outP = 400; //nếu tọa độ lớn hơn 400 thì trả về 400
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
        public void doiXungDiemO()
        {
            Point real = RealToFake(this.X, this.Y);
            real.X = -1 * real.X;
            real.Y = -1 * real.Y;
            real = FakeToReal(real.X, real.Y);
            this.X = real.X;
            this.Y = real.Y;

        }
        public void doiXungTrucOx()
        {
            Point real = RealToFake(this.X, this.Y);
            real.Y = -1 * real.Y;
            real = FakeToReal(real.X, real.Y);
            this.X = real.X;
            this.Y = real.Y;
        }
        public void doiXungTrucOy()
        {
            Point real = RealToFake(this.X, this.Y);
            real.X = -1 * real.X;
            real = FakeToReal(real.X, real.Y);
            this.X = real.X;
            this.Y = real.Y;
        }
        public void TileDiem(double Sx, double Sy)
        {
            this.X = (int)Math.Round(this.X * Sx);
            this.Y = (int)Math.Round(this.Y * Sy);
        }
        public void TinhTienDiem(double dx,double dy)
        {
            dx = Math.Round(dx);
            dy = Math.Round(dy);
            this.X = this.X + (int)dx;
            this.Y = this.Y + (int)dy;
        }
    }
}
