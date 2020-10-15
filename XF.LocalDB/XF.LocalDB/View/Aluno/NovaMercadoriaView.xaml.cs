using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF.LocalDB.View.Aluno
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NovoAlunoView : ContentPage
    {
        private int MercadoriaId = 0;
        public NovoAlunoView()
        {
            InitializeComponent();
        }
        public NovoAlunoView(int Id)
        {
            var mercadoria = App.MercadoriaModel.GetMercadoria(Id);
            txtNomeMercadoria.Text = mercadoria.NomeDaMercadoria;
            txtpesoMercadoria.Text = mercadoria.PesoDaMercadoria;
            txtNomeProduto.Text = mercadoria.NomeDoProduto;
            txtEmail.Text = mercadoria.EmailDoProdutor;
            txtNcm.Text = mercadoria.NCM;
            MercadoriaId = mercadoria.Id;
        }

        public void OnSalvar(object sender, EventArgs e)
        {
            XF.LocalDB.Model.Mercadoria aluno = new XF.LocalDB.Model.Mercadoria()
            {
                NomeDaMercadoria = txtNomeMercadoria.Text,
                PesoDaMercadoria = txtpesoMercadoria.Text,
                NomeDoProduto = txtNomeProduto.Text,
                EmailDoProdutor = txtEmail.Text,
                NCM = txtNcm.Text,
                Id = MercadoriaId
            };
            Limpar();
            App.MercadoriaModel.SalvarMercadoria(aluno);
            Navigation.PopAsync();
        }

        private void OnCancelar(object sender, EventArgs e)
        {
            Limpar();
            Navigation.PopAsync();
        }
        public void Limpar()
        {
            txtNomeMercadoria.Text = txtpesoMercadoria.Text = txtNomeProduto.Text = txtEmail.Text = txtNcm.Text = string.Empty;

        }
    }
}