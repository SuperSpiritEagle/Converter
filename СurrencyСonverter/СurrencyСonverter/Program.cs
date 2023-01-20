using System;

namespace СurrencyСonverter
{
    class Program
    {

        static void Main(string[] args)
        {
            const string CommandKeyOne = "1";
            const string CommandKeyTwo = "2";
            const string CommandKeyThree = "3";
            const string CommandKeyFour = "4";
            const string CommandKeyFive = "5";
            const string CommandKeySix = "6";

            float rubToUsd = 70;
            float usdToRub = 70;
            float eurToRub = 74;
            float rubToEur = 74;
            float rubToCny = 10;
            float cnyToRub = 10;
            float rub;
            float usd;
            float eur;
            float cny;
            float currencyCount;
            string userInput;
            string commandExit = "exit";

            Console.WriteLine("Обменник валют для продолжения нажмите Enter для выхода нажни 0");

            userInput = Console.ReadLine();

            if (userInput == "0")
            {
                Environment.Exit(0);
            }

            Console.Write("Введите баланс рублей: ");
            rub = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите баланс доларов: ");
            usd = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите баланс евро: ");
            eur = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите баланс юаня:");
            cny = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine();

            while (userInput != commandExit)
            {
                Console.WriteLine($"{CommandKeyOne} - обменять рубли на доллары");
                Console.WriteLine($"{CommandKeyTwo} - обменять доллары на рубли");
                Console.WriteLine($"{CommandKeyThree} - обменять евро на рубли");
                Console.WriteLine($"{CommandKeyFour} - обменять рубли на евро");
                Console.WriteLine($"{CommandKeyFive} - обменять рубли на юань");
                Console.WriteLine($"{CommandKeySix} - обменять юань на рубль");
                Console.WriteLine($"Для выхода из программы введите  {commandExit}");
                Console.WriteLine();

                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case CommandKeyOne:
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

                    case CommandKeyTwo:
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

                    case CommandKeyThree:
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

                    case CommandKeyFour:
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

                    case CommandKeyFive:
                        Console.WriteLine("Обмен рублей на юань");
                        Console.WriteLine("Сколько вы хотите обменять");

                        currencyCount = Convert.ToSingle(Console.ReadLine());

                        if (rub >= currencyCount)
                        {
                            rub -= currencyCount;
                            cny += currencyCount / rubToCny;
                        }
                        else
                        {
                            Console.WriteLine("No money no honey");
                        }
                        break;

                    case CommandKeySix:
                        Console.WriteLine("Обмен юань на рубли");
                        Console.WriteLine("Сколько вы хотите обменять");

                        currencyCount = Convert.ToSingle(Console.ReadLine());

                        if (cny >= currencyCount)
                        {
                            cny -= currencyCount;
                            rub += currencyCount * cnyToRub;
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
                string cnyFormat = string.Format("{0:f}", cny);

                Console.WriteLine($"Ваш баланс {rubFormat} рублей {usdFormat} долларов {eurFormat} евро и {cnyFormat} юань");
            }
        }
    }
}
