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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm= new Form2();
            //frm.mesaj = textBox2.Text;
            //frm.kimden=textBox1.Text;
            frm.cmb1=textBox1.Text;
            frm.cmb2=textBox2.Text;
            frm.cmb3=textBox3.Text;

            frm.Show();
            this.Hide();
        }
    }
}
