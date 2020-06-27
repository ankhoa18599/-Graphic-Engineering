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
    public partial class HinhElip : Form
    {
        public int a, b;
        public Point A;
        public Elip hinhelip;
        public Boolean checkchange = false;
        private void button1_Click(object sender, EventArgs e)
        {
            int x = Int32.Parse(numericUpDown1.Value.ToString());
            int y = Int32.Parse(numericUpDown2.Value.ToString());
            a = Int32.Parse(numericUpDown3.Value.ToString())*5;//thử nhá
            b = Int32.Parse(numericUpDown4.Value.ToString())*5;

            A = Point.FakeToReal(x, y);
            hinhelip = new Elip(A.getX(), A.getY(), a, b);
            this.DialogResult = DialogResult.OK;
            checkchange = true;
            this.Close();
        }

        public HinhElip()
        {
            InitializeComponent();
        }
    }
}
