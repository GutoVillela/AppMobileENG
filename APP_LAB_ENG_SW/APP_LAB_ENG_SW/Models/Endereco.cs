using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace APP_LAB_ENG_SW.Models
{
    [Table("Enderecos")]
    public class Endereco
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Rua { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }
        public int Numero { get; set; }
        public string Estado { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All, ReadOnly = true)]//Relacionamento de 1-n com Clientes
        public List<Cliente> Clientes { get; set; }
    }
}
