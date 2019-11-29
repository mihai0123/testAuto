using System;
using System.Collections.Generic;
using System.Globalization;

namespace ConsoleApp1
{

    public class Program
    {
        public static void Main()
        {

            List<string> strList = new List<string>();
            strList.Add("anA");
            strList.Add("elena");
            strList.Add("MARIA");
            strList.Add("cRisTiAn");

            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;

            string lowerNames = "";
            string concatenatedNames = "";

            for (int i = 0; i < strList.Count; i++)
            {
                lowerNames = lowerNames + strList[i].ToLower() + ", ";
                concatenatedNames = concatenatedNames + strList[i] + ", ";
            }

            Console.WriteLine("{0} -> {1}", concatenatedNames.Remove(concatenatedNames.Length - 2),
                myTI.ToTitleCase(lowerNames).Remove(lowerNames.Length - 2));

            displayNamesVowels(strList);
            displayNamesConsonants(strList);

            Car car1 = new Car("Dacia", "Logan", "B 111 UNU", "2012", 12345);
            Console.Write(car1.ToString());
            car1.PrinterFriendly();

            Console.ReadLine();

        }

        public static void displayNamesVowels(List<string> elements)
        {
            string vowels = "aeiou";
            foreach (var element in elements)
            {
                bool startsWithVowel = vowels.Contains((element[0]).ToString().ToLower());
                if (startsWithVowel)
                {
                    Console.WriteLine(element);
                }

            }

            Console.ReadLine();
        }

        public static void displayNamesConsonants(List<string> elements)
        {
            string consonants = "bcdfghjklmnpqrstvwxz";
            foreach (var element in elements)
            {
                bool startsWithConsonant = consonants.Contains((element[0]).ToString().ToLower());
                if (startsWithConsonant)
                {
                    Console.WriteLine(element);
                }

            }

            Console.ReadLine();
        }
    }
}
