﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace KTDH
{
    public class Line
    {
        private Point Fpoint;
        private Point Lpoint;
        private Color color;
        private double hesogoc, b1;
        public int b;

        private Point Kpoint;

        public Point getFpoint()
        {
            return this.Fpoint;
        }

        public Point getLpoint()
        {
            return this.Lpoint;
        }

        public void getFpoint(Point f)
        {
            this.Fpoint = f;

        }
        public void setLpoint(Point l)
        {
            this.Lpoint = l;
        }
        public Color getColor()
        {
            return this.color;
        }

        public void setColor(Color c)
        {
            this.color = c;

        }

        public Line(int x1, int y1, int x2, int y2, Color c)
        {
            Fpoint = new Point(x1, y1);
            Lpoint = new Point(x2, y2);
            color = c;
        }
        //private void putpixel(int x, int y, Graphics grfx)
        //{
        //    if (x < 0 || x > 400 || y < 0 || y > 400) return;
        //    Pen p = new Pen(Color.Black);
        //    SolidBrush b = new SolidBrush(Color.Black);// Brush dùng để tô vùng bên trong của một hình 
        //    // Lớp Brush là một lớp Abstract • Các lớp kế thừ từ lớp Brush 
        //    //Một Solid Brush là một brush dùng để tô một vùng với một màu đơn.
        //    grfx.DrawRectangle(p, x, y, 2, 2);//        |
        //    ////////////////////////////////////---điểm click ---
        //    ////////////////////////////////////        | tô ở đây
        //    grfx.FillRectangle(b, x, y, 2, 2);

        //    grfx.DrawRectangle(p, x - 2, y - 2, 2, 2); //     tô thêm ở đây   |
        //    ////////////////////////////////////                       ---điểm click ---
        //    ////////////////////////////////////                              | tô ở đây
        //    grfx.FillRectangle(b, x - 2, y - 2, 2, 2);

        //    grfx.DrawRectangle(p, x, y - 2, 2, 2);//     tô thêm ở đây   | tô ở đây
        //    ////////////////////////////////////                   ---điểm click ---
        //    ////////////////////////////////////                         | tô ở đây
        //    grfx.FillRectangle(b, x, y - 2, 2, 2);

        //    grfx.DrawRectangle(p, x - 2, y, 2, 2);//     tô thêm ở đây   | tô ở đây
        //    ////////////////////////////////////                   ---điểm click ---
        //    ////////////////////////////////////         tô ở đây        | tô ở đây
        //    grfx.FillRectangle(b, x - 2, y, 2, 2);
        //    // và ta đã có 1 điểm pixel "fake" cấu thành từ 4 pixel nhỏ.
        //}

        //public int round(double inP)
        //{
        //    int outP;
        //    double sodu = inP % 5;
        //    if (sodu != 0)
        //    {
        //        if (sodu >= 3) outP = (int)(inP + 5 - sodu); // làm tròn lên nếu gần phía trên hơn. 278 % 5 = 3 => out 278+5-3 =280
        //        else outP = (int)(inP - sodu); // làm tròn xuống 272 % 5 = 2 => out 272 -2  =270
        //    }
        //    else outP = (int)inP; // 275 vẫn là 275
        //    if (outP > 400) outP = 400; //nếu tọa độ lớn hơn 400 thì trả về 400
        //    return outP;
        //}
        public void DDA_Line(Graphics g, Color c) // Ve duong thang co dinh dang mau
        {
            Color m = color;
            int Dx, Dy, count, temp_1, temp_2, dem = 1;
            //int temp_3, temp_4;
            Dx = Lpoint.getX() - Fpoint.getX();
            Dy = Lpoint.getY() - Fpoint.getY();
            if (Math.Abs(Dy) > Math.Abs(Dx)) count = Math.Abs(Dy);
            else count = Math.Abs(Dx);
            float delta_X, delta_Y, x, y;
            Point temp = new Point();
            count /= 5;
            if (count > 0)
            {
                delta_X = Dx;
                delta_X /= count;
                delta_Y = Dy;
                delta_Y /= count;
                x = Fpoint.getX();
                y = Fpoint.getY();
                do
                {
                    temp.setX(Point.round(x));
                    temp.setY(Point.round(y));
                    Point.putpixel(temp.getX(), temp.getY(), g, c);
                    // temp_3 = temp_1;
                    // temp_4 = temp_2;
                    x += delta_X;
                    y += delta_Y;
                    --count;
                    dem++;
                } while (count != -1);

            }
        }

        public void DDA_Linexoa(Graphics g, Color color, bool noTruc) // Ve duong thang co dinh dang mau
        {
            Color m = color;
            int Dx, Dy, count, temp_1, temp_2, dem = 1;
            //int temp_3, temp_4;
            Dx = Lpoint.getX() - Fpoint.getX();
            Dy = Lpoint.getY() - Fpoint.getY();
            if (Math.Abs(Dy) > Math.Abs(Dx)) count = Math.Abs(Dy);
            else count = Math.Abs(Dx);
            float delta_X, delta_Y, x, y;
            Point temp = new Point();
            count /= 5;
            if (count > 0)
            {
                delta_X = Dx;
                delta_X /= count;
                delta_Y = Dy;
                delta_Y /= count;
                x = Fpoint.getX();
                y = Fpoint.getY();
                do
                {
                    temp.setX(Point.round(x));
                    temp.setY(Point.round(y));
                    Point.xoapixel(temp.getX(), temp.getY(), g, color, noTruc);
                    // temp_3 = temp_1;
                    // temp_4 = temp_2;
                    x += delta_X;
                    y += delta_Y;
                    --count;
                    dem++;
                } while (count != -1);

            }
        }
        public void QuayDT()
        {
            double sin = Math.Sin(Math.PI * 60.0 / 180.0);
            double cos = Math.Cos(Math.PI * 60.0 / 180.0);
            //Tọa độ trước khi truyền vào là real.
            //Sau 2 dòng này sẽ thành fake ( thực ra cũng không cần thêm biến có điều hơi rối thôi
            Point pF = Point.RealToFake(this.Fpoint.getX(), this.Fpoint.getY());
            Point pL = Point.RealToFake(this.Lpoint.getX(), this.Lpoint.getY());
            //Quay nó :V 
            this.Fpoint.setX(Convert.ToInt32(pF.getX() * cos - sin * pF.getY()));
            this.Fpoint.setY(Convert.ToInt32(pF.getX() * sin + cos * pF.getY()));
            this.Lpoint.setX(Convert.ToInt32(pL.getX() * cos - sin * pL.getY()));
            this.Lpoint.setY(Convert.ToInt32(pL.getX() * sin + cos * pL.getY()));

            //Dổi về tọa độ Real
            this.Fpoint = Point.FakeToReal(this.Fpoint.getX(), this.Fpoint.getY());
            this.Lpoint = Point.FakeToReal(this.Lpoint.getX(), this.Lpoint.getY());
        }
        public void doiXungO()
        {
            this.Fpoint.doiXungDiemO();
            this.Lpoint.doiXungDiemO();
        }
        public void doiXungOx()
        {
            this.Fpoint.doiXungTrucOx();
            this.Lpoint.doiXungTrucOx();
        }
        public void doiXungOy()
        {
            this.Fpoint.doiXungTrucOy();
            this.Lpoint.doiXungTrucOy();
        }
        public void DDA_Linexoa(Graphics g, Color color) // Ve duong thang co dinh dang mau
        {
            Color m = color;
            int Dx, Dy, count, temp_1, temp_2, dem = 1;
            //int temp_3, temp_4;
            Dx = Lpoint.getX() - Fpoint.getX();
            Dy = Lpoint.getY() - Fpoint.getY();
            if (Math.Abs(Dy) > Math.Abs(Dx)) count = Math.Abs(Dy);
            else count = Math.Abs(Dx);
            float delta_X, delta_Y, x, y;
            Point temp = new Point();
            count /= 5;
            if (count > 0)
            {
                delta_X = Dx;
                delta_X /= count;
                delta_Y = Dy;
                delta_Y /= count;
                x = Fpoint.getX();
                y = Fpoint.getY();
                do
                {
                    temp.setX(Point.round(x));
                    temp.setY(Point.round(y));
                    Point.xoapixel(temp.getX(), temp.getY(), g, color);
                    // temp_3 = temp_1;
                    // temp_4 = temp_2;
                    x += delta_X;
                    y += delta_Y;
                    --count;
                    dem++;
                } while (count != -1);

            }
        }
        public Line TinhTienDT(Line AB, int x, int y)
        {
            int xA = AB.getFpoint().getX() + x * 5;
            int yA = AB.getFpoint().getY() + y * -5;
            int xB = AB.getLpoint().getX() + x * 5;
            int yB = AB.getLpoint().getY() + y * -5;

            Point A = new Point(xA, yA);
            Point B = new Point(xB, yB);

            Line dt = new Line(A.getX(), A.getY(), B.getX(), B.getY(), Color.Black);

            return dt;
        }
        public void TiLeSx(double Sx)
        {
            int Dx0 = Lpoint.getX() - Fpoint.getX();
            double Dx = Dx0 * Sx;
            double dentax = (Dx - Dx0);
            this.Fpoint.setX(Point.round(Math.Round(Fpoint.getX() - dentax / 2)));
            this.Lpoint.setX(Point.round(Math.Round(Lpoint.getX() + dentax / 2)));
        }
        public void TileSy(double Sy)
        {
            int Dy0 = Lpoint.getY() - Fpoint.getY();
            double Dy = Dy0 * Sy;
            double dentay = (Dy - Dy0);
            this.Fpoint.setY(Point.round(Math.Round(Fpoint.getY() - dentay / 2)));
            this.Lpoint.setY(Point.round(Math.Round(Lpoint.getY() + dentay / 2)));
        }

        public void Ve_Net_Dut(Graphics g)
        {
            Color m = color;
            int Dx, Dy, count, temp_1, temp_2, dem = 0;
            //int temp_3, temp_4;
            Dx = Lpoint.getX() - Fpoint.getX();
            Dy = Lpoint.getY() - Fpoint.getY();
            if (Math.Abs(Dy) > Math.Abs(Dx)) count = Math.Abs(Dy);
            else count = Math.Abs(Dx);
            float delta_X, delta_Y, x, y;
            Point temp = new Point();
            count /= 5;
            if (count > 0)
            {
                delta_X = Dx;
                delta_X /= count;
                delta_Y = Dy;
                delta_Y /= count;
                x = Fpoint.getX();
                y = Fpoint.getY();
                do
                {
                    if (dem == 3)
                    {
                        x += delta_X;
                        y += delta_Y;
                        --count;
                        dem = 0;
                        continue;
                    }
                    //if(x%4 == 0)
                    //{
                    //    x += delta_X;
                    //    y += delta_Y;
                    //    --count;
                    //    continue;
                    //}
                    temp.setX(Point.round(x));
                    temp.setY(Point.round(y));
                    Point.putpixel(temp.getX(), temp.getY(), g, m);
                    // temp_3 = temp_1;
                    // temp_4 = temp_2;
                    x += delta_X;
                    y += delta_Y;
                    --count;
                    dem++;
                } while (count != -1);

            }
        }
        public void TiLe(double Sx,double Sy)
        {
            this.Fpoint.TileDiem(Sx, Sy);
            this.Lpoint.TileDiem(Sx, Sy);
        }
        public void TinhTien(double x, double y)
        {
            Fpoint.TinhTienDiem(x, y);
            Lpoint.TinhTienDiem(x, y);
        }
        public void RealtoFake()
        {
            Fpoint = Point.RealToFake(Fpoint.getX(), Fpoint.getY());
            Lpoint = Point.RealToFake(Lpoint.getX(), Lpoint.getY());
        }
        public void FaketoReal()
        {
            Fpoint = Point.FakeToReal(Fpoint.getX(), Fpoint.getY());
            Lpoint = Point.FakeToReal(Lpoint.getX(), Lpoint.getY());
        }
    }
}

