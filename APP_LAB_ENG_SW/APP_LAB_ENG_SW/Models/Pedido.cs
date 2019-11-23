using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLitePCL;

namespace APP_LAB_ENG_SW.Models
{
    [Table("Pedidos")]
    class Pedido
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }

        public string modelo_carro {get; set;}

        public int protocolo_montadora {get; set;}

        public DateTime dt_pedido {get; set;}

        public DateTime dt_entrega {get; set;}

        public DateTime dt_retirada {get; set;}

        public Pessoa cliente {get; set;}

        [Column("Concessionaria")]
        public string concessionaria {get; set;}
    }
}
