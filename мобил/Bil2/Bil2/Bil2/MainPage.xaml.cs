using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite;
using System.Collections.ObjectModel;
using System.IO;
using Xamarin.Essentials;

namespace Bil2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Device.StartTimer(TimeSpan.FromSeconds(3), () =>
            {
                Application.Current.MainPage = new MainPage();
                return false;
            });
        }
    }
}

