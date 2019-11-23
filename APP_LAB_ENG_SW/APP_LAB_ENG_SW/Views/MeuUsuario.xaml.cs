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
    public partial class MeuUsuario : ContentPage
    {
        public MeuUsuario()
        {
            InitializeComponent();
        }
        public void AcessarMeusPedidos(object sender, EventArgs args)
        {
            Navigation.PushAsync(new MeuPedidos());//Manda pra página
        }
        public void AgendarCompra(object sender, EventArgs args)
        {
            Navigation.PushAsync(new AgendarCompra());//Manda pra página
        }
    }
}