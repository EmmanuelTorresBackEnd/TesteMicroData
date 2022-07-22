using MicroDataAPI.Models;
using MicroDataAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace MicroDataAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
       
    [Produces("application/json")]

        [Route("api/[controller]")]

        [ApiController]
        public class UsuarioController : ControllerBase
        {
            private readonly ProdutoRepository _produtoRepository;

            public UsuarioController(ProdutoRepository produtoRepository)
            {
                _produtoRepository = produtoRepository;
            }

            [HttpGet]
            public IActionResult Listar()
            {

                try
                {
                    return Ok(_produtoRepository.Listar());
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }

            [HttpGet("{CodigoProduto}")]

            public IActionResult BuscarPorCodigoProduto(int CodigoProduto)
            {
                try
                {
                    Produto produtoProcurado = _produtoRepository.buscarPorCodigoProduto(CodigoProduto);

                    if (produtoProcurado == null)
                    {
                        return NotFound();
                    }

                    return Ok(produtoProcurado);
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }

            }

            [HttpPost]

            public IActionResult Cadastrar(Produto NovoProduto)
            {
                try
                {
                    _produtoRepository.Cadastrar(NovoProduto);

                    return StatusCode(201);
                }
                catch (Exception e)
                {

                    throw new Exception(e.Message);
                }
            }

            [HttpPut("{CodigoProduto}")]

            public IActionResult atualizar(int CodigoProduto, Produto user)
            {
                try
                {
                    _produtoRepository.Atualizar(CodigoProduto, user);

                    return StatusCode(204);
                }
                catch (Exception e)
                {

                    throw new Exception(e.Message);
                }
            }

            [HttpDelete("{CodigoProduto}")]

            public IActionResult Deletar(int CodigoProduto)
            {
                try
                {
                    _produtoRepository.Deletar(CodigoProduto);

                    return StatusCode(204);
                }
                catch (Exception e)
                {

                    throw new Exception(e.Message);
                }
            }
        }
    }
}
