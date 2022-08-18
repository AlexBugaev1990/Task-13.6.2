using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Task_13._6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // читаем весь файл в строку текста
            string text = File.ReadAllText("D:\\Text1.txt");

            // Сохраняем символы-разделители в массив
            char[] delimiters = new char[] { ' ', '\r', '\n' };

            var noPunctuationText = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());

            // разбиваем нашу строку текста, используя ранее перечисленные символы-разделители
            var words = noPunctuationText.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);


            Dictionary<string, int> dictionary = new Dictionary<string, int>();


            for (int i = 0; i < words.Length; i++)
            {
                if(dictionary.ContainsKey(words[i]))
                    dictionary[words[i]] = dictionary[words[i]] + 1; 
                 else
                    dictionary[words[i]] = 1; 
            }

            var Set = dictionary.OrderByDescending(x => x.Value);

            int b = 0;

            Console.WriteLine("10 слов, которые встречаются чаще всего:");
            foreach (var n in Set)
            {
                Console.WriteLine(n);
                b++;
                if (b == 10)
                    break;
            }
        }
    }
}
