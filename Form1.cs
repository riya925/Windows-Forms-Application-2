using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                label1.Font = fd.Font;
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            if (pd.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Document Print");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            if (opd.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Selected File Name:" + opd.FileName);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ColorDialog fd = new ColorDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                label1.BackColor = fd.Color;
            }
        }
    }
}