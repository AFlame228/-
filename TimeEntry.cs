namespace TimeTracker
{
    public class WorkTimeEntry
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Description { get; set; }

        // �����������
        public WorkTimeEntry(DateTime startTime, DateTime endTime, string description)
        {
            StartTime = startTime;
            EndTime = endTime;
            Description = description;
        }

        // ����� ��� ���������� �����������������
        public TimeSpan GetDuration()
        {
            return EndTime - StartTime;
        }
    }
}    


