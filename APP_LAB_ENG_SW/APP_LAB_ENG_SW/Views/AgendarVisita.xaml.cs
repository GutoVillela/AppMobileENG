using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using APP_LAB_ENG_SW.Models;
using APP_LAB_ENG_SW.Controller;

namespace APP_LAB_ENG_SW.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AgendarCompra : ContentPage
    {

        DateTime data1 = new DateTime();
        DateTime data2 = new DateTime();
        UsuarioController uc = new UsuarioController();
        Usuario u = new Usuario();
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

        public void OnDateSelected(object sender, DateChangedEventArgs args){
            data2 = StartDatePicker.MinimumDate;
            data1 = StartDatePicker.Date;
            if (data1 <= data2){
               //Não expor no display a alteração de data após o cancelamento da agenda
            }
            else {
            DisplayAlert("Data Definida", data1.ToString("dd/MM/yyyy"), "OK");
            }
        }

        public void Agendar(object sender, EventArgs args)
        {
            //Método para inserir o banco e confirmar o agendamento, pegando os dados da var data1
            DisplayAlert("Agendada com sucesso", "Data registrada: " + data1.ToString("dd/MM/yyyy"), "OK");
            //Após o display preencher os dados das Labels abaixo dos Buttons
            LData.Text = data1.ToString("dd/MM/yyyy");//Eu gostaria de puxar os dados do banco  
            //para poder assim colocar os dados de usuário e gerar o protocolo. Eu coloquei os dados de exibição na Label
        }
        public void CancelarAgenda(object sender, EventArgs args){
            StartDatePicker.Date = StartDatePicker.MinimumDate;
            DisplayAlert("Cancelada", "Agenda cancelada", "OK");
        }
    }
}