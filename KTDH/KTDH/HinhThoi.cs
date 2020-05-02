using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace KTDH
{
    class HinhThoi
    {
        private Point Tam;
        private Line CheoA;
        private Line CheoB;
        public void setTam(int x, int y)
        {
            this.Tam.setX(x);
            this.Tam.setY(y);
        }
        public void setTam(Point tam)
        {
            this.Tam = tam;
        }
        public void setCheoA(Line a)
        {
            this.CheoA = a;
        }
        public void setCheoB(Line b)
        {
            this.CheoB = b;
        }
        public void setCheo(Line a, Line b)
        {
            setCheoA(a);
            setCheoB(b);
        }
        public Point getTam()
        {
            return this.Tam;
        }
        public Line getCheoA()
        {
            return this.CheoA;
        }
        public Line getCheoB()
        {
            return this.CheoB;
        }
        public void Draw(Graphics g)
        {
            Line a1b1, b1a2, a2b2, b2a1;
            Point AF = Point.FakeToReal(CheoA.getFpoint().getX(), CheoA.getFpoint().getY());
            Point AL = Point.FakeToReal(CheoA.getLpoint().getX(), CheoA.getLpoint().getY());
            Point BF = Point.FakeToReal(CheoB.getFpoint().getX(), CheoB.getFpoint().getY());
            Point BL = Point.FakeToReal(CheoB.getLpoint().getX(), CheoB.getLpoint().getY());

            AF.setX(Point.round(AF.getX()));
            AF.setY(Point.round(AF.getY()));
            AL.setX(Point.round(AL.getX()));
            AL.setY(Point.round(AL.getY()));
            BF.setX(Point.round(BF.getX()));
            BF.setY(Point.round(BF.getY()));
            BL.setX(Point.round(BL.getX()));
            BL.setY(Point.round(BL.getY()));

            a1b1 = new Line(AF.getX(),AF.getY(),BF.getX(),BF.getY(),System.Drawing.Color.Black);
            b1a2 = new Line(BF.getX(), BF.getY(), AL.getX(), AL.getY(), System.Drawing.Color.Black);
            a2b2 = new Line(AL.getX(), AL.getY(), BL.getX(), BL.getY(), System.Drawing.Color.Black);
            b2a1 = new Line(BL.getX(), BL.getY(), AF.getX(), AF.getY(), System.Drawing.Color.Black);
            
            a1b1.DDA_Line(g);
            b1a2.DDA_Line(g);
            a2b2.DDA_Line(g);
            b2a1.DDA_Line(g);
        }
    }
}
