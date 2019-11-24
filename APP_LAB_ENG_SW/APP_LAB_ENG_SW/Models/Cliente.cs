using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace APP_LAB_ENG_SW.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        [PrimaryKey]
        public string Cnh { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }
        
        public string Telefone { get; set; }

        [ForeignKey(typeof(Endereco))]
        public int EnderecoId { get; set; }

        [ForeignKey(typeof(Usuario)), NotNull]
        public string Login { get; set; }

        [OneToOne]
        public Usuario LoginUsuario { get; set; }

        [ManyToOne]
        public Endereco Endereco { get; set; }

    }
}
