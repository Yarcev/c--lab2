using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yarccev_c_lab_2
{
    /// <summary>
    /// общий набор функционала
    /// содержащийся в подсистемах
    /// </summary>
    class Facade
    {
        SubSystem1 subSystem1 = new SubSystem1();
        SubSystem2 subSystem2 = new SubSystem2();
        SubSystem3 subSystem3 = new SubSystem3();
        //создать
        public Colony OperationCreate()
        {
            return subSystem1.Operation();
        }
        //занести запись в логи и высветить текущее состояние
        public Colony OperationShow(Colony colony)
        {
            return subSystem2.Operation(colony);
        }
        //удалить
        public Colony OperationDel()
        {
            return subSystem3.Operation();
        }
    }
}
