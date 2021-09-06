using System;
using System.Collections.Generic;

namespace HomeWork_5_2
{
    class Program
    {
        /// <summary>
        /// метод для ввода текста
        /// </summary>
        /// <param name="lineNumber"></param>
        /// <returns></returns>
        static string[] methodText(int lineNumber)
        {
            string[] str = new string[lineNumber];
            for(int i = 0; i < lineNumber; i++)
            {
                str[i] = Console.ReadLine();
            }
            return str;
        }
        
        /// <summary>
        /// метод возвращающий строку содержащую слово с минимальной длиной
        /// </summary>
        /// <param name="Args"></param>
        /// <returns></returns>
        static string minLengthWordOfString(string[] Args)
        {
            string[] Words = Args[0].Split(' ', StringSplitOptions.None);
            int min = Words[0].Length;
            int numberString = 0;
            for(int i = 0; i < Args.GetLength(0); i++)
            {
                Words = Args[i].Split(' ', StringSplitOptions.None);
                foreach(var e in Words)
                {
                    if (e.Length < min)
                    {
                        min = e.Length;
                        numberString = i;
                    }
                }
            }
            Console.WriteLine();
            return Args[numberString];
        }

        /// <summary>
        /// метод возвращающий список всех слов максимальной длины в тексте
        /// </summary>
        /// <param name="Args"></param>
        /// <returns></returns>
        static List<string> AllWordsMaxLength(string[] Args)
        {
            string[] Words = Args[0].Split(' ', StringSplitOptions.None);
            int max = Words[0].Length;
            List<string> allMaxLength = new List<string>();
            for (int i = 0; i < Args.GetLength(0); i++)
            {
                Words = Args[i].Split(' ', StringSplitOptions.None);
                foreach (var e in Words)
                {
                    if (e.Length > max)
                    {
                        max = e.Length;
                    }
                }
            }
            for (int i = 0; i < Args.GetLength(0); i++)
            {
                Words = Args[i].Split(' ', StringSplitOptions.None);
                foreach (var e in Words)
                {
                    if (e.Length == max)
                    {
                        allMaxLength.Add(e);
                    }
                }
            }
            return allMaxLength;
        }

        static void Main(string[] args)
        {
            //Задание 2.Создание методов, которые принимают текст и возвращают слова

            Console.Write("Введите количество строк текста: "); int lineNumber = int.Parse(Console.ReadLine());
            Console.WriteLine();
            string[] Text = new string[lineNumber]; //инициализация массива для текста
            List<string> listMaxWordsLength = new List<string>(); //инициализация списка для метода поиска слов максимальной длины
            
            Text = methodText(lineNumber); //введенный текст в виде массива строк

            //вызов метода вызвращающего строку содержащую слово с минимальной длиной
            Console.WriteLine($"Строка, содержащая слово с минимальной длиной: {minLengthWordOfString(Text)}");
            Console.WriteLine();
            
            //вызов метода возвращающего одно или несколько слов с максимальной длиной
            listMaxWordsLength = AllWordsMaxLength(Text); //присвоение пустому списку полученного методом поиска слов максимальной длины
            Console.Write("Слова максимальной длины: ");
            foreach (var e in listMaxWordsLength)
                Console.Write($"{e} ");
        }
    }
}
