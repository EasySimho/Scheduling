using System.ComponentModel;
using System.Windows.Forms;

namespace Scheduling
{

    public class Job
    {
        private string _id;
        private int _time;
        private string _filext;
        public int usedSlices = 0;
        public double waitingTime = 0;
        public double tournAroundTime = 0;
        

        public Job(string _idjob, string _filextjob, int _timejob)
        {
            this._id = _idjob;
            this._time = _timejob;
            this._filext = _filextjob;

        }

        override public string ToString()
        {
            string output = $"    ID: {this._id}{this._filext}    ||   TIME: {this._time}ms";

            return output;
        }

        public int getTime()
        {
            return _time;
        }

        public string getFilext() 
        { 
            return _filext;
        }

        public string getName()
        {
            return _id;
        }

        public void setTime(int remainingTime)
        {
            this._time = remainingTime;
        }

        public double getWaitingTime()
        {
           return this.waitingTime;
        }

        public void setWaitingTime(double time)
        {
            this.waitingTime = time;
        }

        public double getTournAroundTime()
        {
            return this.tournAroundTime;
        }


        public void setTournAroundTime(double tournAroundTime)
        {
             this.tournAroundTime = tournAroundTime;
        }

        //Fixed
    }
}
