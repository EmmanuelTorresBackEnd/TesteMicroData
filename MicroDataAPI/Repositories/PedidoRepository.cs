using MicroDataAPI.Context;
using MicroDataAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace MicroDataAPI.Repositories
{
    public class PedidoRepository
    {
        private readonly PedidoContext _context;

        public PedidoRepository(PedidoContext context)
        {
            _context = context;
        }

        public List<Pedido> Listar()
        {
            return _context.Pedido.ToList();
        }

        public Pedido buscarPorId(int id)
        {
            return _context.Pedido.Find(id);

        }

        public void Cadastrar(Pedido pedido)
        {
            _context.Pedido.Add(pedido);

            _context.SaveChanges();
        }

        public void Atualizar(int id, Pedido pedido)
        {
            Pedido PedidoBuscado = _context.Pedido.Find(id);

            if (PedidoBuscado != null)
            {
                PedidoBuscado.Id = pedido.Id;
                PedidoBuscado.DocumentoCliente = pedido.DocumentoCliente;
                PedidoBuscado.DataPedido = pedido.DataPedido;
                PedidoBuscado.Itens = pedido.Itens;
                PedidoBuscado.Valor = pedido.Valor;
                PedidoBuscado.Indice = pedido.Indice;

            }

            _context.Pedido.Update(PedidoBuscado);

            _context.SaveChanges();

        }

        /// <summary>
        /// ATENÇÃO DELETA O GAME DO SISTEMA
        /// </summary>
        /// <param name="id"></param>
        public void Deletar(int id)
        {
            Pedido pedidoBuscado = _context.Pedido.Find(id);

            _context.Pedido.Remove(pedidoBuscado);

            _context.SaveChanges();
        }

    }
}
