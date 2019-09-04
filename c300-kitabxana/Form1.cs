using c300_kitabxana.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c300_kitabxana
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            anasekil.Location = new Point((this.ClientSize.Width - anasekil.Size.Width) / 2,
                (this.ClientSize.Height - anasekil.Size.Height) / 2);
        }

        private void ADDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addbook adb = new addbook();
            adb.ShowDialog();
        }
    }
}
