namespace Module2_HW1
{
    public partial class LogType
    {
        public LogType(Log type, string mes)
        {
            Time = DateTime.Now;
            Mes = mes;
            Type = type;
        }

        public DateTime Time { get; set; }
        public string Mes { get; set; }
        public Log Type { get; set; }
        public override string ToString()
        {
            return $"{Time} : {Type} : {Mes}";
        }
    }
}