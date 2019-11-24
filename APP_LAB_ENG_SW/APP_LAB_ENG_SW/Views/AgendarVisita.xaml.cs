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
    public partial class AgendarCompra : ContentPage
    {
        public AgendarCompra()
        {
            InitializeComponent();
        }

        public void AcessarUsuario(object sender, EventArgs args)
        {
            Navigation.PushAsync(new MeuUsuario());//Manda pra página
        }
        public void AcessarMeusPedidos(object sender, EventArgs args)
        {
            Navigation.PushAsync(new MeuPedidos());//Manda pra página
        }

        public void OnDateSelected(object sender, DateChangedEventArgs args) {
            DateTime data1 = new DateTime();
            data1 = StartDatePicker.Date;
                DisplayAlert("Data Selecionada", data1.ToString("dd-MM-yyyy"), "OK");
        }

    }
}