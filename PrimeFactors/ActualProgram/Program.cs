using Library;
using System.Text;

namespace ActualProgram
{
    internal class Program
    {
        static void RusLanguage()
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = Encoding.GetEncoding(1251);
        }
        static void Main(string[] args)
        {
            string answer;
            RusLanguage();
            do
            {
                Console.Write("Введите любое положительное число до 1000 включительно: ");
                try 
                {
                    int number = System.Convert.ToInt32(Console.ReadLine());
                    if (number > 1000)
                    {
                        throw new OverflowException(message: "Числа больше 1000 не обрабатываются программой!");
                    }
                    else if (number < 0)
                    {
                        throw new OverflowException(message: "Числа меньше 0 не обрабатываются программой!");
                    }
                    string formula = NumberFactors.PrimeFactors(number);
                    Console.WriteLine($"Простой множитель {number}: {formula}");
                }
                catch (FormatException) 
                {
                    Console.WriteLine("Программа выдаёт ошибку недопустимых форматов - в следующиий раз записывайте нужное число цифрами,а не буквами!");
                    throw;
                }
                do
                {
                    Console.Write("Хотите ли Вы попробовать ещё раз?(да/нет) ");
                    answer = Console.ReadLine();
                } while (answer != "да" && answer != "нет");
            } while (answer != "нет");
            
        }
    }
}