namespace Калькулятор_5_классника
{
    internal class Program
    {
        static void Main()
        {
            
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("__Калькулятор 5 классника__");
            Console.WriteLine("Доступно 3 системы перевода: \nа) В 2-ую и обратно \nб) В 8-ую и обратно \nв) В 16-ую и обратно");
            Console.WriteLine("");
            Console.WriteLine("В какую систему вы хотите перевести? (выберите вариант): \n1. 2 \n2. 8 \n3. 16");
            Console.Write("Ответ: ");

            if (!int.TryParse(Console.ReadLine(), out int system))
            {
                Console.WriteLine("<<Incorrect input>>"); return;
            }
            Console.WriteLine("");
            Console.WriteLine("В 10-ую или из 10-ой системы? (выберите вариант): \n1. В 10-ую \n2. Из 10-ой");
            Console.Write("Ответ: ");
            if (!int.TryParse(Console.ReadLine(), out int TenInNOut))
            {
                Console.WriteLine("<<Incorrect input>>"); return;
            }
            Console.WriteLine("");


            // 2 -> 10
            if (system == 1 && TenInNOut == 1)
            {
                Console.WriteLine("<<Перевод из 2-ой системы в 10-ую...>>");
                Console.Write("Введите число: ");
                string TwoToTen = Console.ReadLine();
                Console.WriteLine("");

                Console.WriteLine($"Ваше число: {TwoToTen}");
                Console.WriteLine("");
                Console.WriteLine("Далее, пронумеруйте разряды справа налево, начиная с нуля.");
                Console.WriteLine("Пример: 1101 = 1\u00B3 1\u00B2 0\u00B9 1\u2070");
                Console.WriteLine("");
                Console.WriteLine("После этого каждую цифру отдельно умножьте на 2, возведённую в степень этой цифры");
                Console.WriteLine("Пример: 1\u00B3 = 1 * 2\u00B3; 0\u00B9 = 0 * 2\u00B9");
                Console.WriteLine("");

                string num = TwoToTen;
                 int base_ = 2;
                 int sum = 0;
                 int length = num.Length;
                 Console.WriteLine("Ваше число:");
                 for (int i = 0; i < length; i++)
                  {
                    
                    int digit = num[i] - '0';
                    int power = length - 1 - i;
                     Console.WriteLine($"{digit} * {base_}^{power} = {digit * (int)Math.Pow(base_, power)}");
                     sum = sum + digit * (int)Math.Pow(base_, power);
                  }
                   Console.WriteLine("");
                Console.WriteLine("Далее складывем полученные числа");
                Console.WriteLine($"Ответ: {sum}");
                }



            // 10 -> 2
            if (system == 1 && TenInNOut == 2)
            {
                Console.WriteLine("<<Перевод из 10-ой системы в 2-ую...>>");
                Console.Write("Введите число: ");
                int TenToTwo = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                Console.WriteLine($"Ваше число: {TenToTwo}");
                Console.WriteLine("");
                Console.WriteLine("Далее, делите ваше число на 2, пока вы больше не сможете делить");
                Console.WriteLine("");
                
                string sum = "";
                Console.WriteLine("Ваше число:");
                while (TenToTwo > 0)
                    {
                        int remainder = TenToTwo % 2;
                        sum = remainder + sum;
                        Console.WriteLine($"{TenToTwo} / 2 = {TenToTwo / 2}, остаток: {TenToTwo % 2}");
                        TenToTwo = TenToTwo / 2;
                    }
                Console.WriteLine("");
                Console.WriteLine("Далее соединяем единцы и нули, начиная снизу вверх");
                Console.WriteLine($"Ответ: {sum}");

                }


            // 8 -> 10
            if (system == 2 && TenInNOut == 1)
            {
                Console.WriteLine("<<Перевод из 8-ой системы в 10-ую...>>");
                Console.Write("Введите число: ");
                string EightToTen = Console.ReadLine();
                Console.WriteLine("");

                Console.WriteLine($"Ваше число: {EightToTen}");
                Console.WriteLine("");
                Console.WriteLine("Далее, пронумеруйте разряды справа налево, начиная с нуля.");
                Console.WriteLine("Пример: 1234 = 1\u00B3 2\u00B2 3\u00B9 4\u2070");
                Console.WriteLine("");
                Console.WriteLine("После этого каждую цифру отдельно умножьте на 8, возведённую в степень этой цифры");
                Console.WriteLine("Пример: 2\u00B2 = 2 * 8\u00B2; 4\u2070 = 4 * 8\u2070");
                Console.WriteLine("");

                string num = EightToTen;
                int base_ = 8;
                int sum = 0;
                int length = num.Length;
                Console.WriteLine("Ваше число:");
                for (int i = 0; i < length; i++)
                {

                    int digit = num[i] - '0';
                    int power = length - 1 - i;
                    Console.WriteLine($"{digit} * {base_}^{power} = {digit * (int)Math.Pow(base_, power)}");
                    sum = sum + digit * (int)Math.Pow(base_, power);
                }
                Console.WriteLine("");
                Console.WriteLine("Далее складывем полученные числа");
                Console.WriteLine($"Ответ: {sum}");
            }
            

            // 10 -> 8
            if (system == 2 && TenInNOut == 2)
            {
                Console.WriteLine("<<Перевод из 10-ой системы в 8-ую...>>");
                Console.Write("Введите число: ");
                int TenToEight = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                Console.WriteLine($"Ваше число: {TenToEight}");
                Console.WriteLine("");
                Console.WriteLine("Далее, делите ваше число на 8, пока вы больше не сможете делить");
                Console.WriteLine("");

                string sum = "";
                Console.WriteLine("Ваше число:");
                while (TenToEight > 0)
                {
                    int remainder = TenToEight % 8;
                    sum = remainder + sum;
                    Console.WriteLine($"{TenToEight} / 8 = {TenToEight / 8}, остаток: {TenToEight % 8}");
                    TenToEight = TenToEight / 8;
                }
                Console.WriteLine("");
                Console.WriteLine("Далее соединяем полученные остатки, начиная снизу вверх");
                Console.WriteLine($"Ответ: {sum}");
            }
                
            // 16 -> 10
            if (system == 3 && TenInNOut == 1)
            {
                Console.WriteLine("<<Перевод из 16-ой системы в 10-ую...>>");
                Console.Write("Введите число: ");
                string SixToTen = Console.ReadLine();
                Console.WriteLine("");

                Console.WriteLine($"Ваше число: {SixToTen}");
                Console.WriteLine("");
                Console.WriteLine("Далее, пронумеруйте разряды справа налево, начиная с нуля.");
                Console.WriteLine("Пример: 12AB = 1\u00B3 2\u00B2 A\u00B9 B\u2070");
                Console.WriteLine("");
                Console.WriteLine("В 16-ой системе дальше 9 идут буквы латинского алфавита. Им подходят следующие числа:");
                Console.WriteLine("A = 10, B = 11, C = 12, D = 13, E = 14, F = 15");
                Console.WriteLine("");
                Console.WriteLine("После этого каждую цифру отдельно умножьте на 16, возведённую в степень этой цифры. Обратите вниманиме каким числам равны буквы, умножайте числа на основание.");
                Console.WriteLine("Пример: 2\u00B2 = 2 * 16\u00B2; A\u00B9 = 10 * 16\u00B9");
                Console.WriteLine("");

                string num = SixToTen;
                int base_ = 16;
                int sum = 0;
                num = num.ToUpper();
                int length = num.Length;

                if (num.Length == 0)
                {
                    Console.WriteLine("Incorrect input"); return;
                }

                Console.WriteLine("Ваше число:");
                for (int i = 0; i < length; i++)
                {
                    char c = num[i];
                    int digit;

                    if (c >= '0' && c <= '9')
                    {
                        digit = c - '0';
                    }
                    else
                    {
                        digit = c - 'A' + 10;
                    }
                    if (digit < 0 || digit > 15)
                    {
                        Console.WriteLine("Incorrect input"); return;
                    }
                    int power = length - 1 - i;
                    Console.WriteLine($"{digit} * {base_}^{power} = {digit * (int)Math.Pow(base_, power)}");
                    sum = sum + digit * (int)Math.Pow(base_, power);
                }
                Console.WriteLine("");
                Console.WriteLine("Далее складывем полученные числа");
                Console.WriteLine($"Ответ: {sum}");
            
        }


            // 10 -> 16
            if (system == 3 && TenInNOut == 2)
            {
                Console.WriteLine("<<Перевод из 10-ой системы в 16-ую...>>");
                Console.Write("Введите число: ");
                int TenToSix = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                Console.WriteLine($"Ваше число: {TenToSix}");
                Console.WriteLine("");
                Console.WriteLine("Далее, делите ваше число на 16, пока вы больше не сможете делить");

                Console.WriteLine("");

                string sum = "";
                Console.WriteLine("Ваше число:");
                while (TenToSix > 0)
                {
                    int remainder = TenToSix % 16;
                    char hex_digit;
                    if (remainder < 10)
                    {
                        hex_digit = (char)('0' + remainder);
                    }
                    else
                    {
                        hex_digit = (char)('A' + remainder - 10);
                    }
                    sum = hex_digit + sum;
                    Console.WriteLine($"{TenToSix} / 16 = {TenToSix / 16}, остаток: {TenToSix % 16}");
                    TenToSix = TenToSix / 16;
                }
                Console.WriteLine("");
                Console.WriteLine("A = 10, B = 11, C = 12, D = 13, E = 14, F = 15");
                Console.WriteLine("Далее соединяем полученные остатки, начиная снизу вверх. Обратите внимание: если остаток - 10-15, то по таблице замени на буквы.");
                Console.WriteLine($"Ответ: {sum}");
            }
            }
            }
        }
    

