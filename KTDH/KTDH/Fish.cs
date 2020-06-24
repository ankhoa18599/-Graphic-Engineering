using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;

namespace KTDH
{
    class Fish
    {
        private Elip than;
        private Line duoi1,duoi2,duoi3;
        private Point mat;
        int x, y, size;
        int x1, y1, x2, y2;
        bool R2L;
        public Fish(int x, int y, int size)
        {
            Point a = Point.FakeToReal(x, y);
            this.size = size;
            this.x = a.getX();
            this.y = a.getY();
            size = size * 5;
            than = new Elip(this.x, this.y, size, size / 2);
            Random r = new Random();
            int n = r.Next(0, 2);
            if (n == 0) R2L = true;
            else R2L = false;
            if (R2L)
            {
                duoi1 = new Line(this.x + size, this.y, this.x + 2 * size, this.y + size / 2, Color.Black);
                duoi2 = new Line(this.x + size, this.y, this.x + 2 * size, this.y - size / 2, Color.Black);
                duoi3 = new Line(this.x + 2 * size, this.y + size / 2, this.x + 2 * size, this.y - size / 2, Color.Black);
                mat = new Point(this.x - size / 2, this.y - size / 4);
            }
            else
            {
                duoi1 = new Line(this.x - size, this.y, this.x - 2 * size, this.y + size / 2, Color.Black);
                duoi2 = new Line(this.x - size, this.y, this.x - 2 * size, this.y - size / 2, Color.Black);
                duoi3 = new Line(this.x - 2 * size, this.y + size / 2, this.x - 2 * size, this.y - size / 2, Color.Black);
                mat = new Point(this.x + size / 2, this.y - size / 4);
            }
        }

