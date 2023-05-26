namespace Module2_HW1
{
    public class Actions
    {
        public static Result First()
        {
            Logger log = Logger.Instance;
            log.LogWrite(new LogType(Log.Info, $"Start method : First "));
            Thread.Sleep(30);
            return new Result(true);
        }

        public static Result Second()
        {
            Logger log = Logger.Instance;
            log.LogWrite(new LogType(Log.Warning, $"Skipped logic in method : Second"));
            Thread.Sleep(30);
            return new Result(true);
        }

        public static Result Third()
        {
            Thread.Sleep(30);
            return new Result(false, "I broke a logic");
        }
    }
}