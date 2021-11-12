using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW1
{
   public class Action
    {
        public Result sturtMethod()
        {
            Result res = new Result() { isStatus = true };
            Logger l = new Logger() { _logTime = new DateTime(), _logType = LogType.Info };



            return res;
        }

        public Result SkipedLogic()
        {
            Result res = new Result() { isStatus = true };
            Logger l = new Logger() { _logTime = new DateTime(), _logType = LogType.Warning };



            return res;
        }

        public Result brokenLogic()
        {
            Result res = new Result() { isStatus = false };
            Logger l = new Logger() { _logTime = new DateTime(), _logType = LogType.Error };



            return res;
        }
    }
}
