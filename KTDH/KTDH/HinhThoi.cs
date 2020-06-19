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
        public void setCheo(Line a, Line b)
        {
            setCheoA(a);
            setCheoB(b);
        }
        public void Draw(Graphics g,Color color)
        {
            Line a1b1, b1a2, a2b2, b2a1;
            Point AF, AL, BF, BL;
            AF = new Point(CheoA.getFpoint().getX(), CheoA.getFpoint().getY());
            AL = new Point(CheoA.getLpoint().getX(), CheoA.getLpoint().getY());
            BF = new Point(CheoB.getFpoint().getX(), CheoB.getFpoint().getY());
            BL = new Point(CheoB.getLpoint().getX(), CheoB.getLpoint().getY());

            AF.setPoint(Point.round(AF.getX()), Point.round(AF.getY()));
            AL.setPoint(Point.round(AL.getX()), Point.round(AL.getY()));
            BF.setPoint(Point.round(BF.getX()), Point.round(BF.getY()));
            BL.setPoint(Point.round(BL.getX()), Point.round(BL.getY()));

            a1b1 = new Line(AF.getX(),AF.getY(),BF.getX(),BF.getY(),System.Drawing.Color.Black);
            b1a2 = new Line(BF.getX(), BF.getY(), AL.getX(), AL.getY(), System.Drawing.Color.Black);
            a2b2 = new Line(AL.getX(), AL.getY(), BL.getX(), BL.getY(), System.Drawing.Color.Black);
            b2a1 = new Line(BL.getX(), BL.getY(), AF.getX(), AF.getY(), System.Drawing.Color.Black);
            
            a1b1.DDA_Line(g,color);
            b1a2.DDA_Line(g,color);
            a2b2.DDA_Line(g,color);
            b2a1.DDA_Line(g,color);
        }
        public void Drawxoa(Graphics g, Color color)
        {
            Line a1b1, b1a2, a2b2, b2a1;
            Point AF, AL, BF, BL;
            AF = new Point(CheoA.getFpoint().getX(), CheoA.getFpoint().getY());
            AL = new Point(CheoA.getLpoint().getX(), CheoA.getLpoint().getY());
            BF = new Point(CheoB.getFpoint().getX(), CheoB.getFpoint().getY());
            BL = new Point(CheoB.getLpoint().getX(), CheoB.getLpoint().getY());

            AF.setPoint(Point.round(AF.getX()), Point.round(AF.getY()));
            AL.setPoint(Point.round(AL.getX()), Point.round(AL.getY()));
            BF.setPoint(Point.round(BF.getX()), Point.round(BF.getY()));
            BL.setPoint(Point.round(BL.getX()), Point.round(BL.getY()));

            a1b1 = new Line(AF.getX(), AF.getY(), BF.getX(), BF.getY(), System.Drawing.Color.Black);
            b1a2 = new Line(BF.getX(), BF.getY(), AL.getX(), AL.getY(), System.Drawing.Color.Black);
            a2b2 = new Line(AL.getX(), AL.getY(), BL.getX(), BL.getY(), System.Drawing.Color.Black);
            b2a1 = new Line(BL.getX(), BL.getY(), AF.getX(), AF.getY(), System.Drawing.Color.Black);

            a1b1.DDA_Linexoa(g, color);
            b1a2.DDA_Linexoa(g, color);
            a2b2.DDA_Linexoa(g, color);
            b2a1.DDA_Linexoa(g, color);
        }
    }
}
