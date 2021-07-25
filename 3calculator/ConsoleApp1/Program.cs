using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            string digit = null;
            int spaces = 0, indexofpar = -1, start = 0, end, indexofsymb = 0, count1, count2;
            double count3;
            List<object> listline = new List<object>();
            int count = 3 + (10 * 4 + 10) * 10 + 10 - 84 / 5;
            Console.WriteLine("Введите пример, который нужно решить.\nИспользование букв запрещено.\n Допустимые знаки: \n+ сложение\n- вычитание\n* умножение\n/ деление\n^ возведение в степень\n() скобки для установки приоритетов для операций");
            line = Console.ReadLine();
            line += " ";
            //узнаем, есть ли в нашей строке буквы
            foreach (char symb in line)
            {
                if (Char.IsLetter(symb))
                {
                    Console.WriteLine("Зря ты буквы вводил -_-");
                    Environment.Exit(0);
                }
            }
            //сортируем символы в строке на числа и знаки
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == '*' | line[i] == '/' | line[i] == '^' | line[i] == '+' | line[i] == '-' | line[i] == '(' | line[i] == ')')
                    listline.Add(line[i]);

                else if (Char.IsDigit(line[i]))
                {
                    digit += line[i];
                    while (Char.IsDigit(line[i + 1]))
                    {

                        i++;
                        digit += line[i];
                    }
                    listline.Add(Convert.ToInt32(digit));
                    digit = null;
                }

                else if (Char.IsWhiteSpace(line[i]))
                    spaces++;

                else
                {
                    Console.WriteLine("Ты ввел что то лишнее, переделывай!");
                    Environment.Exit(0);
                }
            }
            //начинаем считать
            while (listline.Count > 1)
            {
                if (listline.IndexOf('(', 0) != -1)
                {
                    indexofpar = listline.IndexOf('(', 0);
                    while (listline.IndexOf('(', indexofpar + 1) < listline.IndexOf(')', indexofpar) && listline.IndexOf('(', indexofpar + 1) != -1)
                        {
                            indexofpar = listline.IndexOf('(', indexofpar + 1);
                        }
                    start = indexofpar;
                    end = listline.IndexOf(')', indexofpar);
                }
                else
                {
                    start = 0;
                    end = listline.Count - 1;
                }

                if(listline.IndexOf('^', start, end - start + 1) != -1)
                {
                    indexofsymb = listline.IndexOf('^', start, end - start + 1);
                    count1 = Convert.ToInt32(listline[indexofsymb - 1].ToString());
                    count2 = Convert.ToInt32(listline[indexofsymb + 1].ToString());
                    count3 = Math.Pow(count1, count2);
                    listline.RemoveRange(indexofsymb - 1, 3);
                    listline.Insert(indexofsymb - 1, count3);
                }
                else if (listline.IndexOf('*', start, end - start + 1) != -1)
                {
                    indexofsymb = listline.IndexOf('*', start, end - start + 1);
                    count1 = Convert.ToInt32(listline[indexofsymb - 1].ToString());
                    count2 = Convert.ToInt32(listline[indexofsymb + 1].ToString());
                    count3 = count1 * count2;
                    listline.RemoveRange(indexofsymb - 1, 3);
                    listline.Insert(indexofsymb - 1, count3);
                }
                else if (listline.IndexOf('/', start, end - start + 1) != -1)
                {
                    indexofsymb = listline.IndexOf('/', start, end - start + 1);
                    count1 = Convert.ToInt32(listline[indexofsymb - 1].ToString());
                    count2 = Convert.ToInt32(listline[indexofsymb + 1].ToString());
                    count3 = count1 / count2;
                    listline.RemoveRange(indexofsymb - 1, 3);
                    listline.Insert(indexofsymb - 1, count3);
                }
                else if (listline.IndexOf('+', start, end - start + 1) != -1)
                {
                    indexofsymb = listline.IndexOf('+', start, end - start + 1);
                    count1 = Convert.ToInt32(listline[indexofsymb - 1].ToString());
                    count2 = Convert.ToInt32(listline[indexofsymb + 1].ToString());
                    count3 = count1 + count2;
                    listline.RemoveRange(indexofsymb - 1, 3);
                    listline.Insert(indexofsymb - 1, count3);
                }
                else if (listline.IndexOf('-', start, end - start + 1) != -1)
                {
                    indexofsymb = listline.IndexOf('-', start, end - start + 1);
                    count1 = Convert.ToInt32(listline[indexofsymb - 1].ToString());
                    count2 = Convert.ToInt32(listline[indexofsymb + 1].ToString());
                    count3 = count1 - count2;
                    listline.RemoveRange(indexofsymb - 1, 3);
                    listline.Insert(indexofsymb - 1, count3);
                }

                if (indexofpar != -1)
                {
                    if (listline.IndexOf(')', indexofpar) - indexofpar <= 2)
                    {
                        listline.RemoveAt(listline.IndexOf(')', indexofpar));
                        listline.RemoveAt(indexofpar);
                    }
                    indexofpar = -1;
                }
            }

            Console.WriteLine($"Ответ: {listline[0]}");
           
        }
    }
}
