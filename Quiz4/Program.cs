
//Quiz N4 - მარიამ ქველაძე


//1. დაწერეთ პროგრამა, რომელიც მასივში დაითვლის თითოეული ელემენტი რამდენჯერ გვხვდება

//using System;
//using System.Linq;
//using System.Collections.Generic;

//class CountFrequency
//{
//    static void Main(string[] args)
//    {
//        int[] arr1 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

//        Console.Write("Numbers in the array  are: \n");
//        Console.Write("5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2\n");

//        var n = from x in arr1
//                group x by x into y
//                select y;
//        Console.WriteLine("\nFrequency of the numbers: \n");
//        foreach (var arrNo in n)
//        {
//            Console.WriteLine("Number " + arrNo.Key + " -> " + arrNo.Count() + " times");
//        }
//        Console.WriteLine("\n");
//    }
//}







//2. დაწერეთ პროგრამა, რომელიც დაითვლის სტრინგში თითოეული სიმბოლო რამდენჯერ გვხვდება

//using System;
//using System.Linq;
//using System.Collections.Generic;

//class FreqiencyOfChars
//{
//    static void Main(string[] args)
//    {
//        string str;

//        Console.Write("Please enter a word: ");
//        str = Console.ReadLine();
//        Console.WriteLine();

//        var Freq = from x in str
//                   group x by x into y
//                   select y;

//        Console.WriteLine("The frequency of the characters is as follows: ");

//        foreach (var ArrEle in Freq)
//        {
//            Console.WriteLine("Character " + ArrEle.Key + ": " + ArrEle.Count() + " times");
//        }
//    }
//}








//3. დაწერეთ პროგრამა რომელიც სტრინგში (წინადადებაში იპოვნის uppercase-იან სიტყვბს და დაბეჭდავს მათ)

//using System;
//using System.Linq;
//using System.Collections.Generic;

//class Program
//{
//    static void Main(string[] args)
//    {

//        string newString;

//        Console.Write("Write a sentence (use uppercase words): ");

//        newString = Console.ReadLine();

//        var ucWord = WordFilt(newString);

//        Console.Write("\nThe uppercase words from the input are: \n");

//        foreach (string strRet in ucWord)
//        {
//            Console.WriteLine(strRet);
//        }
//        Console.ReadLine();
//    }

//    static IEnumerable<string> WordFilt(string mystr)
//    {
//        var upWord = mystr.Split(' ')
//                    .Where(x => String.Equals(x, x.ToUpper(),
//                    StringComparison.Ordinal));

//        return upWord;

//    }
//}








//4. დაწერეთ პროგრამა, რომელიც დააბრუნებს მასივში x-დან y შუალედში ელემენტებს.

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace mostRepeated
//{

//    class Program
//    {

//        static char mostRepeated(string s)
//        {

//            int[] count = new int[256];
//            int max = 0;
//            char result = char.MinValue;


//            Array.Clear(count, 0, count.Length - 1);

//            foreach (char c in s)

//                if (c != ' ' && ++count[c] > max)
//                {

//                    max = count[c];
//                    result = c;
//                }

//            return result;
//        }

//        static void Main(string[] args)
//        {
//            string str = "To be, or not to be, that is the question \n";
//            Console.WriteLine(str);
//            Console.Write("The most repeated character is '{0}'", mostRepeated(str));
//            Console.WriteLine();
//        }
//    }
//}








//5. დაწერეთ პროგრამა, რომელიც დაბეჭდავს სტრინგში ყველაზე განმეორებად სიმბოლოს

//using System;
//using System.Linq;

//namespace MostFrequentChar
//{
//    class MostFrequentCharacter
//    {
//        public static void Main()
//        {
//            string str = "Neversaynever";
//            Console.WriteLine("Input is: " + str);

//            var mostFrequentCharacter = str.GroupBy(c => c).OrderByDescending(c => c.Count()).First().Key;

//            Console.WriteLine("Most frequent character is: " + mostFrequentCharacter);
//        }
//    }
//}