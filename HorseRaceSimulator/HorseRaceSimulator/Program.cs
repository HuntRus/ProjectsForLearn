using System.Text;

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
        static void Gamemenu()
        {
            string decisions = "0";
            while (decisions != "")
            {
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
 
        static void Main(string[] args)
        {
            RusLanguage();
            Startext();
            Continue_end(1);
            Gamemenu();
        }
    }
}