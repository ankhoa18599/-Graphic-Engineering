using System;
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
        public void DDA_Line(Graphics g) // Ve duong thang co dinh dang mau
        {
            Color m = color;
            int Dx, Dy, count, temp_1, temp_2, dem = 1;
            //int temp_3, temp_4;
            Dx = Lpoint.getX() - Fpoint.getX();
            Dy = Lpoint.getY() - Fpoint.getY();
            if (Math.Abs(Dy) > Math.Abs(Dx)) count = Math.Abs(Dy);
            else count = Math.Abs(Dx);
            float delta_X, delta_Y, x,y;
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
                    Point.putpixel(temp.getX(), temp.getY(), g);
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
            this.Fpoint = Point.FakeToReal(this.Fpoint.getX(),this.Fpoint.getY());
            this.Lpoint = Point.FakeToReal(this.Lpoint.getX(), this.Lpoint.getY());
        }

      
    }
}
