using System;

namespace Permutation
{
    class Program
    {
        static void Main(string[] args)
        {
            Permutation("Ki", string.Empty);
            Console.ReadLine();
        }

        static void Permutation(string input, string prefix)
        {
            if (input.Length == 0)
                Console.WriteLine(prefix);
            else
            {
                for(int index = 0; index < input.Length; index++)
                {
                    String remainderString = input.Substring(0, index) + input.Substring(index+1);
                    Permutation(remainderString, prefix + input[index]);
                }
            }
        }
    }
}
