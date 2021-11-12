using System;


namespace Module2HW1
{
    class Logger
    {
        public sealed class Singleton
        {
            private static readonly Singleton instance = new Singleton();
            static Singleton()
            {
            }
            private Singleton()
            {
            }
            public static Singleton Instance
            {
                get
                {
                    return instance;
                }
            }

        }

        public DateTime _logTime { get; set; }

        public LogType _logType { set; get; }

        public string _message { set; get; }

        public void show(string message, LogType type, DateTime time)
        {
            _message = message;
            _logType = type;
            _logTime = time;
            Console.WriteLine(message);
            Console.WriteLine(type);
            Console.WriteLine(time);
        }
    }
}
