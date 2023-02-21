using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] a = new int[30];
        int res = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random rand = new Random();
            for (int i = 0; i < 30; i++)
            {
                a[i] = rand.Next(-100, 100);
                listBox1.Items.Add("a[" + i.ToString() + "] = " + a[i].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            for (int i = 0; i < 30; i++)
            {
                if (a[i] % 5 == 0)
                {
                    res += a[i];
                    listBox2.Items.Add("a[" + Convert.ToString(i) + "] = " + a[i].ToString());
                }
            }
            listBox2.Items.Add("Сумма элементов = " + res);
        }
    }
}
