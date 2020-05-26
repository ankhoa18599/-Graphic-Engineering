using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KTDH
{
    public partial class HinhHopChuNhat : Form
    {
        public Line AB, BC, CD, DA, EF, FG, GH, HE, AE, BF, CG, DH;
        Boolean check = false;
        private void button1_Click(object sender, EventArgs e)
        {
            //nam code
            //Su dung phep chieu Cabinet
            Double a = Math.Sqrt(2.0) / 2;
            int x, y, z, cd, cr, cc;
            
            //Hinh hop co 8 diem
            int xA, xB, xC, xD, xE, xF, xG, xH;
            int yA, yB, yC, yD, yE, yF, yG, yH;

            x = Int32.Parse(numericUpDown1.Value.ToString());
            y = Int32.Parse(numericUpDown2.Value.ToString());
            z = Int32.Parse(numericUpDown3.Value.ToString());
            cd = Int32.Parse(numericUpDown4.Value.ToString());
            cr= Int32.Parse(numericUpDown5.Value.ToString());
            cc = Int32.Parse(numericUpDown6.Value.ToString());

            if (cd == 0 || cr == 0 || cc == 0)
            {
                MessageBox.Show("Sai thông số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //diem ban dau nam o truc duong x
                //truc am y
                xA = (int)((x + cd / 2) - (y + cr / 2) * a);
                yA = (int)(z - (y + cr / 2) * a);

                //yA = yB
                //nam o truc am x; truc am y
                xB = (int)((x - cd / 2) - (y + cr / 2) * a);
                yB = yA;

                //truc duong x, truc am y
                xC = (int)((x - cd / 2) - (y - cr / 2) * a);
                yC = (int)(z - (y - cr / 2) * a);

                //yC = yD

            }
        }

        public HinhHopChuNhat()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
