using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace APP_LAB_ENG_SW.Models
{
    [Table("Compra")]
    class Compra
    {
        public Array carrinho { get; set; }
        public DateTime agenda { get; set; }

        //Métodos abaixo estão abertos a discussão para Inserir/Remover/Alterar

        public void inserirNoCarrinho(){ }

        public void removerDoCarrinho() { }

        public void agendar( ) { }
    }
}
