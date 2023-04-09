
using Telegram.Bot; using Telegram.Bot.Types;
using Telegram.Bot.Types.InputFiles;

// dotnet add package Telegram.Bot

TelegramBotClient client = new TelegramBotClient("6156474281:AAHn1K30DG9ALIQIwKoLIBVTQugjfKj5byo");

User user = await client.GetMeAsync();

Console.WriteLine(user.Username);

while (true)
{
    Update[] updates = await client.GetUpdatesAsync();

    for (int i = 0; i < updates.Length; i++) // цикл от i до updates.Length (длина получаемого массива сообщений)
    {
        Console.WriteLine(updates[i].Message.Text); // вывод в консоль полученных сообщений
        Console.WriteLine(updates[i].Message.From.FirstName); // вывод в консоль имя от кого получено сообщение
        Console.WriteLine(updates[i].Message.From.Username); // что делает данная строка ???

        await client.SendTextMessageAsync(updates[i].Message.From.Id, "Test text"); // отправка ответного сообщения на приходящее

        if (updates[i].Message.Text == "Привет") // если входящее сообщение Привет
        {
            await client.SendTextMessageAsync(updates[i].Message.From.Id, $"Привет {updates[i].Message.From.FirstName}"); // отправка ответного сообещния привет и имя от кого пришло сообщение
        }
    }
    if (updates.Length != 0) // учловие проверки если длина массива с сообщениями не равна 0
    {
        updates = await client.GetUpdatesAsync(updates[updates.Length - 1].Id + 1); // записываем в массив только послднее сообщение
    }
}


/*// выполняем команду в консоли чтобы подключить пакет для взаимодействия с ботом в телеграм
// dotnet add package Telegram.bot

// В телеграм ищем @BotFather, вводим /newbot в сообщения
// после вводим как будет называться бот
// после вводим уникальное имя бота и получаем его тикет
// https://t.me/test7054000_bot ссылка на тестовый бот
// для начала работы бота надо написать ему /start

// подключаем библиотеки
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.InputFiles;

// создаем объект бота и вводим ввиде параметра полученный выше тикет
TelegramBotClient client = new TelegramBotClient("5620437115:AAEcuPxNHSbWV_vEbgJVeGhdoGy1YLHiTSQ");

User user = await client.GetMeAsync(); // получаем имя бота

Console.WriteLine(user.Username); // выводим имя бота в консоль

while (true) // бесконечный цикл чтобы программа не останавливалась
{
    Update[] updates = await client.GetUpdatesAsync(); // создание массива типа update в который будут вноситься приходяшие в бот сообщения

    for (int i = 0; i < updates.Length; i++) // цикл от i до updates.Length (длина получаемого массива сообщений)
    {
        Console.WriteLine(updates[i].Message.Text); // вывод в консоль полученных сообщений
        Console.WriteLine(updates[i].Message.From.FirstName); // вывод в консоль имя от кого получено сообщение
        Console.WriteLine(updates[i].Message.From.Username); // что делает данная строка ???

        await client.SendTextMessageAsync(updates[i].Message.From.Id, "Test text"); // отправка ответного сообщения на приходящее

        if (updates[i].Message.Text == "Привет") // если входящее сообщение Привет
        {
            await client.SendTextMessageAsync(updates[i].Message.From.Id, $"Привет {updates[i].Message.From.FirstName}"); // отправка ответного сообещния привет и имя от кого пришло сообщение
        }
    }

    if (updates.Length != 0) // учловие проверки если длина массива с сообщениями не равна 0
    {
        updates = await client.GetUpdatesAsync(updates[updates.Length - 1].Id + 1); // записываем в массив только послднее сообщение
    }

}
}*/

