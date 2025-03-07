using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Text;

namespace bilet13
{
    public class AppResources
    {
        private static readonly ResourceManager ResourceManager = new ResourceManager("bilet13.Resource", typeof(AppResources).GetTypeInfo().Assembly);

        public static string ForgotPassBut => ResourceManager.GetString("ForgotPassBut");
        public static string LoginBut => ResourceManager.GetString("LoginBut");
        public static string PasswordPole => ResourceManager.GetString("PasswordPole");
        public static string RegistBut => ResourceManager.GetString("RegistBut");

       
    }
}
