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
                "Porsche","Outro Porsche", "Mais um Porsche"
            };
            ListaPedidos.ItemsSource = itens;
        
        }
    }
}