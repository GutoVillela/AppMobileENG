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

        public void VoltaProdutos(object sender, EventArgs args) {//Volta pra Lista
            Navigation.PopAsync();
        }
    }
}