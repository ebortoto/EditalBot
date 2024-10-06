using System;
using EditalBot.Aplicacao.Interfaces;
using EditalBot.Aplicacao.Models;
using Microsoft.AspNetCore.Mvc;

namespace EditalBot.Aplicacao.Services;

public class TelegramService : ITelegramService
{
    public ActionResult<Mensagem> SendMessage(Mensagem request)
    {

        throw new NotImplementedException();
    }
}
