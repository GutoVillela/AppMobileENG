using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace APP_LAB_ENG_SW.Models
{
    [Table("Clientes")]
    class Cliente
    {
        [PrimaryKey]
        public string Cnh { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }
        
        public string Telefone { get; set; }

        public Endereco Endereco { get; set; }

        public Usuario Login { get; set; }

    }

    [Table("Enderecos")]
    class Endereco
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string rua { get; set; }
        public string cidade { get; set; }
        public string cep { get; set; }
        public int numero { get; set; }
        public string estado { get; set; }
    }
}
