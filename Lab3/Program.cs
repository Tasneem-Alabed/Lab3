using System;
using System.Collections.Immutable;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;

namespace Lab3
{
    public class Program
    {
        static void Main(string[] args)
        {
            interfaces();
            //challenge6();
            //challenge7();
            //challenge9();


        }
        public static void interfaces() {

            String[] arr;
            try
            {
                String input = Console.ReadLine();
                arr = input.Split(" ");



                Firstchaleng(arr);

                int coun = 0;
                Console.WriteLine("Please enter a number between 2-10: ");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number >= 2 && number <= 10)
                {
                    int[] arr1 = new int[number];
                    for (int z = 0; z < number; z++)
                    {
                        if (coun == number)
                        {
                            Challenge2(z, arr1);
                        }
                        int inputUser = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{z + 1} of {number} - Enter a number:");
                        if (inputUser < 0)
                        {
                            z--;
                        }
                        else
                        {
                            arr1[z] = inputUser;
                        }
                    }
                    Challenge2(number, arr1);
                }
                Challenge3();
                int[] arr2 = new int[11] { 4, 4, 3, 2, 3, 4, 5, 6, 5, 4, 3 };
                challenge4(arr2);

                int[] arr3 = new int[6] { 6, 5, 90, 88, 4, 3 };
                challenge5(arr3);
                challenge6();
                challenge7();
                challenge8();
                Console.WriteLine("enter sentance");
                string a = Console.ReadLine();

                Console.WriteLine("Write a sentence ");
                string sentence = Console.ReadLine();
                string[] array = challenge9(sentence); ;
                foreach (string item in array)
                {
                    Console.Write($"{item} ");
                }
            }

            catch (Exception xe)
            {
                Console.WriteLine(xe.Message);
            }

        }


        public static int Firstchaleng(String[] arr) {
            int total = 1;
            if (arr.Length < 3)
            {
                return 0;
            }
            int counter = 0;
            foreach (String s in arr)
            {
                if (counter == 3)
                {

                    return total;
                }
                else if (counter < 3)
                {
                    try
                    {
                        total *= Convert.ToInt32(s);
                        counter++;
                    }
                    catch (Exception)
                    {
                        arr[counter] = "1";
                        total *= Convert.ToInt32(arr[counter]);
                    }
                }
            } return total;


        }

        public static decimal Challenge2(int number, int[] arr) {
            int total = 0;
            if (number == 0 || arr.Length < 3)
            {
                return 0;
            }
            for (int z = 0; z < number; z++)
            {
                total += arr[z];
            }

            return total / number;
        }
        public static void Challenge3()
        {
            for (int y = 1; y < 10; y = y + 2)
            {
                Console.Write("    ");
                for (int t = 0; t < y; t++)
                {
                    Console.Write("*");
                }

                Console.WriteLine(" ");

            }
            for (int y = 7; y >= 1; y = y - 2)
            {
                Console.Write("    ");
                for (int t = 0; t < y; t++)
                {
                    Console.Write("*");
                }

                Console.WriteLine(" ");

            }
        }
        public static int challenge4(int[] arr) {
            int counter = 0;
            int maxCounter = 0;
            int maxVaule = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != maxVaule)
                {
                    counter = 0;

                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            counter++;
                        }
                        if (maxCounter < counter)
                        {
                            maxCounter = counter;
                            maxVaule = arr[i];
                        }

                    }
                }
                if (maxVaule == 0)
                {
                    return arr[0];
                }



            }
            return maxVaule;
        }
        public static int challenge5(int[] arr)
        {
            int key = arr[0];
            for (int x = 0; x < arr.Length; x++)
            {
                if (arr[x] > key) {
                    key = arr[x];
                }
            }
            return key;
        }
        public static String challenge6()
        {
            Console.WriteLine("add the word in file text : ");
            string word = Console.ReadLine();
            string path = "../../../../words.txt";
            //StreamReader sr = new StreamReader(path);
            File.WriteAllText(path, word);
            return word;
        }
        public static void challenge7()
        {
            String line;
            try
            {
                string path = "../../../../words.txt";
                string result = File.ReadAllText(path);
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        public static void challenge8() {

            string word = "hello course";
            string path = "../../../../words.txt";

            File.WriteAllText(path, word);

        }

        public static string[] challenge9(String a)
        {
            string[] sentance = a.Split(" ");
            string[] newarr = new string[sentance.Length];
            for (int i = 0; i < sentance.Length; i++)
            {
                newarr[i] = $"{sentance[i]}: {sentance[i].Length}";

            }
            return newarr;
        }

    
    
    }

}