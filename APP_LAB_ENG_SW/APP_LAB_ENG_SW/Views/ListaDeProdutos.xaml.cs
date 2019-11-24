using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace APP_LAB_ENG_SW.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaDeProdutos : ContentPage
    {
        public ListaDeProdutos()
        {
            InitializeComponent();
        }

        public void AcessarUsuario(object sender, EventArgs args) {
            Navigation.PushAsync(new MeuUsuario());//Manda pra página
        }

        public void AcessarMeusPedidos(object sender, EventArgs args)
        {
            Navigation.PushAsync(new MeuPedidos());//Manda pra página
        }

    }
}