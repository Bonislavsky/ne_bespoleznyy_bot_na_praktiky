using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace bot_praktika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new TelegramBotClient("6439675597:AAFwmluVovJV8IDczEnIrfSR25AdvUZsxuc");
            client.StartReceiving(Update, Error);
            Console.ReadLine();
        }

        private static async Task Update(ITelegramBotClient client, Update update, CancellationToken token)
        {
            var message = update.Message;
            if (message.Text != null)
            {
                Console.WriteLine($"{message.Chat.FirstName} | {message.Text}");

                if (message.Text.ToLower().Equals("початок"))
                {
                    var replyKeyboard = new ReplyKeyboardMarkup(
                        new KeyboardButton[][]
                        {
                            ["кафедри", "осв. програма"],
                        });

                    await client.SendTextMessageAsync(
                        message.Chat.Id,
                        "оберете яку інформацію вам необхідно дізнатися",
                        replyMarkup: replyKeyboard);
                }
                else if(message.Text.Equals("кафедри"))
                {
                    var replyKeyboard = new ReplyKeyboardMarkup(
                       new KeyboardButton[][]
                       {
                            ["МIФ", "ФITM", "ФЖ"],
                            ["Початок"]
                       });

                    await client.SendTextMessageAsync(
                        message.Chat.Id,
                        "ось список кафедр",
                        replyMarkup: replyKeyboard);
                    return;
                }
                else if (message.Text.Equals("осв. програма"))
                {
                    var replyKeyboard = new ReplyKeyboardMarkup(
                        new KeyboardButton[][]
                        {
                            ["Перший (бакалаврський) рівень"],
                            ["Другий (магістерський) рівень"],
                            ["Третій (освітньо-науковий) рівень"],
                            ["бакалавр", "магістер"],
                        });

                    await client.SendTextMessageAsync(
                        message.Chat.Id,
                        "Ви обрали перегляд освiтньої програми. Виберiть який рiвень ви хочете переглянути:",
                        replyMarkup: replyKeyboard);
                    return;
                }              
                else if (message.Text.ToLower().Contains("серега пират"))
                {
                    var replyKeyboard = new ReplyKeyboardMarkup(
                        new KeyboardButton[][]
                        {
                            ["Початок"]
                        });

                    await client.SendTextMessageAsync(
                        message.Chat.Id,
                        $"Малолетние - https://www.youtube.com/watch?v=icmYeesBTRY"+
                        $"\nЯ КАК ВО СНЕ - https://www.youtube.com/watch?v=K3-d6IBAzaI" +
                        $"\nЯ поднимаю свою голову вверх - https://www.youtube.com/watch?v=zVHMOWIFWks" +
                        $"\nвайбмен - https://www.youtube.com/watch?v=YpMU3g8JLjw" +
                        $"\nапельсин - https://www.youtube.com/watch?v=Vr-DOV-TP5s" +
                        $"\nмой байк - https://www.youtube.com/watch?v=OQGdrezi0Y4" +
                        $"\nминёр - https://www.youtube.com/watch?v=dj8ShLXicak" +
                        $"\nКачалка - https://www.youtube.com/watch?v=7cIVLb9qPQY",
                        replyMarkup: replyKeyboard);
                    return;
                }
                
                else if (message.Text.Equals("МIФ"))
                {
                    var replyKeyboard = new ReplyKeyboardMarkup(
                        new KeyboardButton[][]
                        {
                            ["МIФ", "ФITM", "ФЖ"],
                            ["Початок"]
                        });

                    await client.SendTextMessageAsync(
                        message.Chat.Id, 
                        $"посилання на визiтiвку факультету музичного мистецтва і хореографії - https://fmmh.kubg.edu.ua/pro-fakultet/vizytivka.html"+
                        $"\n\nКонтакти:\r\n02154, Україна, м.Київ,\r\nбул. І. Шамо, 18/2\r\nтел.: (044) 295-34-68\r\ne-mail: fmmh@kubg.edu.ua\r\nПрофіль Google Scholar https://scholar.google.com.ua/citations?hl=uk&user=2-I6FoQAAAAJ",
                        replyMarkup: replyKeyboard);
                    return;
                }
                else if (message.Text.Equals("ФITM"))
                {
                    var replyKeyboard = new ReplyKeyboardMarkup(
                        new KeyboardButton[][]
                        {
                            ["МIФ", "ФITM", "ФЖ"],
                            ["Початок"]
                        });

                    await client.SendTextMessageAsync(
                        message.Chat.Id,
                        $"посилання на визiтiвку факультету інформаційних технологій та математики - https://fitm.kubg.edu.ua/pro-fakultet/vizytivka.html"+
                        $"\n\nКонтакти:\r\n04212, Україна, м.Київ,\r\nвул. Левка Лук'яненка, 13-Б\r\nтел.: (044) 428-34-14\r\ne-mail: fitm@kubg.edu.ua",
                        replyMarkup: replyKeyboard);
                    return;
                }
                else if (message.Text.Equals("ФЖ"))
                {
                    var replyKeyboard = new ReplyKeyboardMarkup(
                        new KeyboardButton[][]
                        {
                            ["МIФ", "ФITM", "ФЖ"],
                            ["Початок"]
                        });

                    await client.SendTextMessageAsync(
                        message.Chat.Id,
                        $"посилання на визiтiвку факультету журналістики - https://fj.kubg.edu.ua/pro-fakultet/vizytivka.html" +
                        $"\n\nКонтакти:\r\n04212, Україна, м.Київ,\r\nвул. Левка Лук'яненка, 13-Б, каб. 105\r\nтел.: (044) 485-21-62\r\ne-mail: fj@kubg.edu.ua",
                        replyMarkup: replyKeyboard);
                    return;
                }

                else if (message.Text.Equals("Перший (бакалаврський) рівень"))
                {
                    var replyKeyboard = new ReplyKeyboardMarkup(
                        new KeyboardButton[][]
                        {
                            ["Початок", "осв. програма"]
                        });

                    await client.SendTextMessageAsync(
                        message.Chat.Id, 
                        $"посилання на сторiнку де ви сможете дiзнатсия бiльше про перший (бакалаврський) рівень - https://fpsrso.kubg.edu.ua/struktura/kafedry-fakultetu/kafedra-praktychnoi-psykholohii/osvitni-prohramy/pershyi-bakalavrskyi-riven.html",
                        replyMarkup: replyKeyboard);
                    return;
                }
                else if (message.Text.Equals("Другий (магістерський) рівень"))
                {
                    var replyKeyboard = new ReplyKeyboardMarkup(
                        new KeyboardButton[][]
                        {
                           ["Початок", "осв. програма"]
                        });

                    await client.SendTextMessageAsync(
                        message.Chat.Id,
                        $"посилання на сторiнку де ви сможете дiзнатсия бiльше про другий (магістерський) рівеньь - https://fpsrso.kubg.edu.ua/struktura/kafedry-fakultetu/kafedra-praktychnoi-psykholohii/osvitni-prohramy/druhyi-mahisterskyi-riven.html",
                        replyMarkup: replyKeyboard);
                    return;
                }
                else if (message.Text.Equals("Перший (бакалаврський) рівень"))
                {
                    var replyKeyboard = new ReplyKeyboardMarkup(
                        new KeyboardButton[][]
                        {
                            ["Початок", "осв. програма"]
                        });

                    await client.SendTextMessageAsync(
                        message.Chat.Id,
                        $"посилання на сторiнку де ви сможете дiзнатсия бiльше про третій (освітньо-науковий) рівень - https://fpsrso.kubg.edu.ua/struktura/kafedry-fakultetu/kafedra-praktychnoi-psykholohii/osvitni-prohramy/tretii-osvitno-naukovyi-riven.html",
                        replyMarkup: replyKeyboard);
                    return;
                }
                else if (message.Text.Equals("бакалавр"))
                {
                    var replyKeyboard = new ReplyKeyboardMarkup(
                        new KeyboardButton[][]
                        {
                           ["Початок", "осв. програма"]
                        });

                    await client.SendTextMessageAsync(
                        message.Chat.Id,
                        $"посилання для ознайомлення з правилами вступу на бакалавра - https://kubg.edu.ua/informatsiya/vstupnikam/pravyla-pryiomu/465-arkhiv-2023/7975-pravyla-pryiomu-na-navchannia-dlia-zdobuttia-stupenia-bakalavra-mahistra.html",
                        replyMarkup: replyKeyboard);
                    return;
                }
                else if (message.Text.Equals("магістер"))
                {
                    var replyKeyboard = new ReplyKeyboardMarkup(
                        new KeyboardButton[][]
                        {
                           ["Початок", "осв. програма"]
                        });

                    await client.SendTextMessageAsync(
                        message.Chat.Id,
                        $"посилання для ознайомлення з правилами вступу на магiстра - https://kubg.edu.ua/informatsiya/vstupnikam/pravyla-pryiomu/465-arkhiv-2023/7975-pravyla-pryiomu-na-navchannia-dlia-zdobuttia-stupenia-bakalavra-mahistra.html",
                        replyMarkup: replyKeyboard);
                    return;
                }

                else
                {
                    var replyKeyboard = new ReplyKeyboardMarkup(
                        new KeyboardButton[][]
                        {
                            ["кафедри", "осв. програма"],
                        });

                    await client.SendTextMessageAsync(
                        message.Chat.Id,
                        "я не маю такої кнопки, будь-ласк виберiть з вже iснуючих",
                        replyMarkup: replyKeyboard);
                }
            }
        }

        private static Task Error(ITelegramBotClient client, Exception exception, CancellationToken token)
        {
            throw new NotImplementedException();
        }
    }
}