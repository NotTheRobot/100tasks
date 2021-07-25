using System;

/* постановка задачи.
    Создать анкету, неоходимо ввести имя, возраст и ответить на пару вопросов. Программа должна перехватывать ошибки.*/
namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            string name, pine;
            int age, count1, count2, arrnumb;
            byte countb;
            int[] arr = new int[5] { 5, 6, 4, 8, 0 };
            try
            {
                Console.WriteLine("Здравствуйте, это анкета, где выможете совершать ошибки!\nВведите свое имя: ");
                name = Console.ReadLine();
                Console.WriteLine("Введите свой возраст: ");
                age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Впишите число, на которое вы хотите разделить 10: ");
                count1 = Convert.ToInt32(Console.ReadLine());
                count2 = 10 / count1;
                Console.WriteLine("Введите число, большее -1 и меньшее 256: ");
                countb = Convert.ToByte(Console.ReadLine());
                Console.WriteLine("В массиве 5 чиисел, выбери, какое хочешь вывести на экран: ");
                arrnumb = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{arr[arrnumb - 1]}");
                Console.WriteLine("Последнее задание!\nНапиши слово Ананас!");
                pine = Console.ReadLine();
                if (pine != "Ананас")
                    throw new Exception("Это не Ананас...");
                else
                    Console.WriteLine("Поздравляем, вы не совершили ни одной ошибки!");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Чтобы начать заново, введи\"заново\", чтобы завершить выполнение программы, введи любые другие символы");
                string dec = Console.ReadLine();
                if(dec == "заново")
                   Main(args);
            }


        }
    }
}
