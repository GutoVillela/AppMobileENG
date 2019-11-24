using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLitePCL;
using SQLiteNetExtensions.Attributes;

namespace APP_LAB_ENG_SW.Models
{
    [Table("Pedidos")]
    class Pedido
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Modelo_carro {get; set;}

        public int Protocolo_montadora {get; set;}

        public DateTime Dt_pedido {get; set;}

        public DateTime Dt_entrega {get; set;}

        public DateTime Dt_retirada {get; set;}

        public Cliente Cliente {get; set;}

        [ForeignKey(typeof(Concessionaria))]
        public Concessionaria Concessionaria { get; set; }
    }
}
