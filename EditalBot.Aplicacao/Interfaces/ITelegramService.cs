using System;
using EditalBot.Aplicacao.Models;
using Microsoft.AspNetCore.Mvc;

namespace EditalBot.Aplicacao.Interfaces;

public interface ITelegramService
{
    ActionResult<Mensagem> SendMessage(Mensagem request);
}