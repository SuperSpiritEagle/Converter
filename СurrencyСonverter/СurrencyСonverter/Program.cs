using System;

namespace СurrencyСonverter
{
    class Program
    {

        static void Main(string[] args)
        {
            const string KeyOne = "1";
            const string KeyTwo = "2";
            const string KeyThree = "3";
            const string KeyFour = "4";
            int rubToUsd = 70;
            int usdToRub = 70;
            int eurToRub = 74;
            int rubToEur = 74;
            float rub;
            float usd;
            float eur;
            float currencyCount;
            string userInput;
            string exitLoop = "exit";
            
            Console.WriteLine("Обменник валют");
            Console.Write("Введите баланс рублей: ");
            rub = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите баланс доларов: ");
            usd = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите баланс евро: ");
            eur = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine($"{KeyOne} - обменять рубли на доллары");
            Console.WriteLine($"{KeyTwo} - обменять доллары на рубли");
            Console.WriteLine($"{KeyThree} - обменять евро на рубли");
            Console.WriteLine($"{KeyFour} - обменять рубли на евро");
            Console.WriteLine($"Для выхода из программы введите  {exitLoop}");

            userInput = Console.ReadLine();

            while (userInput != exitLoop)
            {
                switch (userInput)
                {
                    case KeyOne:
                        Console.WriteLine("Обмен рублей на доллары ");
                        Console.Write("Сколько вы хотите обменять ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (rub >= currencyCount)
                        {
                            rub -= currencyCount;
                            usd += currencyCount / rubToUsd;
                        }
                        else
                        {
                            Console.WriteLine("No money no honey");
                        }
                        break;
                    case KeyTwo:
                        Console.WriteLine("Обмен долларов на рубли");
                        Console.Write("Сколько вы хотите обменять: ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (usd >= currencyCount)
                        {
                            usd -= currencyCount;
                            rub += currencyCount * usdToRub;
                        }
                        else
                        {
                            Console.WriteLine("No money no honey");
                        }
                        break;
                    case KeyThree:
                        Console.WriteLine("Обмен евро на рубли");
                        Console.Write("Сколько вы хотите обменять: ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (eur >= currencyCount)
                        {
                            eur -= currencyCount;
                            rub += currencyCount * eurToRub;
                        }
                        else
                        {
                            Console.WriteLine("No money no honey");
                        }
                        break;
                    case KeyFour:
                        Console.WriteLine("Обмен рубли на евро");
                        Console.Write("Сколько вы хотите обменять: ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (rub >= currencyCount)
                        {
                            rub -= currencyCount;
                            eur += currencyCount / rubToEur;
                        }
                        else
                        {
                            Console.WriteLine("No money no honey");
                        }
                        break;
                }

                string rubFormat = string.Format("{0:f}", rub);
                string usdFormat = string.Format("{0:f}", usd);
                string eurFormat = string.Format("{0:f}", eur);

                Console.WriteLine($"Ваш баланс {rubFormat} рублей {usdFormat} долларов и {eurFormat} евро");
                Console.WriteLine($"{KeyOne} - обменять рубли на доллары");
                Console.WriteLine($"{KeyTwo} - обменять доллары на рубли");
                Console.WriteLine($"{KeyThree} - обменять евро на рубли");
                Console.WriteLine($"{KeyFour} - обменять рубли на евро");
                Console.WriteLine($"Для выхода из программы введите  {exitLoop}");

                userInput = Console.ReadLine();
            }
        }
    }
}
