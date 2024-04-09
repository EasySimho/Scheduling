using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduling
{
    public partial class Form1 : Form
    {

        Job[] processi = new Job[50];

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            processi[i] = new Job(textBox1.Text, Convert.ToInt16(textBox2.Text), comboBox1.SelectedItem.ToString(), priority.Checked );

            listBox1.Items.Add(processi[i].ToString());

            Application.DoEvents();
            Thread.Sleep(500);

            textBox1.Clear();
            textBox2.Clear();
            priority.Checked = false;
            comboBox1.SelectedIndex = 0;
            i++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                
            }
        }
    }
}
