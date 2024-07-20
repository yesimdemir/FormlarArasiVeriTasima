using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormlarArasiVeriTaşıma
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string cmb1;
        public string cmb2;
        public string cmb3;

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(cmb1);
            comboBox1.Items.Add(cmb2);
            comboBox1.Items.Add(cmb3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1=new Form1();
            frm1.Show();
            this.Hide();
        }
    }
}
