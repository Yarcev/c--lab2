using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yarccev_c_lab_2
{
    class SubSystem1
    {
        public Colony Operation() 
        {
            Colony colony = new Colony();
            Console.Write(" input name for colony: ");
            colony.Name = Console.ReadLine().ToString();
            Console.Write(" input step for colony: ");
            colony.Step = Convert.ToInt32(Console.ReadLine().ToString());
            if (colony.Step < 1)
                colony.Step = 1;
            colony.Time = DateTime.Now;
            Console.Write(" input start count bacterias: ");
            colony.Count = Convert.ToInt32(Console.ReadLine().ToString());
            //начало логов
            colony.LogsTime = new List<DateTime>();
            colony.LogsTime.Add(DateTime.Now);
            colony.LogsСount = new List<int>();
            colony.LogsСount.Add(colony.Count);
            return colony;
        }
    }
}
