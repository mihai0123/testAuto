﻿using System;
using System.Collections.Generic;
using System.Globalization;

namespace Proiect_tema_git
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

            Console.ReadLine();

        }
    }
}