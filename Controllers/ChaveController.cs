using Microsoft.AspNetCore.Mvc;
using Pix.Aplicacao.Services;
using Pix.Business.Models;

namespace PixAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChaveController : ControllerBase
    {
        private readonly ChaveService _chaveService;

        public ChaveController(ChaveService chaveService)
        {
            _chaveService = chaveService;
        }

        [HttpPost("register-key")]
        public IActionResult RegisterPixKey(Chave chave)
        {
            _chaveService.RegisterPixKey(chave);
            return Ok();
        }

        [HttpPost("make-payment")]
        public IActionResult MakePixPayment(Pagamento pagamento)
        {
            _chaveService.MakePixPayment(pagamento);
            return Ok();
        }

        [HttpGet("get-payments")]
        public IActionResult GetPixPayments(string nomeRecebedor)
        {
            var payments = _chaveService.GetPixPayments(nomeRecebedor);
            return Ok(payments);
        }
    }
}
