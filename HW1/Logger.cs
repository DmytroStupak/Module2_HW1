namespace Module2_HW1
{
    public class Logger
    {
        private static Logger _instance = new Logger();
        private string[] _log = new string[100];
        private int i = 0;

        static Logger()
        {
        }

        private Logger()
        {
        }

        public static Logger Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Logger();
                }

                return _instance;
            }
        }

        public void LogWrite(LogType log)
        {
            Console.WriteLine(log);
            AddToLog(log.ToString());
        }

        public string[] GetLog()
        {
            return _log;
        }

        private void AddToLog(string str)
        {
            _log[i] = str;
            i++;
        }
    }
}