using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Linq;
using System.Text;

namespace KTDH
{

    public class Elip
    {
        public Point tam;
        public int a, b;

        public Elip(int x, int y, int a, int b)
        {
            this.tam = new Point(x, y);
            this.a = a;
            this.b = b;
        }

        //Hàm put4pixel để vẽ elip(hàm trong slice word của GV)
        public void put4pixel(int x, int y, int kx, int ky, Graphics g,Color color)
        {
            Point.putpixel(kx + x, ky + y, g,color);
            Point.putpixel(kx - x, ky + y, g,color);
            Point.putpixel(kx + x, ky - y, g,color);
            Point.putpixel(kx - x, ky - y, g,color);
        }
        public void put4pixelxoa(int x, int y, int kx, int ky, Graphics g, Color color)
        {
            Point.xoapixel(kx + x, ky + y, g, color);
            Point.xoapixel(kx - x, ky + y, g, color);
            Point.xoapixel(kx + x, ky - y, g, color);
            Point.xoapixel(kx - x, ky - y, g, color);
        }

        public void VeElip(Graphics g,Color color)
        {
            int x, y, cx, cy, a, b;
            cx = tam.getX(); cy = tam.getY();
            a = this.a; b = this.b;

            x = 0; y = b;
            int A, B;
            A = a * a;
            B = b * b;
            double p = B + A / 4 - A * b;
            x = 0;
            y = b;
            int Dx = 0;
            int Dy = 2 * A * y;
            put4pixel(x, y, cx, cy, g,color);

            while (Dx < Dy)
            {
                x++;
                Dx += 2 * B;
                if (p < 0)
                    p += B + Dx;
                else
                {
                    y--;
                    Dy -= 2 * A;
                    p += B + Dx - Dy;
                }
               
                if (x % 5 == 0) put4pixel(x, Point.round(y), cx, cy, g,color);


            }
            p = Math.Round(B * (x + 0.5f) * (x + 0.5f) + A * (y - 1) * (y - 1) - A * B);
            while (y > 0)
            {
                y--;
                Dy -= A * 2;
                if (p > 0)
                    p += A - Dy;
                else
                {
                    x++;
                    Dx += B * 2;
                    p += A - Dy + Dx;
                }
              
                if (x % 5 == 0) put4pixel(x, Point.round(y), cx, cy, g,color);

            }

        }

        public void VeElip2(Graphics g,Color color)
        {
            int x, y, kx, ky, a, b;

            kx = tam.getX();
            ky = tam.getY();

            a = this.a;
            b = this.b;

            x = 0;
            y = b;

            int A, B;

            A = a * a;
            B = b * b;
            double p = B + A / 4 - A * b;
            p = Point.round(p);

            int Dx = 0;
            int Dy = 2 * A * y;
            put4pixel(x, y, kx, ky, g,color);

            while (Dx < Dy)
            {
                x+=5;
                Dx += 10 * B;
                if (p < 0)
                {
                    p += B * (2 * x + 3);
                }
                else
                {
                    y-=5;
                    p += B * (2 * x + 3) + A * (2 - 2 * y);
                    Dy -= 10 * A;
                }
                put4pixel(x, y, kx, ky, g,color);
            }

            while (y > 0)
            {
                y-=5;
                Dy -= 10 * A;
                if (p >= 0)
                {
                    p += A * (3 - 2 * y);
                }
                else
                {
                    x+=5;
                    Dx += 10 * B;
                    p += B * (2 * x + 2) + A * (3 - 2 * y);
                }
                put4pixel(x, y, kx, ky, g,color);
            }
        }
        public void VeElip2xoa(Graphics g, Color color)
        {
            int x, y, kx, ky, a, b;

            kx = tam.getX();
            ky = tam.getY();

            a = this.a;
            b = this.b;

            x = 0;
            y = b;

            int A, B;

            A = a * a;
            B = b * b;
            double p = B + A / 4 - A * b;
            p = Point.round(p);

            int Dx = 0;
            int Dy = 2 * A * y;
            put4pixelxoa(x, y, kx, ky, g, color);

            while (Dx < Dy)
            {
                x += 5;
                Dx += 10 * B;
                if (p < 0)
                {
                    p += B * (2 * x + 3);
                }
                else
                {
                    y -= 5;
                    p += B * (2 * x + 3) + A * (2 - 2 * y);
                    Dy -= 10 * A;
                }
                put4pixelxoa(x, y, kx, ky, g, color);
            }

            while (y > 0)
            {
                y -= 5;
                Dy -= 10 * A;
                if (p >= 0)
                {
                    p += A * (3 - 2 * y);
                }
                else
                {
                    x += 5;
                    Dx += 10 * B;
                    p += B * (2 * x + 2) + A * (3 - 2 * y);
                }
                put4pixelxoa(x, y, kx, ky, g, color);
            }
        }

        public void put2pixel(int x, int y, int kx, int ky, Graphics g,Color color)
        {
            Point.putpixel(kx + x, ky + y, g,color);
            Point.putpixel(kx - x, ky + y, g,color);
            //Point.putpixel(kx + x, ky - y, g);
            //Point.putpixel(kx - x, ky - y, g);
        }

        public void VeElip_netdut(Graphics g,Color color)
        {
            int x, y, cx, cy, a, b;
            cx = tam.getX(); cy = tam.getY();
            a = this.a; b = this.b;

            x = 0; y = b;
            int A, B;
            A = a * a;
            B = b * b;
            double p = B + A / 4 - A * b;
            x = 0;
            y = b;
            int Dx = 0;
            int Dy = 2 * A * y;
            put4pixel(x, y, cx, cy, g,color);
            int count = 0;
            while (Dx < Dy)
            {
                x++;
                Dx += 2 * B;
                if (p < 0)
                    p += B + Dx;
                else
                {
                    y--;
                    Dy -= 2 * A;
                    p += B + Dx - Dy;
                }

                if (x % 5 == 0 && count % 2 != 0) put4pixel(x, Point.round(y), cx, cy, g,color);
                else if (x % 5 == 0 && count % 2 == 0) put2pixel(x, Point.round(y), cx, cy, g,color);
                count++;

            }
            p = Math.Round(B * (x + 0.5f) * (x + 0.5f) + A * (y - 1) * (y - 1) - A * B);
            count = 0;
            while (y > 0)
            {
                y--;
                Dy -= A * 2;
                if (p > 0)
                    p += A - Dy;
                else
                {
                    x++;
                    Dx += B * 2;
                    p += A - Dy + Dx;
                }

                if (x % 5 == 0 && count % 2 != 0) put4pixel(x, Point.round(y), cx, cy, g,color);
                else if (x % 5 == 0 && count % 2 == 0) put2pixel(x, Point.round(y), cx, cy, g,color);
                count++;
            }

        }
    }
}


