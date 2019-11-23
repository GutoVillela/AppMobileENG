using System;
using System.Collections.Generic;
using System.Text;

namespace APP_LAB_ENG_SW.Models
{
    class Pessoa
    {
        public string nome { get; set; }
        public string email { get; set; }
        public string cnh { get; set; }
        public string telefone { get; set; }        
        public Endereco endereco { get; set; }
        public Usuario login { get; set; }

        public void criarUsuario() { }
        public void alterarUsuario() { }
        public void excluirUsuario() { }
    }

    class Endereco
    {
        public string rua { get; set; }
        public string cidade { get; set; }
        public string cep { get; set; }
        public int numero { get; set; }
        public string estado { get; set; }
    }
}
