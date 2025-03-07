using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using System.IO;

namespace Bil2
{
    public partial class App : Application
    {
        public static Database DB { get; private set; }
       
        public App()
        {
            InitializeComponent();
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "students.db");
            DB = new Database(dbPath);
             MainPage = new NavigationPage( new MainPage());
           // MainPage = new NavigationPage(new StudentPage());
        }

        protected override void OnStart()
        {

        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
