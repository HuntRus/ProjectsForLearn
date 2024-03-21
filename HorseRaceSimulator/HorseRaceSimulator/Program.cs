using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml.Serialization;

namespace HorseRaceSimulator
{
    internal class Program
    {
        static void RusLanguage()
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = Encoding.GetEncoding(1251);
        }
        static void Continue_end(int choice)
        {
            if (choice == 1)
            {
                Console.Write("Нажмите Enter,чтобы продолжить.");
                Console.ReadLine();
            }
            else if (choice == 2) 
            {
                Console.Write("Нажмите Enter,чтобы выйти...");
                Console.ReadLine();
            }
            
        }
        static string Yes_no(string message, string? answer = "")
        {
            do
            {
                Console.Write(message + " ");
                answer = Console.ReadLine();
            } while (answer != "да" && answer != "нет");
            Console.WriteLine();
            return answer;
        }
        static void text(string document)
        {
            StreamReader doc = new StreamReader($"C:\\Code\\ProjectsForLearn\\HorseRaceSimulator\\TextFiles\\{document}");
            string text = doc.ReadToEnd();
            Console.WriteLine();
            Console.Write(text);
            doc.Close();
        }
        static void Startext()
        {
            Console.WriteLine(@"Добро пожаловать в симулятор скачек!
В этом несерьёзном симуляторе Вам предстоит сыграть за оголтелого любителя ставок на скачки лошадей.
Ваша единственная задача — это не проиграть все деньги и не влезть в долги.");

            string answer = Yes_no("\nХотите ли Вы ознакомиться с некоторыми особенностями перед началом игры?(да/нет)");
            if (answer == "да")
            {
                text("Rules.txt");
            }
        }
        static void Gamemenu(string decisions = "0",decimal balance = 200, decimal censor = 0 )
        {
            while (decisions != "")
            {
                if (decisions == "0")
                {
                    balance = 200;
                }
                if (decisions != "0")
                {
                    Console.WriteLine("\n-------------------------------------------------------------------------------");
                    Console.WriteLine($"Баланс - {balance}");
                    Console.WriteLine("-------------------------------------------------------------------------------");
                }
                
                switch (decisions)
                {
                    
                    case "0111":  
                        balance = Raceprocess(
              Horse("flat", 3, 5, 7), "Мираж",
              Horse("flat", 5, 9, 3), "Изумруд",
              Horse("flat", 6, 4, 2), "Янтарь",
              Horse("flat", 3, 5, 5), "Аврора",
              Horse("flat", 4, 4, 3), "Скарлет",
              Horse("flat", 6, 3, 1), "Дакота",
              balance,false);
                        decisions = decisions.Remove(decisions.Length - 1);
                        break;
                    
                    case "01126":
                        censor = 300;
                        if (balance < censor)
                        {
                            Console.WriteLine($"Извините,но Вы не проходите финансовый ценз - на вашем балансе недостаточно средств (требуется не менее {censor})."); 
                        }
                        else
                        {
                            balance = Raceprocess(
              Horse("flat", 5, 5, 5), "Джоконда",
              Horse("flat", 7, 4, 3), "Бархат",
              Horse("flat", 7, 4, 4), "Молния",
              Horse("flat", 7, 7, 4), "Вираж",
              Horse("flat", 7, 2, 4), "Рассвет",
              Horse("flat", 6, 4, 4), "Кайто",
              balance, false);
                        }                       
                        decisions = decisions.Remove(decisions.Length - 1);
                        break;

                    case "01125":
                        censor = 500;
                        if (balance < censor)
                        {
                            Console.WriteLine($"Извините,но Вы не проходите финансовый ценз - на вашем балансе недостаточно средств (требуется не менее {censor}).");
                        }
                        else
                        {
                            balance = Raceprocess(
              Horse("flat", 5, 5, 6), "Аметист",
              Horse("flat", 6, 5, 5), "Буря",
              Horse("flat", 4, 3, 8), "Закат",
              Horse("flat", 6, 1, 6), "Ника",
              Horse("flat", 7, 7, 5), "Кураж",
              Horse("flat", 6, 5, 4), "Искра",
              balance, false);
                        }                       
                        decisions = decisions.Remove(decisions.Length - 1);
                        break;

                    case "01124":
                        censor = 1000;
                        if (balance < censor)
                        {
                            Console.WriteLine($"Извините,но Вы не проходите финансовый ценз - на вашем балансе недостаточно средств (требуется не менее {censor}).");
                        }
                        else
                        {
                            balance = Raceprocess(
                                          Horse("flat", 6, 3, 6), "Победа",
                                          Horse("flat", 5, 6, 7), "Шторм",
                                          Horse("flat", 8, 3, 4), "Талисман",
                                          Horse("flat", 10, 1, 2), "Ветерок",
                                          Horse("flat", 4, 2, 9), "Орхидея",
                                          Horse("flat", 7, 6, 5), "Империя",
                                          balance, false);
                        }                       
                        decisions = decisions.Remove(decisions.Length - 1);
                        break;

                    case "01123":
                        censor = 1500;
                        if (balance < censor)
                        {
                            Console.WriteLine($"Извините,но Вы не проходите финансовый ценз - на вашем балансе недостаточно средств (требуется не менее {censor}).");
                        }
                        else
                        {
                            balance = Raceprocess(
              Horse("flat", 9, 3, 3), "Гром",
              Horse("flat", 8, 5, 3), "Буян",
              Horse("flat", 8, 4, 4), "Азарт",
              Horse("flat", 6, 6, 7), "Калипсо",
              Horse("flat", 7, 7, 7), "Мечта",
              Horse("flat", 5, 3, 9), "Аделия",
              balance, false);
                        }
                        decisions = decisions.Remove(decisions.Length - 1);
                        break;

                    case "01122":
                        censor = 3000;
                        if (balance < censor)
                        {
                            Console.WriteLine($"Извините,но Вы не проходите финансовый ценз - на вашем балансе недостаточно средств (требуется не менее {censor}).");
                        }
                        else
                        {
                            balance = Raceprocess(
              Horse("flat", 10, 4, 4), "Вавилон",
              Horse("flat", 9, 5, 5), "Оствинд",
              Horse("flat", 8, 3, 6), "Пегас",
              Horse("flat", 7, 8, 7), "Амур",
              Horse("flat", 7, 2, 8), "Альтаир",
              Horse("flat", 6, 6, 8), "Камелот",
              balance, false);
                        }
                        decisions = decisions.Remove(decisions.Length - 1);
                        break;

                    case "011214":
                        censor = 5000;
                        if (balance < censor)
                        {
                            Console.WriteLine($"Извините,но Вы не проходите финансовый ценз - на вашем балансе недостаточно средств (требуется не менее {censor}).");
                        }
                        else
                        {
                            balance = Raceprocess(
              Horse("flat", 8, 6, 7), "Гамма",
              Horse("flat", 6, 7, 8), "Океания",
              Horse("flat", 7, 5, 9), "Заниэль",
              Horse("flat", 6, 3, 10), "Дамбо",
              Horse("flat", 5, 5, 10), "Эверест",
              Horse("flat", 6, 9, 8), "Фалере",
              balance, false);
                        }
                        decisions = decisions.Remove(decisions.Length - 1);
                        break;

                    case "011213":
                        censor = 5000;
                        if (balance < censor)
                        {
                            Console.WriteLine($"Извините,но Вы не проходите финансовый ценз - на вашем балансе недостаточно средств (требуется не менее {censor}).");
                        }
                        else
                        {
                            balance = Raceprocess(
              Horse("flat", 8, 8, 8), "Бета",
              Horse("flat", 9, 8, 7), "Овация",
              Horse("flat", 7, 8, 9), "Завет",
              Horse("flat", 9, 10, 6), "Дампо",
              Horse("flat", 10, 10, 4), "Икар",
              Horse("flat", 5, 5, 10), "Даймонд",
              balance, false);
                        }
                        decisions = decisions.Remove(decisions.Length - 1);
                        break;

                    case "011212":
                        censor = 15000;
                        if (balance < censor)
                        {
                            Console.WriteLine($"Извините,но Вы не проходите финансовый ценз - на вашем балансе недостаточно средств (требуется не менее {censor}).");
                        }
                        else
                        {
                            balance = Raceprocess(
              Horse("flat", 9, 10, 8), "Альфа",
              Horse("flat", 8, 8, 9), "Венера",
              Horse("flat", 7, 7, 10), "Сапфира",
              Horse("flat", 10, 8, 6), "Барон",
              Horse("flat", 6, 10, 10), "Алтай",
              Horse("flat", 8, 9, 7), "Бальтазар",
              balance, false);
                        }
                        decisions = decisions.Remove(decisions.Length - 1);
                        break;

                    case "011211":
                        censor = 50000;
                        if (balance < censor)
                        {
                            Console.WriteLine($"Извините,но Вы не проходите финансовый ценз - на вашем балансе недостаточно средств (требуется не менее {censor}).");
                        }
                        else
                        {
                            balance = Raceprocess(
              Horse("flat", 8, 10, 10), "Буцефал",
              Horse("flat", 10, 10, 8), "Ангел",
              Horse("flat", 9, 10, 9), "Восток",
              Horse("flat", 9, 9, 9), "Легенда",
              Horse("flat", 10, 9, 10), "Дымка",
              Horse("flat", 10, 10, 10), "Луна",
              balance, false);
                        }
                        decisions = decisions.Remove(decisions.Length - 1);
                        break;

                        case "0121":  
                        balance = Raceprocess(
              Horse("flat", 2, 2, 3), "Дунечка",
              Horse("flat", 3, 3, 2), "Орлик",
              Horse("flat", 2, 1, 5), "Глория",
              Horse("flat", 2, 3, 3), "Сахара",
              Horse("flat", 3, 2, 3), "Гонец",
              Horse("flat", 2, 4, 2), "Эльдорадо",
              balance, false);
                        decisions = decisions.Remove(decisions.Length - 1);
                        break;

                    case "0122":
                        balance = Raceprocess(
              Horse("jumps", 4, 4, 4), "Дукат",
              Horse("jumps", 5, 3, 4), "Васко",
              Horse("jumps", 3, 6, 3), "Вольф",
              Horse("jumps", 4, 6, 2), "Флавий",
              Horse("jumps", 4, 3, 5), "Галеон",
              Horse("jumps", 5, 5, 2), "Хмель",
              balance, false);
                        decisions = decisions.Remove(decisions.Length - 1);
                        break;

                    case "01236":
                        censor = 300;
                        if (balance < censor)
                        {
                            Console.WriteLine($"Извините,но Вы не проходите финансовый ценз - на вашем балансе недостаточно средств (требуется не менее {censor}).");
                        }
                        else
                        {
                            balance = Raceprocess(
              Horse("jumps", 3, 5, 5), "Иней",
              Horse("jumps", 5, 3, 5), "Валет",
              Horse("jumps", 4, 6, 3), "Орион",
              Horse("jumps", 5, 5, 3), "Чад",
              Horse("jumps", 6, 1, 6), "Маркаб",
              Horse("jumps", 5, 6, 2), "Викинг",
              balance, false);
                        }
                        decisions = decisions.Remove(decisions.Length - 1);
                        break;

                    case "01235":
                        censor = 500;
                        if (balance < censor)
                        {
                            Console.WriteLine($"Извините,но Вы не проходите финансовый ценз - на вашем балансе недостаточно средств (требуется не менее {censor}).");
                            
                        }
                        else
                        {
                            balance = Raceprocess(
              Horse("jumps", 3, 5, 6), "Павлин",
              Horse("jumps", 4, 4, 6), "Саиф",
              Horse("jumps", 4, 6, 4), "Водолей",
              Horse("jumps", 5, 5, 4), "Индеец",
              Horse("jumps", 6, 2, 6), "Рокки",
              Horse("jumps", 5, 6, 3), "Кварц",
              balance, false);
                        }
                        decisions = decisions.Remove(decisions.Length - 1);
                        break;

                    case "01234":
                        censor = 1000;
                        if (balance < censor)
                        {
                            Console.WriteLine($"Извините,но Вы не проходите финансовый ценз - на вашем балансе недостаточно средств (требуется не менее {censor}).");
                        }
                        else
                        {
                            balance = Raceprocess(
              Horse("jumps", 6, 4, 5), "Кохаб",
              Horse("jumps", 5, 5, 5), "Орёл",
              Horse("jumps", 5, 4, 6), "Стрелец",
              Horse("jumps", 6, 3, 6), "Центавр",
              Horse("jumps", 7, 4, 4), "Арнольд",
              Horse("jumps", 4, 5, 6), "Топаз",
              balance, false);
                        }
                        decisions = decisions.Remove(decisions.Length - 1);
                        break;

                    case "01233":
                        censor = 2500;
                        if (balance < censor)
                        {
                            Console.WriteLine($"Извините,но Вы не проходите финансовый ценз - на вашем балансе недостаточно средств (требуется не менее {censor}).");
                        }
                        else
                        {
                            balance = Raceprocess(
              Horse("jumps", 6, 5, 5), "Цезарь",
              Horse("jumps", 5, 6, 5), "Варяг",
              Horse("jumps", 5, 5, 6), "Нимб",
              Horse("jumps", 3, 5, 8), "Султан",
              Horse("jumps", 6, 4, 6), "Герцог",
              Horse("jumps", 6, 6, 4), "Князь",
              balance, false);
                        }
                        decisions = decisions.Remove(decisions.Length - 1);
                        break;

                    case "01232":
                        censor = 5000;
                        if (balance < censor)
                        {
                            Console.WriteLine($"Извините,но Вы не проходите финансовый ценз - на вашем балансе недостаточно средств (требуется не менее {censor}).");
                        }
                        else
                        {
                            balance = Raceprocess(
              Horse("jumps", 7, 5, 6), "Овен",
              Horse("jumps", 4, 6, 8), "Елисей",
              Horse("jumps", 8, 5, 5), "Нефрит",
              Horse("jumps", 6, 6, 6), "Аид",
              Horse("jumps", 3, 5, 10), "Туман",
              Horse("jumps", 4, 9, 5), "Утёс",
              balance, false);
                        }
                        decisions = decisions.Remove(decisions.Length - 1);
                        break;

                    case "012314":
                        censor = 10000;
                        if (balance < censor)
                        {
                            Console.WriteLine($"Извините,но Вы не проходите финансовый ценз - на вашем балансе недостаточно средств (требуется не менее {censor}).");
                        }
                        else
                        {
                            balance = Raceprocess(
              Horse("jumps", 8, 6, 6), "Ворон",
              Horse("jumps", 7, 9, 5), "Козерог",
              Horse("jumps", 8, 8, 5), "Персей",
              Horse("jumps", 7, 7, 7), "Нептун",
              Horse("jumps", 5, 8, 8), "Тихон",
              Horse("jumps", 10, 1, 10), "Гигант",
              balance, false);
                        }
                        decisions = decisions.Remove(decisions.Length - 1);
                        break;

                    case "012313":
                        censor = 20000;
                        if (balance < censor)
                        {
                            Console.WriteLine($"Извините,но Вы не проходите финансовый ценз - на вашем балансе недостаточно средств (требуется не менее {censor}).");
                        }
                        else
                        {
                            balance = Raceprocess(
              Horse("jumps", 9, 6, 9), "Гермес",
              Horse("jumps", 7, 7, 10), "Садко",
              Horse("jumps", 4, 10, 10), "Исполин",
              Horse("jumps", 10, 10, 4), "Аллегро",
              Horse("jumps", 8, 8, 8), "Рубин",
              Horse("jumps", 8, 7, 9), "Галат",
              balance, false);
                        }
                        decisions = decisions.Remove(decisions.Length - 1);
                        break;

                    case "012312":
                        censor = 50000;
                        if (balance < censor)
                        {
                            Console.WriteLine($"Извините,но Вы не проходите финансовый ценз - на вашем балансе недостаточно средств (требуется не менее {censor}).");
                        }
                        else
                        {
                            balance = Raceprocess(
              Horse("jumps", 8, 9, 10), "Феникс",
              Horse("jumps", 7, 10, 10), "Зевс",
              Horse("jumps", 7, 10, 9), "Барин",
              Horse("jumps", 10, 9, 7), "Престо",
              Horse("jumps", 8, 10, 8), "Титан",
              Horse("jumps", 9, 9, 9), "Рекорд",
              balance, false);
                        }
                        decisions = decisions.Remove(decisions.Length - 1);
                        break;

                    case "012311":
                        censor = 100000;
                        if (balance < censor)
                        {
                            Console.WriteLine($"Извините,но Вы не проходите финансовый ценз - на вашем балансе недостаточно средств (требуется не менее {censor}).");
                        }
                        else
                        {
                            balance = Raceprocess(
              Horse("jumps", 10, 10, 9), "Платон",
              Horse("jumps", 10, 10, 10), "Аристотель",
              Horse("jumps", 9, 9, 10), "Сенека",
              Horse("jumps", 10, 9, 10), "Сократ",
              Horse("jumps", 8, 10, 10), "Гераклит",
              Horse("jumps", 10, 9, 9), "Протагор",
              balance, false);
                        }
                        decisions = decisions.Remove(decisions.Length - 1);
                        break;






                }
                try { text(decisions + ".txt"); }
                catch (IOException)
                {
                    Console.WriteLine("Извините,но такого пункта в меню не существует.Возвращаем Вас в главное меню...");
                    decisions = "0";
                    continue;
                }
                string? answer = Console.ReadLine();
                if (answer == "0")
                {
                    decisions = decisions.Remove(decisions.Length - 1);
                    continue;
                }
                decisions += answer;
                if (decisions == "02")
                {
                    text("Rules.txt");
                    decisions = decisions.Remove(decisions.Length - 1);
                    Continue_end(1);
                    continue;
                }
                
            }
        }

        static decimal[] Horse (string type_race,int speed,int jumping,int endurance,int multiply = 0)
        {
            int sum = 0;
            decimal[] abilities = new decimal[3];
            if (type_race == "flat")
            {
                sum = speed + endurance;       
            }
            else if (type_race == "jumps")
            {
                sum = speed + jumping + endurance;
            }
            abilities = new decimal[] { (decimal)sum, (decimal)speed, (decimal)jumping, (decimal)endurance, multiply };
            return abilities;
        }
        static decimal Raceprocess(decimal[] horse1,string horse_name1, decimal[] horse2, string horse_name2, decimal[] horse3, string horse_name3, decimal[] horse4, string horse_name4,
             decimal[] horse5, string horse_name5, decimal[] horse6, string horse_name6,decimal balance,bool flat)
        {
            var chance = new Random();
            decimal multiply = 0;
            decimal[][] horseArray = { horse1, horse2, horse3, horse4, horse5, horse6 };
            string[] horseNames = { horse_name1, horse_name2, horse_name3, horse_name4, horse_name5, horse_name6 };
            decimal[] horsesSum = new decimal[6];
            for (int i = 0,j = 0; i < horseArray.Length; i++) 
            {
               horsesSum[i] = horseArray[i][j];

            }
            decimal maxSum = horsesSum.Max();
            for (int i = 0, j = 0; i < horseArray.Length; i++)
            { 
               if (maxSum - horseArray[i][j] == 0)
                {
                    horseArray[i][4] = chance.Next(1,3) + Math.Round((decimal)chance.NextDouble(),2);
                }
               else if(maxSum  - horseArray[i][j] == 1) 
                {
                    horseArray[i][4] = 3 + Math.Round((decimal)chance.NextDouble(),2);
                }
                else if (maxSum - horseArray[i][j] == 2)
                {
                    horseArray[i][4] = chance.Next(4,7) + Math.Round((decimal)chance.NextDouble(),2);
                }
                else
                {
                    horseArray[i][4] = chance.Next(6,8) + Math.Round((decimal)chance.NextDouble(),2);
                }
                if (i == 0) { Console.WriteLine("0 - Выйти из игры"); }
                Console.WriteLine($"{i + 1} - {horseNames[i]} (коэф. {horseArray[i][4]})");
            }
            int choice = 7;
            do
            {
                try
                {
                    Console.Write("Введите нужный пункт: ");
                    choice = System.Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ваш ответ должен состоять только из цифр!Попробуйте ещё раз.");
                    continue;
                }
                if (choice < 0 || choice > 6)
                {
                    Console.WriteLine("Таких пунктов нет среди выбора лошадей.Посмотрите внимательно на нумерацию и пропробуйте ещё раз.");
                    continue;
                }
                else if (choice == 0)
                {
                    break;
                }
                else
                {
                    string? answer = Yes_no($"Вы хотите поставить на лошадь по имени {horseNames[choice - 1]} c коэффициентом {horseArray[choice-1][4]}?(да/нет)");
                    if (answer == "да")
                    {
                        multiply = horseArray[choice - 1][4];
                        decimal bet = 0;
                        try
                        {
                            Console.Write("Какую сумму Вы хотите поставить? ");
                            bet = System.Convert.ToInt32(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Ваш ответ должен состоять только из цифр!Попробуйте ещё раз.");
                            continue;
                        }
                        if (bet < 0 || bet > balance)
                        {
                            Console.WriteLine("У вас недостаточно средств на счету (возможно,Вы ввели отрицательное число в поле ставок).");
                            continue;
            }
                        else
                        {
                            var random = new Random();
                            string[] mapNames = {"Московском ипподроме", "Лондонском стадионе Уэмбли", "Манхэттенской Horse-клубе","Техасском ранчо имени Рокфеллера",
                                "Канадской площадке любителей лошадей","Парижском ипподроме","Гарвардском поле для состязаний","стадионе Сантьяго Бернабеу в Мадриде",
                                "Сиднейском заповеднике" };
                            string[] weatherConditions = { "солнечно", "туманно", "пасмурно", "дождливо", "идёт снегопад","аномальная жара" };
                            int hurdle_amount;
                            if (flat == true)
                            {
                                hurdle_amount = 0;
        }
                            else
                            {
                                hurdle_amount = random.Next(4,16);
                            }
                            balance -= bet;

                            Console.WriteLine("\nВаша ставка принята.Игра начинается...");
                            Continue_end(1);
                            bool win = Map(mapNames[random.Next(9)], weatherConditions[random.Next(6)],random.Next(450,1501),hurdle_amount,horseArray,horseNames,choice-1);
                            if (win == true)
                            {
                                balance += bet * multiply;
                                Console.WriteLine("\n-------------------------------------------------------------------------------");
                                Console.WriteLine($"Поздравляю!Ваша ставка выиграла.Теперь у вас на счету {balance}.");
                            }
                            else 
                            {
                                Console.WriteLine("\n-------------------------------------------------------------------------------");
                                Console.WriteLine($"Сожалеем!Ваша ставка проиграла.Теперь у вас на счету {balance}."); 
                            }
                        }
                    }
                }
                Console.WriteLine("Нажмите Enter,чтобы вернуться в меню скачек.");
                Console.ReadLine();

            } while (choice !> 7 && choice !< 0);
            return balance;
        }

        static bool Map(string name,string weather,int distance,int hurdle_amount, decimal[][] horseArray, string[] horseNames,int choice)
        {
            var random = new Random();
            int hurdle_diff;
            bool[] hurdle_moments = { false,false,false,true, false, false,false,false, false,false,false,true,false,false,false,false,false,false };
            bool[] lucky_moments = {false, false, false, true,false, false,false, false, false, false, false, false,false, true,false, false, false, false,false };
            decimal[] horseRaceProgress = new decimal[6];
            decimal[] sortedHorseRaceProgress = new decimal[6];
            int[] horseSpeedBurst = new int[6];
            int[] horseEnduranceBurst = new int[6];
            Console.WriteLine($"\nДобро пожаловать на арену скачек!Здесь представлены лучшие лошади выбранной категории.Сегодня мы находимся на {name}.На улице сейчас {weather}.");
            Console.WriteLine($"Очень надеюсь,что это не помешает нашим конкурсантам в сегодняшнем забеге.Всё-таки испытание им предстоит очень трудное - преодолеть {distance} метров.");
            Console.WriteLine("Процесс скачек очень прост:всё,что Вам нужно сделать - жать Enter каждую секунду,чтобы наблюдать за этим чудесным спортивным состязанием.");
            Continue_end(1);
            Console.Write("\n-------------------------------------------------------------------------------");
            Console.WriteLine("\nГонка началась!");
            Console.Write("-------------------------------------------------------------------------------");
            int index;
            do
            {
                int first = 0;
                int second = 0;
                int third = 0;
                int fourth = 0;
                int fifth = 0;
                int sixth = 0;

                bool hurdle_moment = hurdle_moments[random.Next(hurdle_moments.Length)];
                for (index = 0;index < horseArray.Length;index++)
                {
                    if (horseArray[index][1] == 1)
                    {
                        horseSpeedBurst[index] += 1;
                        if (horseSpeedBurst[index] == 10)
                        {
                            horseArray[index][1] += random.Next(1, 5);
                            horseSpeedBurst[index] = 0;
                        }
                    }
                    if (horseArray[index][3] <= 0.5M)
                    {
                        horseEnduranceBurst[index] += 1;
                        if (horseEnduranceBurst[index] == 10)
                        {
                            horseArray[index][3] += random.Next(1, 6);
                            horseEnduranceBurst[index] = 0;
                        }
                    }

                    if (horseArray[index][3] <= 0 & horseArray[index][1] != 1)
                    {
                        horseArray[index][1] -= 1;
                    }
                    decimal speed = horseArray[index][1] * 2;
                    horseRaceProgress[index] += speed;
                    if ((weather == "солнечно" || weather == "пасмурно") & horseArray[index][3] > 0)
                    {
                        horseArray[index][3] -= 0.1M;
                    }
                    else if ((weather == "дождливо" || weather == "идёт снегопад") & horseArray[index][3] > 0)
                    {
                        horseArray[index][3] -= 0.3M;
                    }
                    else if (weather == "аномальная жара" & horseArray[index][3] > 0)
                    {
                        horseArray[index][3] -= 0.5M;
                    }
                    else if (weather == "туманно")
                    {
                        horseArray[index][1] -= 2;
                        if (horseArray[index][1] <= 0)
                        {
                            horseArray[index][1] = 1;
                        }
                        if (index == 0)
                        {
                            Console.WriteLine("\nГустой туман мешает лошадям двигаться вперёд.Жеребцы замедляют свой ход.");
                        }        
                        if (horseArray.Length - index == 1)
                        {                   
                            weather = "солнечно";
                        }  
                    }
                    if (horseArray[index][3] < 0)
                    {
                        horseArray[index][3] = 0;
                    }
                    if (hurdle_moment == true && hurdle_amount > 0)
                    {
                        hurdle_diff = random.Next(11);
                        if (index == 0)
                        {
                            Console.WriteLine("\nВпереди - препятствие!Посмотрим,насколько наши лошадки хороши в прыжках на бегу.");
                        }
                        if (horseArray[index][2] >= hurdle_diff) 
                        { 
                            Console.Write($"Лошадь {horseNames[index]} успешно перепрыгивает препятствие и двигается дальше! Её боевой дух поднялся. ");
                            horseArray[index][3] += 0.5M;
                            if (lucky_moments[random.Next(lucky_moments.Length)] == true)
                            {
                                horseArray[index][1] += 2;
                                Console.WriteLine("Лошадь открывает второе дыхание!");
                            }
                            else
                            {
                                Console.WriteLine();
                            }
                            
                        }
                        else
                        {
                            Console.WriteLine($"Лошадь {horseNames[index]} неудачно сталкивается с препятствием,теряя в скорости и выносливости. ");
                            if (horseArray[index][3] > 0)
                            {
                                horseArray[index][3] -= 1;
                            }
                            else if (horseArray[index][3] <= 0 & horseArray[index][1] != 1)
                            {
                                horseArray[index][1] -= 1;
                            }
                             
                        }
                    }
                    
                    
                }
                if (hurdle_moment == true & hurdle_amount != 0)
                {
                    hurdle_amount -= 1;
                    Continue_end(1);
                }
                Console.WriteLine("\nКоличество препятствий на забеге - " + hurdle_amount);
                for (index = 0;index < horseRaceProgress.Length;index++)
                {
                    if (horseRaceProgress[index] == horseRaceProgress.Max())
                    {
                        first = index;
                        Console.WriteLine($"\nЛошадка {horseNames[index]} вырывается вперёд,пробегая {horseRaceProgress[index]} метров. ");                        
                        break;
                    }

                }  
                for (index = 0; index < horseRaceProgress.Length;index++)
                {
                    sortedHorseRaceProgress = horseRaceProgress.OrderByDescending(i => i).ToArray();
                    if (horseRaceProgress[index] == sortedHorseRaceProgress[1])
                    {
                        if (index == first)
                        {
                            continue;
                        }
                        second = index;
                        Console.WriteLine($"За ней следом мчится {horseNames[index]} ({horseRaceProgress[index]}м). ");
                        break;
                    }
                }
                for (index = 0; index < horseRaceProgress.Length;index++)
                {
                    sortedHorseRaceProgress = horseRaceProgress.OrderByDescending(i => i).ToArray();
                    if (horseRaceProgress[index] == sortedHorseRaceProgress[2])
                    {
                        if (index == first || index == second)
                        {
                            continue;
                        }
                        third = index;
                        Console.WriteLine($"На третьем месте пока находится лошадка {horseNames[index]} ({horseRaceProgress[index]}м). ");
                        break;
                    }
                }
                for (index = 0; index < horseRaceProgress.Length;index++)
                {
                    sortedHorseRaceProgress = horseRaceProgress.OrderByDescending(i => i).ToArray();
                    if (horseRaceProgress[index] == sortedHorseRaceProgress[3])
                    {
                        if (index == first || index == second || index == third)
                        {
                            continue;
                        }
                        fourth = index;
                        Console.WriteLine($"На четвёртом месте - {horseNames[index]} ({horseRaceProgress[index]}м). ");
                        break;
                    }
                }
                for (index = 0; index < horseRaceProgress.Length;index++)
                {
                    sortedHorseRaceProgress = horseRaceProgress.OrderByDescending(i => i).ToArray();
                    if (horseRaceProgress[index] == sortedHorseRaceProgress[4])
                    {
                        if (index == first || index == second || index == third || index == fourth)
                        {
                            continue;
                        }
                        fifth = index;
                        Console.WriteLine($"На пятом -  {horseNames[index]} ({horseRaceProgress[index]}м). ");
                        break;
                    }
                }
                for (index = 0; index < horseRaceProgress.Length;index++)
                {
                    sortedHorseRaceProgress = horseRaceProgress.OrderByDescending(i => i).ToArray();
                    if (horseRaceProgress[index] == sortedHorseRaceProgress[5])
                    {
                        if (index == first || index == second || index == third || index == fourth || index == fifth)
                        {
                            continue;
                        }
                        sixth = index;
                        Console.Write($"В самом конце еле плетётся {horseNames[index]},прошедшая на данный момент {horseRaceProgress[index]}м.");
                        Console.ReadLine();
                        break;
                    }
                }
                if (horseRaceProgress.Max() >= distance)
                {
                    Console.WriteLine($"\nПобедил(а) {horseNames[first]}!");
                }
                
            } while (horseRaceProgress.Max() <= distance);

            if (horseRaceProgress.Max() == horseRaceProgress[choice])
            {
                
                return true;
            }
            else { return false; }
            

        }

 
        static void Main(string[] args)
        {
            RusLanguage();
            Startext();
            Continue_end(1);
            Gamemenu();
        }
    }
}