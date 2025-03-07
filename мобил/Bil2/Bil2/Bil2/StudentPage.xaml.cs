using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bil2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StudentPage : ContentPage
    {
        public StudentPage(Employee employee)
        {
            InitializeComponent();
            

            fullNameLabel.Text = employee.FullName;
            cityLabel.Text = employee.City;
            ageLabel.Text = employee.Age.ToString();
        }
    }
}
