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

        public void setFpoint(Point f)
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
                    System.Threading.Thread.Sleep(20);
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

        public void DDA_Line_ngat(Graphics g) // Ve duong thang đứt co dinh dang mau
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

        public void DDA_Line_ngat_1cham(Graphics g) // Ve duong thang 1 cham giữa co dinh dang mau
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
                        Point.putpixel(temp.getX() + (int)(2 * delta_X), temp.getY() + (int)(2 * delta_Y), g);
                        x += 3 * delta_X;
                        if (x > 400 || x > Lpoint.getX())
                        {
                            break;
                        }
                        y += 3 * delta_Y;
                        if (y > 400 || y > Lpoint.getY())
                        {
                            break;
                        }
                        count -= 3;
                        dem = 0;
                        continue;
                    }
                    //if (x % 6 == 4 || x % 6 == 0)
                    //{
                    //    x += delta_X;
                    //    y += delta_Y;
                    //    --count;
                    //    continue;
                    //}
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
        public void DDA_Line_ngat_2cham(Graphics g) // Ve duong thang 2 cham giữa co dinh dang mau
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
                        Point.putpixel(temp.getX() + (int)(2 * delta_X), temp.getY() + (int)(2 * delta_Y), g); // = -
                        Point.putpixel(temp.getX() + (int)(4 * delta_X), temp.getY() + (int)(4 * delta_Y), g);//  = - -
                        x += 5 * delta_X; //giãn X ra 5 pixel
                        if (x > 400 || x > Lpoint.getX())
                        {
                            break; // nếu vượt biên hoặc lớn hơn điểm cuối thì ngắt
                        }
                        y += 5 * delta_Y;
                        if (y > 400 || y > Lpoint.getY())
                        {
                            break;
                        }
                        count -= 5;
                        dem = 0;
                        continue;
                    }
                    //if (x % 8 == 4 || x % 8 == 6 || x % 8 == 0)
                    //{
                    //    x += delta_X;
                    //    y += delta_Y;
                    //    --count;
                    //    continue;
                    //}
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

        public void DrawArrow(Graphics g)
        {
            //tạo 2 điểm 2 bên tam giác mũi tên
            Point MT1 = new Point();
            Point MT2 = new Point();
            //tọa độ 2 điểm 2 bên tam giác mũi tên
            double x1=0, x2=0, y1=0, y2=0;
            //2 đoạn thẳng để vẽ mũi tên
            Line Arrow1, Arrow2;
            //Khoảng cách dy dx của 2 điểm 2 bên tam giác ở mũi tên
            double Dx1, Dy1, Dx2, Dy2;

            //Khoảng cách DX,DY
            double ABDx = Math.Abs(this.getLpoint().getX() - this.getFpoint().getX());
            double ABDy = Math.Abs(this.getLpoint().getY() - this.getFpoint().getY());
            //Độ dài đường thẳng AB
            double DAB = Math.Sqrt(Math.Pow(ABDx, 2) + Math.Pow(ABDy, 2));

            //chiều cao và cạnh đáy,góc tam giác cân (mũi tên 40-20)
            double HArrTri = 40;//DAB / 5;   //40;  //DAB / 5;  
            double DayArrTri = 20; //HArrTri/2;  //1.6;
            double CanhBArrTri = Math.Sqrt(Math.Pow(HArrTri, 2) + Math.Pow(DayArrTri / 2, 2));
            double G_Anpha = Math.Atan(DayArrTri / 2 / HArrTri) * 2 * 180 / Math.PI;
            // Tính chất tam giác cân;
            double G_Anpha1, G_Anpha2;
            G_Anpha1 = G_Anpha2 = G_Anpha / 2;

            if (ABDx == 0)
            {
                Dx1 = Dx2 = DayArrTri / 2;
                Dy1 = Dy2 = HArrTri;
                if (this.getLpoint().getY() > this.getFpoint().getY())
                    Dy1 = -Dy1;
                x1 = Math.Round(this.getLpoint().getX() - Dx1);
                x2 = Math.Round(this.getLpoint().getX() + Dx2);
                y1 = Math.Round(this.getLpoint().getY() + Dy1);
                y2 = y1;
            }
            else if (ABDy == 0)
            {
                Dx1 = Dx2 = HArrTri;
                Dy1 = Dy2 = DayArrTri / 2;
                if (this.getLpoint().getX() > this.getFpoint().getX())
                    Dx1 = -Dx1;
                x1 = Math.Round(this.getLpoint().getX() + Dx1);
                x2 = x1;
                y1 = Math.Round(this.getLpoint().getY() + Dy1);
                y2 = Math.Round(this.getLpoint().getY() - Dy2);
            }
            else
            {
                //Góc B1 &B2
                double G_B1 = Math.Atan(ABDy / ABDx) * 180 / Math.PI;
                double G_B2 = Math.Atan(ABDx / ABDy) * 180 / Math.PI;

                //Góc Beta
                double G_Beta1, G_Beta2;
                G_Beta1 = Math.Abs(G_B1 - G_Anpha1);
                G_Beta2 = Math.Abs(G_B2 - G_Anpha2);

                Dy1 = Math.Sin(G_Beta1 * Math.PI / 180) * CanhBArrTri;
                Dx1 = Math.Sqrt(Math.Pow(CanhBArrTri, 2) - Math.Pow(Dy1, 2));
                Dx2 = Math.Sin(G_Beta2 * Math.PI / 180) * CanhBArrTri;
                Dy2 = Math.Sqrt(Math.Pow(CanhBArrTri, 2) - Math.Pow(Dx2, 2));

                if (G_Anpha1 > G_B1 && G_Anpha2 > G_B2)
                {
                    //Dx1 = Dx1;
                    Dx2 = -Dx2;
                    Dy1 = -Dy1;
                    //Dy2 = Dy2;
                }
                else if (G_Anpha1 < G_B1 && G_Anpha2 < G_B2)
                {
                    // Dx1 = Dx1;
                    // Dx2 = Dx2;
                    // Dy1 = Dy1;
                    // Dy2 = Dy2;
                }
                else if (G_Anpha1 > G_B1 && G_Anpha2 < G_B2)
                {
                    // Dx1 = Dx1;
                    // Dx2 = Dx2;
                    Dy1 = -Dy1;
                    // Dy2 = Dy2;
                }
                else if (G_Anpha1 < G_B1 && G_Anpha2 > G_B2)
                {
                    // Dx1 = Dx1;
                    Dx2 = -Dx2;
                    // Dy1 = Dy1;
                    // Dy2 = Dy2;
                }

                if (this.getLpoint().getX() > this.getFpoint().getX() && this.getLpoint().getY() < this.getFpoint().getY())
                {
                    Dx1 = -Dx1;
                    Dx2 = -Dx2;
                }
                else if (this.getLpoint().getX() > this.getFpoint().getX() && this.getLpoint().getY() > this.getFpoint().getY())
                {
                    Dx1 = -Dx1;
                    Dx2 = -Dx2;
                    Dy1 = -Dy1;
                    Dy2 = -Dy2;
                }
                else if (this.getLpoint().getX() < this.getFpoint().getX() && this.getLpoint().getY() > this.getFpoint().getY())
                {
                    Dy1 = -Dy1;
                    Dy2 = -Dy2;
                }

                //làm tròn sau khi tính toán khoảng cách để lấy tọa độ nguyên
                x1 = Math.Round(this.getLpoint().getX() + Dx1);
                y1 = Math.Round(this.getLpoint().getY() + Dy1);
                x2 = Math.Round(this.getLpoint().getX() + Dx2);
                y2 = Math.Round(this.getLpoint().getY() + Dy2);
            }
            //Làm tròn để khớp với hệ tọa độ
            x1 = Point.round(x1);
            x2 = Point.round(x2);
            y1 = Point.round(y1);
            y2 = Point.round(y2);

            MT1.setPoint((int)x1, (int)y1);
            MT2.setPoint((int)x2, (int)y2);

            Arrow1 = new Line(this.getLpoint().getX(), this.getLpoint().getY(), MT1.getX(), MT1.getY(), Color.HotPink);
            Arrow2 = new Line(this.getLpoint().getX(), this.getLpoint().getY(), MT2.getX(), MT2.getY(), Color.HotPink);

            Arrow1.DDA_Line(g);
            Arrow2.DDA_Line(g);
        }
    }
}
