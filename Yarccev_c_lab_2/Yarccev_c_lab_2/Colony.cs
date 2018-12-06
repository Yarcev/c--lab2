using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yarccev_c_lab_2
{
    class Colony
    {
        private string name = "-";

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int step = 2;

        public int Step
        {
            get { return step; }
            set { step = value; }
        }
        private int count = 0;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        private DateTime time;

        public DateTime Time
        {
            get { return time; }
            set { time = value; }
        }
        //логи времени
        private List<DateTime> logsTime;

        public List<DateTime> LogsTime
        {
            get { return logsTime; }
            set { logsTime = value; }
        }
        //логи значений
        private List<int> logsСount;

        public List<int> LogsСount
        {
            get { return logsСount; }
            set { logsСount = value; }
        }
    }
}
