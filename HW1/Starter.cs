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
                Result? result = null;
                switch (num)
                {
                    case 1:
                        result = Actions.First();
                        break;
                    case 2:
                        result = Actions.Second();
                        break;
                    case 3:
                        result = Actions.Third();
                        break;
                }

                if (result != null && !result.Status)
                {
                    Logger.Instance.LogWrite(new LogType(Log.Error, $"Action failed by a reason : {Actions.Third().Error}"));
                }

                Directory.CreateDirectory(@"C:\1");
                File.WriteAllLines(@"C:\1\log.txt", Logger.Instance.GetLog());
            }
        }
    }
}