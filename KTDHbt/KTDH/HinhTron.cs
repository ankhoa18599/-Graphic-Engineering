using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace KTDH
{
    class HinhTron
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

        public HinhTron(int x1, int y1, int r)
        {
            tam = new Point(x1, y1);
            R = r;

        }
    }
}
