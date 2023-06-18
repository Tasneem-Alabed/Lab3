using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;

namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Firstchaleng();
            // Challenge2();
            //Challenge3();
            challenge4();
        }




        public static void Firstchaleng() {
            int total = 1;
            try
            {
                Console.Write("Please Enter 3 number:");
                String number = Console.ReadLine();
                if (number.Length < 3)
                {
                    Console.WriteLine("0");
                }
                if (CheckNumberinString(number))
                {

                    String[] arr1 = number.Split(" ");
                    for (int z = 0; z < 3; z++)
                    {
                        int i = int.Parse(arr1[z]);
                        total = total * i;
                    }
                    Console.WriteLine($"The Product of thes numbers is : {total}");

                }
            } catch (Exception xe) {
            Console.WriteLine(xe.Message);
            }
          

        }
        public static bool CheckNumberinString (String number)
        {
            foreach (char item in number)
            {
                if (item < '0' || item > '9')
                {
                    if (item != ' ')
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static void Challenge2 (){
            int total = 0;
            Console.WriteLine("Please enter a number between 2-10: ");
            try {
            int number = Convert.ToInt32(Console.ReadLine());
                for (int z = 0;z < number;z++)
                {Console.WriteLine($"{z+1} of {number} - Enter a number:");
                    int inputUser = Convert.ToInt32(Console.ReadLine());
                    if (inputUser >= 2 )
                    {
                        total = total + inputUser;
                    }
                    else
                    {
                        z--;
                    }

                }
                Console.WriteLine($"The average of these {number} numbers is: {total/number}");
            }
            catch (Exception ex) {
            Console.WriteLine (ex.Message); 
            }

        }
        public static void Challenge3()
        {
            for(int y = 1; y <10; y=y+2)
            {
                Console.Write("    ");
                for (int t = 0; t < y; t++)
                {
                    Console.Write("*");
                }

                Console.WriteLine(" ");

            }
            for (int y = 7; y >=1; y = y - 2)
            {
                Console.Write("    ");
                for (int t = 0; t < y; t++)
                {
                    Console.Write("*");
                }

                Console.WriteLine(" ");

            }
        }
        public static void challenge4() {
            try {
              int length=Convert.ToInt32(Console.ReadLine());
                int[] arr2 = new int[length];
                for(int a = 0; a < arr2.Length; a++)
                {
                    int value = Convert.ToInt32(Console.ReadLine());
                    arr2[a] = value;

                }
                Array.Sort(arr2);
              
                int value1 ;
                int rep =0;
                int big=1 ;
                for (int a = 0; a < arr2.Length-1; a++)
                {
                   
                    if (arr2[a] != arr2[a+1])
                    {
                        
                        rep =(a+1)-rep;
                        if (big < rep)
                        {
                            big = rep;
                        }
                        value1 = arr2[a];
                        
                        if (a == arr2.Length - 1)
                        {

                            Console.WriteLine($"{arr2[0]} lkjhgf");
                        }

                        else
                        {
                            Console.WriteLine(value1);
                        }
                    }
                    

                }
                
                
            } 
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
       
    }

}