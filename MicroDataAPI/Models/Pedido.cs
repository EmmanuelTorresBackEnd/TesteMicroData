using System;

namespace MicroDataAPI.Models
{
    public class Pedido
    {
        public string Id { get; set; }
        public string DocumentoCliente { get; set; }
        public DateTime DataPedido { get; set; }
        public decimal Valor { get; set; }
        public string Itens { get; set; }
        public string Indice { get; set; }

    }
}