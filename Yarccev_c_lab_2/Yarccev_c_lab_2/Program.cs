using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yarccev_c_lab_2
{
    /// <summary>
    /// для удобства демонстрации 
    /// бактерии будут размножаться 
    /// раз в 1 сек а не так как в природе 
    /// раз в 30 мин.
    /// </summary>
    class Program
    {
        static void lineCh(char s)
        {
            for (int i = 0; i < 80; i++)
                Console.Write(s);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine(" Lab 2 c#, Author: Yarcev D.A. from group IS-61");
            Console.WriteLine(" variant 8");
            lineCh('=');

            //ключ цыкла программы
            bool keyLoop = true;
            //наша колония
            Colony colony = null;
            //ключ выбора
            int chose = 0;

            while (keyLoop)
            {
                //меню
                Console.WriteLine(" Menu:");
                Console.WriteLine(" 1) Create bacteria of colony");
                Console.WriteLine(" 2) Show colony growth statistics");
                Console.WriteLine(" 3) destroy the bacteria of colony");
                Console.WriteLine(" 4) close this program");
                //выбор
                bool k = true;
                while(k)
                {
                    k = false;
                    Console.Write(" To do: ");
                    chose = Convert.ToInt32(Console.ReadLine().ToString());
                    if (chose < 1 || chose > 4)
                    {
                        Console.WriteLine("!!!Error");
                        k = true;
                    }
                }
                lineCh('-');
                //общий набор возможностей
                Facade facade = new Facade();
                //действие
                switch (chose){
                    case 1:
                        //создать
                        colony = facade.OperationCreate();
                        break;
                    case 2:
                        //проверить
                        colony = facade.OperationShow(colony);
                        break;
                    case 3:
                        //очистить
                        colony = facade.OperationDel();
                        break;
                        //закрыть программу
                    case 4:
                        keyLoop = false;
                        Console.WriteLine(" Program is ending...");
                        break;
                }
                lineCh('=');
            }
            Console.ReadLine();
        }
    }
}
