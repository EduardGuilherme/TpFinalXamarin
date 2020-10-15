using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp_Final;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.LocalDB.MercadoriaViewModels;

namespace XF.LocalDB.View.Aluno
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        MercadoriaViewModel vmMercadoria;
        public MainPage()
        {
            vmMercadoria = new MercadoriaViewModel();
            BindingContext = vmMercadoria;
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            vmMercadoria = new MercadoriaViewModel();
            BindingContext = vmMercadoria;
            base.OnAppearing();
        }
        private void OnNovaMercadoria(object sender, EventArgs args)
        {
            Navigation.PushAsync(new NovoAlunoView());
        }
        private void OnMercadoriaTapped(object sender,
        ItemTappedEventArgs args)
        {
            var selecionado = args.Item as XF.LocalDB.Model.Mercadoria;
            DisplayAlert("Mercadoria Selecionado", "Mercadoria: " + selecionado.Id, "OK");
        }

        private void btnGeoLocation(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DemoGPS());
        }

        private void btnEditar(object sender, EventArgs e)
        {

        }

        private void btnDeletar(object sender, EventArgs e)
        {

        }
    }
}
    
