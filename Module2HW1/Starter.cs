using System;
using System.IO;

namespace Module2HW1
{
    public class Starter
    {
        public void Run()
        {
            var rnd = new Random();
            var log = new Logger();
            int index = 0;
            for (int i = 0; i < 100; i++)
            {

                var action = new Action();
                var result = new Result();
                int tmp = rnd.Next(0, 200);
                if (tmp < 30)
                {
                    action.sturtMethod();
                }
                else if (tmp > 30 && tmp < 66)
                {
                    action.SkipedLogic();
                }
                else
                {
                    action.brokenLogic();

                    var loggerTmp = new Logger()
                    {
                        _logTime = DateTime.Now,
                        _logType = LogType.Error,
                        _message = "Action failed by a reason:”" + result.mes
                    };
                    loggerTmp.show(loggerTmp._message, loggerTmp._logType, loggerTmp._logTime);
                    File.AppendAllText("log.txt", loggerTmp._message + loggerTmp._logType.ToString() + loggerTmp._logTime.ToString() + "\n");

                }
            }
        }
    }
}
