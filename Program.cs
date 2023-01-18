using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //int number = 9673;
            //int sumofDigits = 0;
            //while (number > 0)
            //{
            //    var lastDigit = number % 10;
            //    sumofDigits += lastDigit;
            //    number = (number - lastDigit) / 10;
            //    number /= 10;
            //}
            //Console.WriteLine(sumofDigits);




            //int n = 100;
            //int m = 200;
            //double sum = 0;
            //int count = 0;

            //for (int i=n; i<m; i++)
            //{
            //    if (i%21==0)
            //    {
            //        sum += i;
            //        count++;
            //    }
            //}

            //if (count==0)
            //{
            //    Console.WriteLine("21e bolunen eded yoxdur");
            //}
            //else
            //{
            //    var result = sum / count;
            //    Console.WriteLine(result);
            //}






            ////int n = 200;
            ////int m = 300;
            ////double sum = 0;
            ////int count = 0;

            ////while (n<m) 
            ////{
            ////    if (n%21==0)
            ////    {
            ////        sum += n;
            ////        count++;
            ////    }
            ////    n++;
            ////}
            ////if (count==0)
            ////{
            ////    Console.WriteLine("21e bolunen eded yoxdur");
            ////}
            ////else
            ////{
            ////    var result = sum / count;
            ////    Console.WriteLine(result);
            ////}






            ShowTask1();
            ShowTask2();
            ShowTask3();

        }


        static void ShowTask1()
        {
            int number = 9673;
            int sumofDigits = 0;
            while (number > 0)
            {
                var lastDigit = number % 10;
                sumofDigits += lastDigit;
                number = (number - lastDigit) / 10;
                number /= 10;
            }
            Console.WriteLine(sumofDigits);
        }

        static void ShowTask2()
        {
            int n = 100;
            int m = 200;
            double sum = 0;
            int count = 0;

            for (int i = n; i < m; i++)
            {
                if (i % 21 == 0)
                {
                    sum += i;
                    count++;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("21e bolunen eded yoxdur");
            }
            else
            {
                var result = sum / count;
                Console.WriteLine(result);
            }
        }

        static void ShowTask3()
        {
            Console.WriteLine("Yazini daxil edin:");
            string word = Console.ReadLine();

            bool hasWantedChar = false;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a')
                {
                    hasWantedChar = true;
                    break;
                }
            }

            if (hasWantedChar == true)
            {
                Console.WriteLine("Yazida a  var");
            }
            else
            {
                Console.WriteLine("Yazida a yoxdur");
            }


            //string username;
            //bool has1 = false;
            //do
            //{
            //    Console.WriteLine("Username daxil edin:");
            //    username = Console.ReadLine();

            //    has1 = false;
            //    for (int i = 0; i < username.Length; i++)
            //    {
            //        if (username[i] == 'a')
            //        {
            //            has1 = true;
            //            break;
            //        }
            //    }

            //} while (has1 == true);
            //Console.WriteLine(username);
        }


    }
    
}

