using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBAkademikDataSet.dosen' table. You can move, or remove it, as needed.
            this.dosenTableAdapter.Fill(this.dBAkademikDataSet.dosen);

        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            new Form3().Show();
        }
    }
}

   
