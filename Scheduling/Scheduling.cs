using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Scheduling
{

    public partial class Scheduling : Form
    {

        byte i = 0;
        List<Job> jobs = new List<Job>();
        List<Job> backupJobs = new List<Job>();



        public Scheduling()
        {
            InitializeComponent();
        }


        #region job listing
        private void addJob(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(NameInput.Text) || ExtensionSelector.SelectedItem == null || string.IsNullOrWhiteSpace(TimeInput.Text))
                {
                    throw new Exception("Invalid Job Paremater");
                }

                jobs.Add(new Job(NameInput.Text, ExtensionSelector.SelectedItem.ToString(), Convert.ToInt16(TimeInput.Text)));

                Screen.Items.Add(i + " || " + jobs[i].ToString());

                Application.DoEvents();
                Thread.Sleep(100);

                NameInput.Clear();
                TimeInput.Clear();
                i++;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding job: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region metrics
        private void getMetrics(object sender, EventArgs e)
        {

            double mediumWaitingTime = 0;
            double mediumTournAroundTime = 0;
            int executionFinalTime = 0;
            foreach (Job job in backupJobs)
            {
                executionFinalTime += job.getTime();
            }
            foreach (Job job in backupJobs)
            {
                job.setTournAroundTime(executionFinalTime);
                job.setWaitingTime(job.getTournAroundTime() - (double)job.getTime());
            }
            try
            {

                if (backupJobs.Count == 0)
                {
                    throw new Exception("Job backup corupted");
                }

                foreach (Job job in backupJobs)
                {
                    mediumTournAroundTime += job.getTournAroundTime();
                    mediumWaitingTime += job.getWaitingTime();
                }

                mediumTournAroundTime /= backupJobs.Count;
                mediumWaitingTime /= backupJobs.Count;
                Screen.Items.Clear();
                Screen.Items.Add($"medium tournauround time: {mediumTournAroundTime}");
                Screen.Items.Add($"medium waiting time: {mediumWaitingTime}");

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error showinf metrics: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region start
        private void startProcessing(object sender, EventArgs e)
        {
            try
            {
                foreach (Job job in jobs)
                {
                    backupJobs.Add(new Job(job.getName(), job.getFilext(), job.getTime()));
                }
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
                else if (SchedulingSelector.SelectedIndex == 3)
                {

                    limitedRoundRobin();
                    label1.Text = "All Process Compleated";

                }
                else
                {
                    label1.Text = "ERROR";
                    throw new Exception("Select a Politic");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error starting process: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion

        #region scheduling mode
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
            ShowMetricsButton.Visible = true;
            MessageBox.Show($"Work Compleated", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            ShowMetricsButton.Visible = true;
            MessageBox.Show($"Work Compleated", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        jobs.Remove(currentJob);
                    }

                    Application.DoEvents();
                    Thread.Sleep(20);
                    sliceCounter++;
                    ProgressBar.PerformStep();
                }

                Screen.Items.Add("ALL PROCESS COMPLEATED IN " + sliceCounter + " SLICE");

            }
            else if (jobs.Count == 1)
            {
                Screen.Items.Add(jobs[0].ToString() + "  Executed");
            }
            Screen.Cursor = Cursors.Default;
            ShowMetricsButton.Visible = true;
            MessageBox.Show($"Work Compleated in {sliceCounter}", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void limitedRoundRobin()
        {
            int maxSlicesPerJob = Convert.ToInt16(maxTimeSlices.Text);
            Screen.Cursor = Cursors.WaitCursor;

            int sliceTempo = 20;
            Queue<Job> readyQueue = new Queue<Job>(jobs);
            Queue<Job> waitingQueue = new Queue<Job>();
            int sliceCounter = 0;
            int executionFinalTime = 0;

            for (int i = 0; i < jobs.Count; i++)
            {
                executionFinalTime += jobs[i].getTime();
            }
            ProgressBar.Maximum = executionFinalTime;
            ProgressBar.Step = 20;

            while (readyQueue.Count > 0 || waitingQueue.Count > 0)
            {
                if (readyQueue.Count > 0)
                {
                    Job currentJob = readyQueue.Dequeue();
                    Screen.Items.Add(currentJob.ToString() + " Started");



                    int executionTime = Math.Min(sliceTempo, currentJob.getTime());
                    int remainingTime = currentJob.getTime() - executionTime;
                    int jobslices = remainingTime / 20;
                    if (remainingTime > 0)
                    {

                        currentJob.usedSlices++;

                        if (currentJob.usedSlices < maxSlicesPerJob)
                        {

                            currentJob.setTime(remainingTime);
                            readyQueue.Enqueue(currentJob);
                        }
                        else
                        {
                            currentJob.setTime(remainingTime);
                            waitingQueue.Enqueue(currentJob);
                        }

                        Screen.Items.Add(currentJob.ToString() + " Stopped (" + jobslices + " slices remaining)");
                    }
                    else
                    {
                        currentJob.setTime(0);
                        Screen.Items.Add(currentJob.ToString() + " Executed");
                    }
                }
                else
                {
                    if (waitingQueue.Count > 0)
                    {
                        readyQueue.Enqueue(waitingQueue.Dequeue());
                    }
                }

                Application.DoEvents();
                Thread.Sleep(20);
                sliceCounter++;
                ProgressBar.PerformStep();
            }

            Screen.Items.Add("ALL PROCESS COMPLEATED IN " + sliceCounter + " SLICE");
            Screen.Cursor = Cursors.Default;
            ShowMetricsButton.Visible = true;
            MessageBox.Show($"Work Compleated in {sliceCounter} time slices", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region UI function
        public bool firstclicked = false;
        public bool secondclicked = false;
        public bool thirdclicked = false;



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

        private void SlicesTextClicked(object sender, EventArgs e)
        {
            if (!thirdclicked)
            {
                maxTimeSlices.Text = "";
                thirdclicked = true;
            }
        }

        private void maxSlicesVisibility(object sender, EventArgs e)
        {
            if (SchedulingSelector.SelectedIndex == 3) { maxTimeSlices.Visible = true; }
            else { maxTimeSlices.Visible = false; }
        }
    #endregion
    }
}
