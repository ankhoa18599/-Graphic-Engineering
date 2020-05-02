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
    public partial class HinhTron : Form
    {
        public int x, y, r;
        public HT ht;
        public Boolean checkchange = false;

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void jbtnVe_Click(object sender, EventArgs e)
        {
            x = Int32.Parse(numericUpDown1.Value.ToString());
            y = Int32.Parse(numericUpDown2.Value.ToString());
            r = Int32.Parse(numericUpDown3.Value.ToString());
            r = r * 5;
            Point A = Point.FakeToReal(x, y);
            //MessageBox.Show(r.ToString());
            ht = new HT(A.getX(), A.getY(), r);
            this.checkchange = true;
            this.Close();
        }

        
        public HinhTron()
        {
            InitializeComponent();
        }
    }
}
