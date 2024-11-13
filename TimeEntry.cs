namespace TimeTracker
{
    public class WorkTimeEntry
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Description { get; set; }

        // Конструктор
        public WorkTimeEntry(DateTime startTime, DateTime endTime, string description)
        {
            StartTime = startTime;
            EndTime = endTime;
            Description = description;
        }

        // Метод для вычисления продолжительности
        public TimeSpan GetDuration()
        {
            return EndTime - StartTime;
        }
    }
}    


