using System;
using System.Collections.Generic;
using System.Text;

namespace APP_LAB_ENG_SW.Models
{
    class Pedido
    {
    public string modelo_carro {get; set;}
    public int protocolo_montadora {get; set;}
    public DateTime dt_pedido {get; set;}
    public DateTime dt_entrega {get; set;}
    public DateTime dt_retirada {get; set;}
    public Pessoa cliente {get; set;}
    public string concessionaria {get; set;}
    }
}
