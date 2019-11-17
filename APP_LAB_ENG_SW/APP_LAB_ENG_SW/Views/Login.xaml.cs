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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        public void ChamarTelaNovoUsuario(object sender, EventArgs args)
        {
            Navigation.PushAsync(new NovoUsuario());//Chamar tela de Novo Usuário pela Navigation Page (isso só vai funcionar se o NavigationPage for implementado no Code Behind do App.xaml (no contrutor)
        }

        public void AutenticarLogin(object sender, EventArgs args)
        {
            //Definindo as informações do usuário
            Usuario usuario = new Usuario();
            usuario.Login = entryLogin.Text;
            usuario.Senha = entrySenha.Text;

            UsuarioController usuarioController = new UsuarioController();
            if (usuarioController.Validar(usuario))
                DisplayAlert("VÁLIDO!", "Usuário válido", "OK");
            else
                DisplayAlert("INVÁLIDO", "Se você está vendo este alerta, parabéns! Começaram os erros :)", "AÍ FODEU");

        }
    }
}