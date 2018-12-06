using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yarccev_c_lab_2
{
    class SubSystem2
    {
        public Colony Operation(Colony colony)
        {
            if (colony != null)
            {
                //последние логи 
                double lastT = colony.LogsTime.Last().Subtract(DateTime.MinValue).TotalSeconds;
                int lastC = colony.LogsСount.Last();
                //дата сейчас 
                DateTime nowDataTime = DateTime.Now;
                double nowT = nowDataTime.Subtract(DateTime.MinValue).TotalSeconds;
                int deltaT = (int)Math.Floor((nowT - lastT) / 1);
                //провести расчет текущего положения колонии
                for (int i = deltaT; i > 0; i--)
                    colony.Count = colony.Count * 2;
                //сохранить логи
                colony.LogsTime.Add(nowDataTime);
                colony.LogsСount.Add(colony.Count);
                //вывести все логи
                for (int i = 0; i < colony.LogsTime.Count; i++)
                    Console.WriteLine(colony.LogsTime[i].ToString() + " ~ " + colony.LogsСount[i].ToString());
            }
            else
            {
                Console.WriteLine(" Colony is not found.");
            }
            return colony;
        }
    }
}
