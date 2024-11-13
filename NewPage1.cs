namespace TimeTracker;

public class TimeEntry
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
    public TimeSpan TotalTime => EndTime - StartTime;
    public string Description { get; set; }
    public string TimeSpent { get; set; } // например, "2 часа"
}