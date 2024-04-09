using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduling
{
    
    public class Job
    {
        private string _id;
        private int _time;
        private string _politic;
        private bool _priority;

        public Job(string _idjob, int _timejob, string _politicjob, bool _priority)
        {
            this._id = _idjob;
            this._time  = _timejob;
            this._politic = _politicjob;
            this._priority = _priority;
        }

        override public string ToString()
        {
            string output = $"ID: {this._id} || TIME: {this._time}ms || POLITIC: {this._politic} || PRIORITY: {this._priority}";

            return output;
        }
    }
}
