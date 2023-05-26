namespace Module2_HW1
{
    public class Logger
    {
        private static Logger instance = new Logger();
        private static string[] log = new string[100];
        private static int i = 0;

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
                if (instance == null)
                {
                    instance = new Logger();
                }

                return instance;
            }
        }

        public void LogWrite(LogType log)
        {
            Console.WriteLine(log.ToString());
            AddToLog(log.ToString());
        }

        public static string[] GetLog()
        {
            return log;
        }

        private static void AddToLog(string str)
        {
            log[i] = str;
            i++;
        }
    }
}