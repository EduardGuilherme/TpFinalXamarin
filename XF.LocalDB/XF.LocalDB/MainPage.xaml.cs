using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using XF.LocalDB.View.Aluno;
using XF.LocalDB.MercadoriaViewModels;

namespace XF.LocalDB
{
    public partial class MainPage : ContentPage
    {

        MercadoriaViewModel vmAluno;
        public MainPage()
        {
            vmAluno = new MercadoriaViewModel();
            BindingContext = vmAluno;
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            vmAluno = new MercadoriaViewModel();
            BindingContext = vmAluno;
            base.OnAppearing();
        }
        private void OnNovo(object sender, EventArgs args)
        {
            Navigation.PushAsync(new NovoAlunoView());
        }
        private void OnAlunoTapped(object sender,
        ItemTappedEventArgs args)
        {
            var selecionado = args.Item as XF.LocalDB.Model.Mercadoria;
            DisplayAlert("Aluno selecionado", "Aluno: " + selecionado.Id, "OK");
        }
    }
}

