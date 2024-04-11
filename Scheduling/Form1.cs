using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
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


        
        private void addJob(object sender, EventArgs e)
        {
            try
            {
                jobs.Add(new Job(NameInput.Text, ExtensionSelector.SelectedItem.ToString(), Convert.ToInt16(TimeInput.Text)));


            }
            catch
            {
                throw new Exception("parametri mancanti");
            }


            Screen.Items.Add(i + " || " + jobs[i].ToString());

            Application.DoEvents();
            Thread.Sleep(100);

            NameInput.Clear();
            TimeInput.Clear();
            i++;
        }

        private void startProcessing(object sender, EventArgs e)
        {
            Screen.Items.Clear();
            label1.Text = "Working...";


            if (jobs.Count < 1)
            {
                throw new Exception("No Works Added");
            }

            if (SchedulingSelector.SelectedIndex == 0)
            {
                firstcomefirstserved();
                label1.Text = "All Process Compleated";
            }
            else if (SchedulingSelector.SelectedIndex == 1)
            {
                shortestJobFirst();
                label1.Text = "All Process Compleated";
            }
            else if (SchedulingSelector.SelectedIndex == 2)
            {
                roundRobin();
                label1.Text = "All Process Compleated";
            }
            else
            {
                label1.Text = "ERROR";
                throw new Exception("metti una politica");

            }




        }

        private void firstcomefirstserved()
        {
            Screen.Cursor = Cursors.WaitCursor;
            int executionFinalTime = 0;
            for (int i = 0; i < jobs.Count; i++)
            {
                executionFinalTime += jobs[i].getTime();
            }
            ProgressBar.Maximum = executionFinalTime;

            foreach (Job job in jobs)
            {
                ProgressBar.Step = job.getTime();
                Screen.Items.Add(job.ToString() + "  Executed");
                Application.DoEvents();
                Thread.Sleep(job.getTime());
                ProgressBar.PerformStep();
            }
            jobs.Clear();
            Screen.Cursor = Cursors.Default;
        }

        private void shortestJobFirst()
        {
            int executionFinalTime = 0;
            for (int i = 0; i < jobs.Count; i++)
            {
                executionFinalTime += jobs[i].getTime();
            }
            ProgressBar.Maximum = executionFinalTime;

            Screen.Cursor = Cursors.WaitCursor;
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
                ProgressBar.Step = jobs[minIndex].getTime();
                Application.DoEvents();
                Thread.Sleep(jobs[minIndex].getTime());
                Screen.Items.Add(jobs[minIndex].ToString() + "  Executed");

                ProgressBar.PerformStep();
                jobs.RemoveAt(minIndex);


            }
            Screen.Cursor = Cursors.Default;
        }

        private void roundRobin()
        {

            Screen.Cursor = Cursors.WaitCursor;

            int sliceTempo = 20;
            Queue<Job> readyQueue = new Queue<Job>(jobs);
            int sliceCounter = 0;
            int executionFinalTime = 0;
            for (int i = 0; i < jobs.Count; i++)
            {
                executionFinalTime += jobs[i].getTime();
            }
            ProgressBar.Maximum = executionFinalTime;
            ProgressBar.Step = 20;
            if (jobs.Count > 1)
            {
                while (readyQueue.Count > 0)
                {

                    Job currentJob = readyQueue.Dequeue();
                    Screen.Items.Add(currentJob.ToString() + "  Started");
                    int executionTime = Math.Min(sliceTempo, currentJob.getTime());



                    int remainingTime = currentJob.getTime() - executionTime;

                    if (remainingTime > 0)
                    {
                        currentJob.setTime(remainingTime);
                        readyQueue.Enqueue(currentJob);
                        Screen.Items.Add(currentJob.ToString() + "  Stopped");

                    }
                    else
                    {
                        currentJob.setTime(0);
                        Screen.Items.Add(currentJob.ToString() + "  Executed");
                    }

                    Application.DoEvents();
                    Thread.Sleep(20);
                    sliceCounter++;
                    ProgressBar.PerformStep();
                }

                Screen.Items.Add("ALL PROCESS COMPLEATED IN " + sliceCounter + " SLICE");
                Screen.Cursor = Cursors.Default;
            }
            else if (jobs.Count == 1)
            {
                Screen.Items.Add(jobs[0].ToString() + "  Executed");
            }
        }

        public bool firstclicked = false; 
        public bool secondclicked = false;

        private void textResetName(object sender, EventArgs e)
        {
            if (!firstclicked)
            {
                NameInput.Text = "";
                firstclicked = true;
            }

        }
        private void textResetTime(object sender, EventArgs e)
        {
            if (!secondclicked)
            {
                TimeInput.Text = "";
                secondclicked = true;
            }
        }
    }
}
