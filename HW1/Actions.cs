namespace Module2_HW1
{
    public class Actions
    {
        public static Result First()
        {
            Logger.Instance.LogWrite(new LogType(Log.Info, $"Start method : First "));
            Thread.Sleep(30);
            return new Result(true);
        }

        public static Result Second()
        {
            Logger.Instance.LogWrite(new LogType(Log.Warning, $"Skipped logic in method : Second"));
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