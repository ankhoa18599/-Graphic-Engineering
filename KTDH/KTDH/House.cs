using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace KTDH
{
    class House
    {
        private HCN ThanNha;
        private HCN MaiNha;
        private HCN OngKhoi;
        private HCN CuaNha;
        public HCN getThanNha() { return this.ThanNha; }
        public HCN getMainNha() { return this.MaiNha; }
        public HCN getOngKhoi() { return this.OngKhoi; }
        public HCN getCuaNha() { return this.CuaNha; }
        public void setThanNha(int toadox,int toadoy, int chieucao,int chieurong)
        {
            Point A = new Point(toadox, toadoy);
            Point B = new Point(toadox + chieurong, toadoy);
            Point C = new Point(toadox + chieurong, toadoy + chieucao);
            Point D = new Point(toadox, toadoy + chieucao);
            this.ThanNha = new HCN(A, B, C, D);
        }
        public void setMaiNha(int toadox, int toadoy, int chieucao, int chieurong)
        {
            Point A = new Point(toadox, toadoy);
            Point B = new Point(toadox + chieurong, toadoy);
            Point C = new Point(toadox + chieurong, toadoy + chieucao);
            Point D = new Point(toadox, toadoy + chieucao);
            this.MaiNha = new HCN(A, B, C, D);
        }
        public void setCuaNha(int toadox, int toadoy, int chieucao, int chieurong)
        {
            Point A = new Point(toadox, toadoy);
            Point B = new Point(toadox + chieurong, toadoy);
            Point C = new Point(toadox + chieurong, toadoy + chieucao);
            Point D = new Point(toadox, toadoy + chieucao);
            this.CuaNha = new HCN(A, B, C, D);
        }
        public void setOngKhoi(int toadox, int toadoy, int chieucao, int chieurong)
        {
            Point A = new Point(toadox, toadoy);
            Point B = new Point(toadox + chieurong, toadoy);
            Point C = new Point(toadox + chieurong, toadoy + chieucao);
            Point D = new Point(toadox, toadoy + chieucao);
            this.OngKhoi = new HCN(A, B, C, D);
        }
        public void setFull()
        {
            int nhax = this.ThanNha.getA().getX();
            int nhay = this.ThanNha.getA().getY();
            int nhacao = this.ThanNha.getD().getY() - this.ThanNha.getA().getY();
            int nharong = this.ThanNha.getB().getX() - this.ThanNha.getA().getX();
            int mainhacao =(int) Math.Round(nhacao / 4.0);
            int mainharong = nharong + 4;
            int ongkhoicao = (int)Math.Round(nhacao / 5.0);
            int ongkhoirong = (int)Math.Round(nharong / 10.0);
            int cuanhacao = (int)Math.Round(nhacao / 2.0);
            int cuanharong = (int)Math.Round(nharong / 4.0);
            setThanNha(nhax, nhay, nhacao, nharong);
            setCuaNha((nhax + (nharong + nhax)) / 2 - cuanharong / 2,nhay,cuanhacao,cuanharong);
            setMaiNha(nhax - (mainharong - nharong) / 2, nhay + nhacao, mainhacao, mainharong);
            setOngKhoi((nhax + nharong) - ongkhoirong, nhay + nhacao + mainhacao, ongkhoicao, ongkhoirong);
        }
        public void Ve_ThanNha(Graphics g,Color c)
        {
            ThanNha.Draw(g, c);
        }
        public void Ve_MaiNha(Graphics g, Color c)
        {
            MaiNha.Draw(g, c);
        }
        public void Ve_CuaNha(Graphics g, Color c)
        {
            CuaNha.Draw(g, c);
        }
        public void Ve_OngKhoi(Graphics g, Color c)
        {
            OngKhoi.Draw(g, c);
        }
        public void VeFull(Graphics g,Color c)
        {
            Ve_ThanNha(g, c);
            Ve_MaiNha(g, c);
            Ve_CuaNha(g, c);
            Ve_OngKhoi(g, c);
        }

    }
}
