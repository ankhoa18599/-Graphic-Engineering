using System;
using System.Collections.Generic;
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
        public void put4pixel(int x, int y, int kx, int ky, Graphics g)
        {
            Point.putpixel(kx + x, ky + y, g);
            Point.putpixel(kx - x, ky + y, g);
            Point.putpixel(kx + x, ky - y, g);
            Point.putpixel(kx - x, ky - y, g);
        }
//thêm putpixel đặc biệt
        public void put4pixel1(int x, int y, int kx, int ky, int dem, Graphics g)
        {
            Point.putpixel(kx + x, ky + y, g);
            Point.putpixel(kx - x, ky + y, g);
            Point.putpixel_1real(kx + x, ky - y, g);
            Point.putpixel_1real(kx - x, ky - y, g);
        }
        public void MidPoint_Elip(Graphics g)
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
            put4pixel(x, y, kx, ky, g);

            while (Dx < Dy)
            {
                x++;
                Dx += 2 * B;
                if (p < 0)
                {
                    p += B * (2 * x + 3);
                }
                else
                {
                    y--;
                    p += B * (2 * x + 3) + A * (2 - 2 * y);
                    Dy -= 2 * A;
                }
                put4pixel(x, y, kx, ky, g);
            }

            while (y > 0)
            {
                y--;
                Dy -= 2 * A;
                if (p >= 0)
                {
                    p += A * (3 - 2 * y);
                }
                else
                {
                    x++;
                    Dx += 2 * B;
                    p += B * (2 * x + 2) + A * (3 - 2 * y);
                }
                put4pixel(x, y, kx, ky, g);
            }
        }
        public void MidPoint_Elip1(Graphics g)
        {
            int x, y, kx, ky, a, b;
            int dem =0;

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
            put4pixel1(x, y, kx, ky,dem, g);

            while (Dx < Dy)
            {
                x++;
                Dx += 2 * B;
                if (p < 0)
                {
                    p += B * (2 * x + 3);
                }
                else
                {
                    y--;
                    p += B * (2 * x + 3) + A * (2 - 2 * y);
                    Dy -= 2 * A;
                }
                put4pixel1(x, y, kx, ky,dem, g);
            }

            while (y > 0)
            {
                y--;
                Dy -= 2 * A;
                if (p >= 0)
                {
                    p += A * (3 - 2 * y);
                }
                else
                {
                    x++;
                    Dx += 2 * B;
                    p += B * (2 * x + 2) + A * (3 - 2 * y);
                }
                put4pixel1(x, y, kx, ky,dem, g);
            }
        }
    }
}
