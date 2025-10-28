using SQLiteTutorial6.Services;


namespace SQLiteTutorial6
{
    public partial class App : Application
    {
        public static DatabaseService Database { get; private set; }
        public App()
        {
            InitializeComponent();
            string dbPath = 
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "expenses.db3");


            MainPage = new AppShell();

        }

        
    }
}