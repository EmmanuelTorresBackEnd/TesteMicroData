using MicroDataAPI.Context;
using MicroDataAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace MicroDataAPI.Repositories
{
    public class ProdutoRepository
        {
            private readonly PedidoContext _context;

            public ProdutoRepository(PedidoContext pedidoContext)
            {
                _context = pedidoContext;
            }

            public List<Produto> Listar()
            {
                return _context.Produto.ToList();
            }

            public Produto buscarPorCodigoProduto(int CodigoProduto)
            {
                return _context.Produto.Find(CodigoProduto);

            }

            public void Cadastrar(Produto p)
            {
                _context.Produto.Add(p);

                _context.SaveChanges();
            }

            public void Atualizar(int CodigoProduto, Produto p)
            {
                Produto ProdutoBuscado = _context.Produto.Find(CodigoProduto);

                if (ProdutoBuscado != null)
                {
                ProdutoBuscado.CodigoProduto = p.CodigoProduto;
                ProdutoBuscado.QuantidadeProduto = p.QuantidadeProduto;
                ProdutoBuscado.ValorUnitario = p.ValorUnitario;
                ProdutoBuscado.ValorTotal = p.ValorTotal;

                }

                _context.Produto.Update(ProdutoBuscado);

                _context.SaveChanges();

            }

            public void Deletar(int CodigoProduto)
            {
                Produto ProdutoBuscado = _context.Produto.Find(CodigoProduto);

                _context.Produto.Remove(ProdutoBuscado);

                _context.SaveChanges();
            }
        }
    }
