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
        
        byte i = 0;
        List<Job> jobs = new List<Job>();

        

        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                jobs.Add(new Job(textBox1.Text, comboBox2.SelectedItem.ToString(), Convert.ToInt16(textBox2.Text)));

                
            }
            catch 
            {
                throw new Exception("parametri mancanti");
            }
            

            listBox1.Items.Add(i  + " || " + jobs[i].ToString());

            Application.DoEvents();
            Thread.Sleep(500);

            textBox1.Clear();
            textBox2.Clear();
            i++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (comboBox1.SelectedIndex == 0)
            {
                firstcomefirstserved();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                shortestJobFirst();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                roundRobin();
            }
            else
            {
                throw new Exception("metti una politica");
            }




        }

        private void firstcomefirstserved()
        {
            listBox1.Cursor = Cursors.WaitCursor;
            foreach (Job job in jobs)
            {
                listBox1.Items.Add(job.ToString() + " ---------esecuzionato---------");
            }
            jobs.Clear();
            listBox1.Cursor = Cursors.Default;
        }
        private void shortestJobFirst()
        {
            listBox1.Cursor = Cursors.WaitCursor;
            while (jobs.Count > 0)
            {
                int minTime = int.MaxValue;
                int minIndex = -1;
                for (int i = 0; i < jobs.Count; i++)
                {
                    if (jobs[i].getTime() < minTime)
                    {
                        minTime = jobs[i].getTime();
                        minIndex = i;
                    }
                }
                if (minIndex != -1)
                {
                    listBox1.Items.Add(jobs[minIndex].ToString() + " ---------esecuzionato---------");
                    jobs.RemoveAt(minIndex);
                }

            }
            listBox1.Cursor = Cursors.Default;
        }


        private void roundRobin()
        {
            
            listBox1.Cursor = Cursors.WaitCursor;
            
            int sliceTempo = 20;
            Queue<Job> readyQueue = new Queue<Job>(jobs);
            int sliceCounter = 0;
            int executionFinalTime = 0;
            for (int i = 0;i < jobs.Count;i++)
            {
                executionFinalTime += jobs[i].getTime();
            }
            progressBar1.Maximum = executionFinalTime;
            progressBar1.Step = 20;
            while (readyQueue.Count > 0)
            {
                
                Job currentJob = readyQueue.Dequeue();

                int executionTime = Math.Min(sliceTempo, currentJob.getTime());



                listBox1.Items.Add(currentJob.ToString() + "  Queuing");
                
                int remainingTime = currentJob.getTime() - executionTime;

                if (remainingTime > 0)
                {
                    currentJob.setTime(remainingTime);
                    readyQueue.Enqueue(currentJob);
                }
                else
                {
                    currentJob.setTime(0);
                    listBox1.Items.Add(currentJob.ToString() + " ---------esecuzionato---------");
                }
                
                Application.DoEvents();
              Thread.Sleep(20);
              sliceCounter++;
              progressBar1.PerformStep();
            }

            listBox1.Items.Add("ALL PROCESS COMPLEATED IN " + sliceCounter + " SLICE");
            listBox1.Cursor = Cursors.Default;
        }

        public bool firstclicked = false;
        public bool secondclicked = false;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!firstclicked)
            {
                textBox1.Text = "";
                firstclicked = true;
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!secondclicked)
            {
                textBox2.Text = "";
                secondclicked = true;
            }
        }
    }
}
