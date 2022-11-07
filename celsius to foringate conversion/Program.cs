using System;
/*
 * Пользователь вводит с клавиатуры показания тем-
пературы. В зависимости от выбора пользователя про-
грамма переводит температуру из Фаренгейта в Цельсий
или наоборот.
*/

namespace celsius_to_foringate_conversion
{
    class Program
    {

        static void Main()
        {
            Console.WriteLine("Введите единицы измерения.\n \"1\" -это Фаренгейт, \"2\" -это Цельсия");
            int str = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите показания температуры: ");
            double num = Convert.ToDouble(Console.ReadLine());
            

            if (str == 1)
            {
                double f = (num - 32) * 5 / 9;
                Console.WriteLine(f + "°C");
            }
            if (str == 2)
            {
                double c = (num * 9 / 5) + 32;
            
            Console.WriteLine(c + "°F");
            }
            Console.ReadLine();
        }
    }
}
