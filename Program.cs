using System;

namespace Anagrama
{
    class Program
    {
        static void Main(string[] args)
        {

            string FirstWord, SecondWord;
            bool result;

            Console.WriteLine("Escriba la primera palabra");
            FirstWord = Console.ReadLine();
            Console.WriteLine("Escriba la segunda palabra");
            SecondWord = Console.ReadLine();

            FirstWord.ToLower();
            SecondWord.ToLower();

            char[] FirstWord = FirstWord.ToCharArray();
           



        }
    }
}
