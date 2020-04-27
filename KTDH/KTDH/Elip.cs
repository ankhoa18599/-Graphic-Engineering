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

        //Hàm putpixel giống như bên đường thẳng
        public void putpixel(int x, int y, Graphics g)
        {
            if (x < 0 || x > 400 || y < 0 || y > 400) return;
            Pen p = new Pen(Color.Black);
            //Brush dùng để tô vùng bên trong của 1 hình
            //Solid Brush dùng để tô màu 1 vùng với 1 màu
            SolidBrush b = new SolidBrush(Color.Black);
            g.DrawRectangle(p, x, y, 2, 2);
            g.FillRectangle(b, x, y, 2, 2);

            g.DrawRectangle(p, x - 2, y - 2, 2, 2);
            g.FillRectangle(b, x - 2, y - 2, 2, 2);

            g.DrawRectangle(p, x, y - 2, 2, 2);
            g.FillRectangle(b, x, y - 2, 2, 2);

            g.DrawRectangle(p, x - 2, y, 2, 2);
            g.FillRectangle(b, x - 2, y, 2, 2);
        }

        public int LamTron(double x)
        {
            int n;
            double sodu = x % 5;
            if (sodu != 0)
            {
                if (sodu >= 3) n = (int)(x + 5 - sodu);
                else n = (int)(x - sodu);
            }
            else n = (int)x;
            if (x > 400) x = 400;
            return n;
        }

        //Hàm put4pixel để vẽ elip(hàm trong slice word của GV)
        public void put4pixel(int x, int y, int kx, int ky, Graphics g)
        {
            putpixel(kx + x, ky + y, g);
            putpixel(kx - x, ky + y, g);
            putpixel(kx + x, ky - y, g);
            putpixel(kx - x, ky - y, g);
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
            p = LamTron(p);

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

        //Ham bien toa do tu nho sang lon
        public static Point ToaDo(int x, int y)
        {
            return (new Point(x * 5 + 200, 200 - 5 * y));
            //return (new Point(x / 5 - 40, 40 - y / 5));
        }
    }
}

