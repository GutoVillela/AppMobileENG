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
    public partial class NovoUsuario : ContentPage
    {
        public NovoUsuario()
        {
            InitializeComponent();
        }

        public void CadastrarNovoUsuario(object sender, EventArgs args)
        {
            //Definir informaçoes do novo usuário
            Usuario usuario = new Usuario();
            usuario.Login = entryLogin.Text;
            usuario.Senha = entrySenha.Text;

            //Realizar cadastro do novo usuário
            UsuarioController usuarioController = new UsuarioController();
            usuarioController.Cadastrar(usuario);

            //Voltar para a tela de Login 
            Navigation.PopAsync();//Remove a tela atual da Pilha de forma Assíncrona
        }

        public void BuscaCEP(object sender, EventArgs args)
        {

        }
    }
}