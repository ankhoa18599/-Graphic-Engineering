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
        private int housex;
        private int housey;
        private int chieurong_house;
        private int chieucao_house;

        //Get 
        public int Gethousex() { return this.housex; }
        public int Gethousey() { return this.housey; }
        public int Getchieurong_house() { return this.chieurong_house; }
        public int Getchieucao_house() { return this.chieucao_house; }
        //Set
        public void Sethousex(int x)
        {
            this.housex = x;
        }
        public void Sethousey(int y)
        {
            this.housey = y;
        }
        public void Setchieurong_house(int rong)
        {
            this.chieurong_house = rong;
        }
        public void Setchieucao_house(int cao)
        {
            this.chieucao_house = cao;
        }
        public void Sethouse(int x,int y, int rong,int cao)
        {
            this.Sethousex(x);
            this.Sethousey(y);
            this.Setchieurong_house(rong);
            this.Setchieucao_house(cao);
        }
        //
        public void VeHCN(int x, int y, int cao, int rong,Graphics g)
        {
            //x,y là tọa độ trái dưới
            Point traitren = new Point(x,y+cao);
            Point phaitren = new Point(x+rong,y+cao);
            Point traiduoi = new Point(x,y);
            Point phaiduoi = new Point(x+rong,y);
            traitren = Point.FakeToReal(traitren.getX(), traitren.getY());
            phaitren = Point.FakeToReal(phaitren.getX(), phaitren.getY());
            traiduoi = Point.FakeToReal(traiduoi.getX(), traiduoi.getY());
            phaiduoi = Point.FakeToReal(phaiduoi.getX(), phaiduoi.getY());
            Line traicao = new Line(traiduoi.getX(), traiduoi.getY(), traitren.getX(), traitren.getY(), Color.Black);
            Line phaicao = new Line(phaiduoi.getX(), phaiduoi.getY(), phaitren.getX(), phaitren.getY(), Color.Black);
            Line duoirong = new Line(traiduoi.getX(), traiduoi.getY(), phaiduoi.getX(), phaiduoi.getY(), Color.Black);
            Line trenrong = new Line(traitren.getX(), traitren.getY(), phaitren.getX(), phaitren.getY(), Color.Black);
            traicao.DDA_Line(g);
            phaicao.DDA_Line(g);
            duoirong.DDA_Line(g);
            trenrong.DDA_Line(g);
        }
        public void Ve_ThanNha(int x,int y, int cao, int rong,Graphics g)
        {
            VeHCN(x, y, cao, rong, g);
        }
        public void Ve_CuaNha(int x, int y, int cao,int rong, Graphics g)
        {
            VeHCN(x, y, cao, rong, g);
        }
        public void Ve_MaiNha(int x,int y,int cao,int rong, Graphics g)
        {
            VeHCN(x, y, cao, rong, g);
        }
        public void Ve_OngKhoi(int x, int y, int cao, int rong, Graphics g)
        {
            VeHCN(x, y, cao, rong, g);
        }
        
        public void Ve_Khoi(int x, int y, int r,Graphics g)
        {
            Point Tam = new Point(x, y);
            Tam = Point.FakeToReal(Tam.getX(), Tam.getY());
            HT khoi = new HT(Tam.getX(),Tam.getY(),r);
            khoi.Midpoint_htron(g);
        }

        public void VeNha(Graphics g)
        {
            int ChieuCao_MaiNha = this.chieucao_house / 4;
            int ChieuRong_MaiNha = this.chieurong_house + 4;
            int ChieuCao_OngKhoi = this.chieucao_house / 5;
            int ChieuRong_OngKhoi = this.chieurong_house / 10;
            int ChieuCao_Cua = this.chieucao_house / 2 ;
            int ChieuRong_Cua = this.chieurong_house / 4;
            Ve_ThanNha(this.housex, this.housey, this.chieucao_house, this.chieurong_house, g);
            Ve_MaiNha(this.housex-(ChieuRong_MaiNha - this.chieurong_house)/2,this.housey+this.chieucao_house,ChieuCao_MaiNha,ChieuRong_MaiNha,g);
            Ve_CuaNha((this.housex+(this.chieurong_house+this.housex))/2-ChieuRong_Cua/2,this.housey,ChieuCao_Cua,ChieuRong_Cua,g);
            Ve_OngKhoi((this.housex+this.chieurong_house)-ChieuRong_OngKhoi,this.housey+this.chieucao_house+ChieuCao_MaiNha,ChieuCao_OngKhoi,ChieuRong_OngKhoi,g);

        }

    }
}
