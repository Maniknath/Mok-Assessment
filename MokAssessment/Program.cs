using System;
using System.Linq;

namespace MokAssessment
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a charecter:");
            char vowel = Console.ReadKey().KeyChar;
            Console.WriteLine("This is a vowel " + IsVowel(vowel));

            Console.WriteLine("Enter a Sentence");
            string santence = Console.ReadLine();
            int total = CountVowels(santence);
            Console.WriteLine("Total vowel is: " + total);

            string totalvowel = TooManyVowels(santence);
            Console.WriteLine(totalvowel);



            Console.ReadLine();
        }

        public static bool IsVowel(char ch)
        {
            char[] vowel = { 'a', 'e', 'i', 'o', 'u', 'y' };

            if (vowel.Contains(ch))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static int CountVowels(string st)
        {
            int total = 0;
            //string vowels = "aeiou";
            int len = st.Length;
            for (int i = 0; i < len; i++)
            {
                if (IsVowel(st[i]))
                {
                    total++;
                }
            }
            return total;


        }

        public static string TooManyVowels(string input)
        {
            int totalvowel = CountVowels(input);
            if (totalvowel <= 4)
            {
                return "few vowels";
            }
            else if (totalvowel >= 5 && totalvowel <= 7)
            {
                return "right amount of vowels";
            }
            else
            {
                return "too many vowels";
            }


        }
    }
}
