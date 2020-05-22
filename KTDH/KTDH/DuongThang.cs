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
    public partial class DuongThang : Form
    {
        public int xA, yA, xB, yB;
        private void DuonThang_Load(object sender, EventArgs e)
        {

        }
        public DuongThang()
        {
            InitializeComponent();
        }

        private void jbtnVeDuongThang_Click(object sender, EventArgs e)
        {
            xA = Int32.Parse(numericUpDown1.Value.ToString());
            yA = Int32.Parse(numericUpDown2.Value.ToString());
            xB = Int32.Parse(numericUpDown3.Value.ToString());
            yB = Int32.Parse(numericUpDown4.Value.ToString());
            //xC = Int32.Parse(numericUpDown3.Value.ToString());
            //yC = Int32.Parse(numericUpDown4.Value.ToString());
            //xD = Int32.Parse(numericUpDown3.Value.ToString());
            //yD = Int32.Parse(numericUpDown4.Value.ToString());
            //xE = Int32.Parse(numericUpDown3.Value.ToString());
            //yE = Int32.Parse(numericUpDown4.Value.ToString());
            Form formDuongThang = new Form1();
            this.Close();
        }
    }
}
