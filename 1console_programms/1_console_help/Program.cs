﻿using System;

namespace _1_console_help
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                "\n\n\n\n\n\t\t*****Типы данных в языке C#*****" +
                "\n\n\t\t*****Целочисленные типы данных*****" +
                "\n\tbyte: хранит целое число от 0 до 255 и занимает 1 байт." +
                "\n\tsbyte: хранит целое число от -128 до 127 и занимает 1 байт." +
                "\n\tshort: хранит целое число от -32768 до 32767 и занимает 2 байта." +
                "\n\tushort: хранит целое число от 0 до 65535 и занимает 2 байта." +
                "\n\tint: хранит целое число от -2147483648 до 2147483647 и занимает 4 байта." +
                "\n\tuint: хранит целое число от 0 до 4294967295 и занимает 4 байта." +
                "\n\tlong: хранит целое число от –9 223 372 036 854 775 808 до 9 223 372 036 854 775 807 и занимает 8 байт." +
                "\n\tulong: хранит целое число от 0 до 18 446 744 073 709 551 615 и занимает 8 байт." +

                "\n\n\t\t*****Типы данных чисел с плавающей запятой*****" +
                "\n\tfloat: хранит число с плавающей точкой от -3.4*1038 до 3.4*1038 и занимает 4 байта." +
                "\n\tdouble: хранит число с плавающей точкой от ±5.0*10-324 до ±1.7*10308 и занимает 8 байта." +
                "\n\tdecimal: хранит десятичное дробное число. Если употребляется без десятичной запятой, имеет значение от ±1.0*10-28 до ±7.9228*1028,\n\tможет хранить 28 знаков после запятой и занимает 16 байт." +

                "\n\n\t\t*****Символьные типы данных*****" +
                "\n\tchar: хранит одиночный символ в кодировке Unicode и занимает 2 байта." +
                "\n\tstring: хранит набор символов Unicode." +

                "\n\n\t\t*****Другие типы данных*****" +
                "\n\tbool: хранит значение true или false (логические литералы)." +
                "\n\tobject: может хранить значение любого типа данных и занимает 4 байта на 32-разрядной платформе и 8 байт на 64-разрядной платформе"
                );

        }
    }
}