namespace MicroDataAPI.Models
{
    public class Produto : Pedido
    {
        public int CodigoProduto { get; set; }
        public string QuantidadeProduto { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorTotal { get; set; }

    }
}
