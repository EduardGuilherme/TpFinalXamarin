using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.LocalDB.Model;
using XF.LocalDB.MercadoriaViewModels;
using XF.LocalDB;
using XF.LocalDB.View;

namespace XF.LocalDB
{
    public partial class App : Application
    {
        public App()
        {
            // The root page of your application
            MainPage = new NavigationPage(new View.Aluno.MainPage());
        }
        static Mercadoria mercadoriaModel;
        public static Mercadoria MercadoriaModel
        {
            get
            {
                if (mercadoriaModel == null)
                {
                    mercadoriaModel = new Mercadoria();
                }
                return mercadoriaModel;
            }
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
