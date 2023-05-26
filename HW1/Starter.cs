namespace Module2_HW1
{
    public static class Starter
    {
        public static void Run()
        {
            Random rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                int num = rand.Next(1, 4);
                switch (num)
                {
                    case 1:
                        if (!Actions.First().Status)
                        {
                            Logger.Instance.LogWrite(new LogType(Log.Error, $"Action failed by a reason : {Actions.First().Error}"));
                        }

                        break;
                    case 2:
                        if (!Actions.Second().Status)
                        {
                            Logger.Instance.LogWrite(new LogType(Log.Error, $"Action failed by a reason : {Actions.Second().Error}"));
                        }

                        break;
                    case 3:
                        if (!Actions.Third().Status)
                        {
                            Logger.Instance.LogWrite(new LogType(Log.Error, $"Action failed by a reason : {Actions.Third().Error}"));
                        }

                        break;
                }

                Directory.CreateDirectory(@"C:\1");
                File.WriteAllLines(@"C:\1\log.txt", Logger.GetLog());
            }
        }
    }
}