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
            //Definir informações do novo cliente
            Cliente cliente = new Cliente();
            cliente.Cnh = EntryCNH.Text;
            cliente.Nome = EntryNome.Text;
            cliente.Email = EntryEmail.Text;
            cliente.Telefone = EntryTelefone.Text;

            cliente.Endereco = new Endereco
            {
                Cep = EntryCEP.Text,
                Rua = EntryRua.Text,
                Cidade = EntryCidade.Text,
                Numero = int.Parse(EntryNumero.Text),
                Estado = EntryEstado.Text
            };


            //Definir informaçoes do novo usuário
            cliente.LoginUsuario = new Usuario
            {
                Login = EntryLogin.Text,
                Senha = EntrySenha.Text
            };

            cliente.Endereco.Clientes = new List<Cliente>
            {
                cliente
            };

            ClienteController clienteController = new ClienteController();
            clienteController.Cadastrar(cliente);

            //Voltar para a tela de Login 
            Navigation.PopAsync();//Remove a tela atual da Pilha de forma Assíncrona
        }

        public void BuscaCEP(object sender, EventArgs args)
        {

        }

        public void Consultar(object sender, EventArgs args)
        {
            ClienteController clienteController = new ClienteController();
            List<Cliente> clientes = clienteController.Consultar();

            UsuarioController usuarioController = new UsuarioController();
            List<Usuario> usuarios = usuarioController.Consultar();

            EnderecoController enderecoController = new EnderecoController();
            List<Endereco> enderecos = enderecoController.Consultar();

            DisplayAlert("CONSULTAR", clientes[0].Nome, "OK");
        }
    }
}