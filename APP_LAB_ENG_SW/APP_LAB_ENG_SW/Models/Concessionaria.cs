using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace APP_LAB_ENG_SW.Models
{
    
    [Table("Concessionarias")]
    class Concessionaria
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Endereco { get; set; }
        public string Cnpj{ get; set; }
        public string Status{ get; set; }
        public string Telefone{ get; set; }
        public DateTime Horario_funcionamento { get; set; }
        public string Email{ get; set; }

    }
}
