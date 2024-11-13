namespace TimeTracker
{
    public partial class App : Application
    {
        public static List<TimeEntry> TimeEntries { get; set; } = new List<TimeEntry>();
        public App()
        {
            InitializeComponent();


            MainPage = new AppShell();
            MainPage = new NavigationPage(new MainPage());
        }

    }
}
