using System;
using EditalBot.Aplicacao.Interfaces;
using EditalBot.Aplicacao.Models;

namespace EditalBot.Aplicacao.Services;

public class TelegramService : ITelegramService
{
    public readonly IBotService _botService;
    public TelegramService(IBotService botService)
    {
        _botService = botService;
    }

    public Mensagem SendMessage(Mensagem request)
    {
        return null;
    }
}
