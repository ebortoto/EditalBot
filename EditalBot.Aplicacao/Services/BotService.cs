using System;
using EditalBot.Aplicacao.Interfaces;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace EditalBot.Aplicacao.Services;

public class BotService : IBotService
{
    TelegramBotClient _bot;
    CancellationTokenSource _cancellationTokenSource;
    public BotService()
    {
        // _bot = new TelegramBotClient("8130219422:AAE0OjUB3he0VqtZs5yGSFhm0JHKnxns7aQ");
        _cancellationTokenSource = new CancellationTokenSource();

        Console.WriteLine("Bot is running");

        // _bot.StartReceiving(
        //     new DefaultUpdateHandler(HandleUpdate, HandleError),
        //     cancellationToken: _cancellationTokenSource.Token
        // );
    }

    private Task HandleError(ITelegramBotClient client, Exception exception, CancellationToken token)
    {
        Console.WriteLine($"Error: {exception.Message}");
        return Task.CompletedTask;
    }

    private async Task HandleUpdate(ITelegramBotClient _, Update update, CancellationToken cancellationToken)
    {
        switch (update.Type)
        {
            // A message was received
            case UpdateType.Message:
                Console.WriteLine(update.Message?.From);
                // await HandleMessage(update.Message!);
                break;

            // A button was pressed
            case UpdateType.CallbackQuery:
                break;
        }
    }
}
