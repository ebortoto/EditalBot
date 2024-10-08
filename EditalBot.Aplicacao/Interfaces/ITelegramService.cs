using System;
using EditalBot.Aplicacao.Models;

namespace EditalBot.Aplicacao.Interfaces;

public interface ITelegramService
{
    Mensagem SendMessage(Mensagem request);
}
