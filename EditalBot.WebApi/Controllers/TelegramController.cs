using EditalBot.Aplicacao.Interfaces;
using EditalBot.Aplicacao.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EditalBot.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TelegramController : ControllerBase
    {
        public readonly ITelegramService _telegramService;

        public TelegramController(ITelegramService telegramService)
        {
            _telegramService = telegramService;
        }

        [HttpPost]
        public IActionResult EnviarMensagem([FromBody] Mensagem mensagem)
        {
            _telegramService.SendMessage(mensagem);
            return Ok();
        }
    }
}
