using MicroDataAPI.Models;
using MicroDataAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace MicroDataAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly PedidoRepository _pedidoRepository;

        public PedidoController(PedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }
        [HttpGet]

        public IActionResult Listar()
        {

            try
            {
                return Ok(_pedidoRepository.Listar());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        [HttpGet("{id}")]

        public IActionResult BuscarPorID(int id)
        {
            try
            {
                Pedido pedidoProcurado = _pedidoRepository.buscarPorId(id);

                if (pedidoProcurado == null)
                {
                    return NotFound();
                }

                return Ok(pedidoProcurado);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        [HttpPost]

        public IActionResult Cadastrar(Pedido pedido)
        {
            try
            {
                _pedidoRepository.Cadastrar(pedido);

                return StatusCode(201);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult atualizar(int id, Pedido pedido)
        {
            try
            {
                _pedidoRepository.Atualizar(id, pedido);

                return StatusCode(204);

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            try
            {
                _pedidoRepository.Deletar(id);

                return StatusCode(204);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}

