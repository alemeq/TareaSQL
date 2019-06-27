using System;
using TareaXamarin.ViewModels;
using TareaXamarin.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace TareaXamarin
{
    public partial class App : Application
    {
        public App(String filename)
        {
            InitializeComponent();

            VentasViewModel.Inicializador(filename);
            MainPage = new VentasPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
