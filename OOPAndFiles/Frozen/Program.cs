using System;
using System.Collections.Generic;
using System.IO;

namespace Frozen
{
    class Program
    {
        class Gift
        {
            string name;
            string prsnt;
            public Gift(string _name, string _prsnt, string v)
            {
                name = _name;
                prsnt = _prsnt;
            }
            public string Name
            {
                get { return name; }
            }
            public string Prsnt
            {
                get { return prsnt; }
            }
            static void Main(string[] args)
            {
                List<Gift> myGifts = new List<Gift>();
                string[] giftsFromFile = GetDataFromFile();
                foreach (string line in giftsFromFile)
                {
                    string[] tempArray = line.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                    Gift newGift = new Gift(tempArray[0], tempArray[1], tempArray[2]);
                    myGifts.Add(newGift);
                }
                foreach (Gift giftFromList in myGifts)
                {
                    Console.WriteLine($"{giftFromList.Name} wants to get {giftFromList.Prsnt} for XMAS.");
                }
            }
                public static void DisplayElementFromArray(string[] someArray)
                {
                    foreach (string element in someArray)
                    {
                        Console.WriteLine($"String from array: {element}.");
                    }
                }
                public static string[] GetDataFromFile()
                {
                    string filePath = @"C:\Users\Artjom\Documents\RKE132\Nadal15\sample\frozen.txt";
                    string[] dataFromFile = File.ReadAllLines(filePath);


                    return dataFromFile;
                }
            } 
        }
    }

