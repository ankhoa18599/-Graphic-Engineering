using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace KTDH
{
    public class HT
    {
        public int R;
        public Point tam;
        public Color mau;
        public int b;

        public Point getTam()
        {
            return this.tam;
        }
        public void setTam(Point a)
        {
            this.tam = a;

        }
        public int getR()
        {
            return this.R;
        }
        public void setR(int r)
        {
            this.R = r;

        }

        public HT(int x1, int y1, int r)
        {
            tam = new Point(x1, y1);
            R = r;

        }
        private void put8pitxel(int x, int y, int cx, int cy, Graphics m)
        {
            Point.putpixel(cx + x, cy + y, m);
            Point.putpixel(cx + x, cy - y, m);

            Point.putpixel(cx - x, cy + y, m);
            Point.putpixel(cx - x, cy - y, m);

            Point.putpixel(cx + y, cy + x, m);
            Point.putpixel(cx + y, cy - x, m);

            Point.putpixel(cx - y, cy + x, m);
            Point.putpixel(cx - y, cy - x, m);
        }
        public void Midpoint_htron(Graphics g)
        {
            int x, y, cx, cy, p, r;
            Color m = this.mau;
            cx = this.tam.getX(); cy = this.tam.getY();
            x = 0;
            y = r = this.R;
            int maxX = Point.round((float)(Math.Sqrt(2) / 2 * r));// x nằm trong khoảng từ 0 đến căn 2 chia 2
            // int maxX = Math.Sqrt(2) / 2 * R;
            p = 5/4 - r;
            put8pitxel(x, y, cx, cy, g);
            while (x <= maxX)
            {
                if (p < 0) p += 2 * x + 3;
                else { p += 2 * (x - y) + 5; y -= 5; }
                x += 5;
                put8pitxel(x, y, cx, cy, g);
            }

        }
        public void Midpoint_htron_dut(Graphics g)
        {
            int x, y, cx, cy, p, r;
            int dem = 0;
            Color m = this.mau;
            cx = this.tam.getX(); cy = this.tam.getY();
            x = 0;
            y = r = this.R;
            int maxX = Point.round((float)(Math.Sqrt(2) / 2 * r));// x nằm trong khoảng từ 0 đến căn 2 chia 2
            // int maxX = Math.Sqrt(2) / 2 * R;
            p = 5 / 4 - r;
            put8pitxel(x, y, cx, cy, g);
            while (x <= maxX)
            {
                if (p < 0) p += 2 * x + 3;
                else { p += 2 * (x - y) + 5; y -= 5; }
                x += 5;
                dem++;
                put8pitxel(x, y, cx, cy, g);
            }

        }
    }
}
