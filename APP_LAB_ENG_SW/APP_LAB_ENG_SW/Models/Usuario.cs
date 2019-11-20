using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace APP_LAB_ENG_SW.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [PrimaryKey]
        public string Login { get; set; }

        [NotNull]
        public string Senha { get; set; }
    }

    public class Pessoa
    {
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public string sexo { get; set; }
        public string DataNasc { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
    }
    public class PessoaFisica
    {
        public string rg { get; set; }
        public string cpf { get; set; }
    }
    public class PessoaJuridica
    {
        public string cnpj { get; set; }
    }
    public class endereco
    {
        public string rua { get; set; }
        public string cidade { get; set; }
        public string cep { get; set; }
        public int numero { get; set; }
        public string estado { get; set; }
    }
}
