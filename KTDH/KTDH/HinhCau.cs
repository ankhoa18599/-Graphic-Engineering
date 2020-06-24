using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KTDH
{
    class HinhCau
    {
        private HT hinhtron;
        private Elip hinhelip;
        public HT GetHT()
        {
            return this.hinhtron;
        }
        public Elip GetElip()
        {
            return this.hinhelip;
        }
        public void KhoitaoHT(int x,int y,int r)
        {
            this.hinhtron = new HT(x, y, r);
        }
        public void KhotaoElip(int x, int y, int a,int b)
        {
            this.hinhelip = new Elip(x, y, a, b);     
        }

    }
}
