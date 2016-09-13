using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp2015
{
    public partial class Form1 : Form
    {
        BusinessLayer bl = new BusinessLayer();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!bl.CheckEmptyNumbers(textBox1.Text) || !bl.CheckEmptyNumbers(textBox2.Text))
                MessageBox.Show("Number should not be empty");
            else if (!bl.CheckIfNumbers(textBox1.Text) || !bl.CheckIfNumbers(textBox2.Text))
                MessageBox.Show("Value should be number");
            else MessageBox.Show(bl.AddNumbers(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)).ToString());
        }
    }
}