        public void setFish(int x, int y, int size)
        {
            Point a = Point.FakeToReal(x, y);
            this.size = size;
            this.x = a.getX();
            this.y = a.getY();
            size = size * 5;
            than = new Elip(this.x, this.y, size, size / 2);
            if (R2L)
            {
                duoi1 = new Line(this.x + size, this.y, this.x + 2 * size, this.y + size / 2, Color.Black);
                duoi2 = new Line(this.x + size, this.y, this.x + 2 * size, this.y - size / 2, Color.Black);
                duoi3 = new Line(this.x + 2 * size, this.y + size / 2, this.x + 2 * size, this.y - size / 2, Color.Black);
                mat = new Point(this.x - size / 2, this.y - size / 4);
            }
            else
            {
                duoi1 = new Line(this.x - size, this.y, this.x - 2 * size, this.y + size / 2, Color.Black);
                duoi2 = new Line(this.x - size, this.y, this.x - 2 * size, this.y - size / 2, Color.Black);
                duoi3 = new Line(this.x - 2 * size, this.y + size / 2, this.x - 2 * size, this.y - size / 2, Color.Black);
                mat = new Point(this.x + size / 2, this.y - size / 4);
            }
        }
        public void ve_ca1(Graphics g, Color c)
        {
            than.VeElip2(g, c);
            duoi1.DDA_Line(g, c);
            duoi2.DDA_Line(g, c);
            duoi3.DDA_Line(g, c);
            mat.putpixel(g, c);
        }
        public void xoa_ca(Graphics g)
        {
            Color xoa = Color.FromArgb(224, 224, 224);
            than.VeElip2xoa(g, xoa,true);
            duoi1.DDA_Linexoa(g, xoa, true);
            duoi2.DDA_Linexoa(g, xoa, true);
            duoi3.DDA_Linexoa(g, xoa, true);
            mat.xoapixel(g, xoa, true);
        }
        public void update_ca(Graphics g, Color c)
        {
            if (x <= -10*size )
            {
                x = 400 + 10 * size;
            }
            else if (x >= 400 + 10*size)
            {
                x = -10 * size;
            }
            if (y <= 0) y = 0;
            else if (y >= 400) y = 400;
            Point a = new Point(x, y);
            if(R2L)
            a=a.TinhTienDiem(a, -1, 0);
            else a = a.TinhTienDiem(a, 1, 0);
            a = Point.RealToFake(a.getX(), a.getY());
            setFish(a.getX(), a.getY(), size);
            
        }
        public void update_song1(Graphics g, Color c)
        {
            x1 += 5;
            if (x1 >= 80)
            {
                x1 = 0;
            }
        }
        public void update_song2(Graphics g, Color c)
        {
            x2 += 5;
            if (x2 >= 80)
            {
                x2 = 0;
            }
        }
        public void song1_chay(Graphics g, Color c, int speed)
        {
            x1 = 0;
            y1 = 200;
            ve_mattroi(g, Color.Red);
            while (true)
            {
                Thread.Sleep(speed * 100);
                xoa_song1(g, x1, y1);
                update_song1(g, c);
                ve_song1(g, Color.Blue, x1, y1);
            }
        }
        public void song2_chay(Graphics g, Color c, int speed)
        {
            x2 = 20;
            y2 = 150;
            ve_mattroi(g, Color.Red);
            while (true)
            {
                Thread.Sleep(speed * 100);
                xoa_song(g, x2, y2);
                update_song2(g, c);
                ve_song(g, Color.Blue, x2, y2);
            }
        }
        public void boi_ca(Graphics g, Color c,int speed)
        {
            ve_mattroi(g, Color.Red);
            ve_ca1(g,c);
            while (true)
            {
                Thread.Sleep(speed*100);
                xoa_ca(g);
                update_ca(g,c);
                ve_ca1(g, c);
            }
        }
        public void ve_song(Graphics g,Color c,int x,int y)
        {
            Line[] a = new Line[10];
            if (x != 0 && x<=40)
            {
                Line b = new Line(x, y, x - 40, y - 40, c);
                b.DDA_Line(g, c);
            }
            if (x!=0 && x > 40)
            {
                Line b = new Line(x, y, x - 40, y - 40, c);
                b.DDA_Line(g, c);
                Line e = new Line(x -40, y -40, x - 80, y, c);
                e.DDA_Line(g, c);
            }
            for(int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    a[i] = new Line(x, y, x + 5 * 8, y - 5 * 8, Color.Black);
                    x = x + 5 * 8;
                    y = y - 5 *8;
                }
                else
                {
                    a[i] = new Line(x, y, x + 5 * 8, y + 5 * 8, Color.Black);
                    x = x + 5 *8;
                    y = y + 5 *8;
                }
                a[i].DDA_Line(g, c);

            }

        }
        public void ve_song1(Graphics g, Color c, int x, int y)
        {
            Line[] a = new Line[10];
            if (x != 0 && x <= 40)
            {
                Line b = new Line(x, y, x - 40, y - 40, c);
                b.DDA_Line(g, c);
            }
            if (x != 0 && x > 40)
            {
                Line b = new Line(x, y, x - 40, y - 40, c);
                b.DDA_Line(g, c);
                Line e = new Line(x - 40, y - 40, x - 80, y, c);
                e.DDA_Line(g, c);
            }
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    a[i] = new Line(x, y, x + 5 * 8, y - 5 * 8, Color.Black);
                    x = x + 5 * 8;
                    y = y - 5 * 8;
                }
                else
                {
                    a[i] = new Line(x, y, x + 5 * 8, y + 5 * 8, Color.Black);
                    x = x + 5 * 8;
                    y = y + 5 * 8;
                }
                a[i].DDA_Line(g, c);

            }

        }
        public void xoa_song(Graphics g, int x, int y)
        {
            Color xoa = Color.FromArgb(224, 224, 224);
            Line[] a = new Line[10];
            if (x != 0 && x <= 40)
            {
                Line b = new Line(x, y, x - 40, y - 40, xoa);
                b.DDA_Linexoa(g, xoa,true);
            }
            if (x != 0 && x > 40)
            {
                Line b = new Line(x, y, x - 40, y - 40, xoa);
                b.DDA_Linexoa(g, xoa,true);
                Line e = new Line(x - 40, y - 40, x - 80, y, xoa);
                e.DDA_Linexoa(g, xoa,true);
            }
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    a[i] = new Line(x, y, x + 5 * 8, y - 5 * 8, Color.Black);
                    x = x + 5 * 8;
                    y = y - 5 * 8;
                }
                else
                {
                    a[i] = new Line(x, y, x + 5 * 8, y + 5 * 8, Color.Black);
                    x = x + 5 * 8;
                    y = y + 5 * 8;
                }
                a[i].DDA_Linexoa(g, xoa, true);

            }
        }
        public void xoa_song1(Graphics g, int x, int y)
        {
            Color xoa = Color.FromArgb(224, 224, 224);
            Line[] a = new Line[10];
            if (x != 0 && x <= 40)
            {
                Line b = new Line(x, y, x - 40, y - 40, xoa);
                b.DDA_Linexoa(g, xoa, true);
            }
            if (x != 0 && x > 40)
            {
                Line b = new Line(x, y, x - 40, y - 40, xoa);
                b.DDA_Linexoa(g, xoa, true);
                Line e = new Line(x - 40, y - 40, x - 80, y, xoa);
                e.DDA_Linexoa(g, xoa, true);
            }
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    a[i] = new Line(x, y, x + 5 * 8, y - 5 * 8, Color.Black);
                    x = x + 5 * 8;
                    y = y - 5 * 8;
                }
                else
                {
                    a[i] = new Line(x, y, x + 5 * 8, y + 5 * 8, Color.Black);
                    x = x + 5 * 8;
                    y = y + 5 * 8;
                }
                a[i].DDA_Linexoa(g, xoa, true);

            }
        }
        public void ve_mattroi(Graphics g, Color c)
        {
            HT mattroi = new HT(0, 0, 10*5);
            mattroi.Midpoint_htron(g, c);
            Line a = new Line(50 + 2 * 5, 25, 50 + 2 * 5 + 5 * 5, 25 + 3 * 5, c);
            Line b = new Line(50 + 2 * 5 - 5, 25 + 5 * 4, 50 + 2 * 5 + 5 * 2, 25 + 3 * 5 + 5 * 4, c);
            Line e = new Line(30, 55, 40, 75, c);
            Line d = new Line(5, 60, 10, 80, c);
            Line f = new Line(65, 5, 95, 15, c);
            a.DDA_Line(g, c);
            b.DDA_Line(g, c);
            e.DDA_Line(g, c);
            d.DDA_Line(g, c);
            f.DDA_Line(g, c);
        }
    }
}
