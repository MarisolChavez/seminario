using seminario.Views.Productos;
using seminario.Views.Login;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using seminario.Views.Home;
namespace seminario
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new VHPrincipal());
            MainPage=new login();
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
