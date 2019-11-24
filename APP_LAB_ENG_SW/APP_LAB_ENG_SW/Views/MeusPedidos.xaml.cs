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
    public partial class MeuPedidos : ContentPage
    { 
        public MeuPedidos()
        {
            InitializeComponent();
            List<string> itens = new List<string>()
            {
                "Porsche","Outro Porsche"
            };
            ListaPedidos.ItemsSource = itens;
        }
        public void AcessarUsuario(object sender, EventArgs args)
        {
            Navigation.PushAsync(new MeuUsuario());//Manda pra página
        }
        public void AgendarCompra(object sender, EventArgs args)
        {
            Navigation.PushAsync(new AgendarCompra());//Manda pra página
        }
    }
}