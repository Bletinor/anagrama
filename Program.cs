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

            char[] FirstWordArr = FirstWord.ToCharArray();
            char[] SecondWordArr = SecondWord.ToCharArray();

            if (FirstWordArr.Length != FirstWordArr.Length)
            {
                result = false;
            }
            else
            {
                FirstWordArr.Sort();
                SecondWordArr.Sort();

                if (FirstWordArr == SecondWordArr)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }

            if (result)
            {
                Console.WriteLine("Son anagrama");
            }
            else
            {
                Console.WriteLine("No son anagramas");
            }
           



        }
    }
}
