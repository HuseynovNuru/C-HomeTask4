using System;
using System.ComponentModel.Design;
using System.Globalization;
using System.Threading;

namespace CHomeTask4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmiş string dəyərindəki ilk sözü tapan metod (ilk söz ilk boşluğa qədərki ifadədir)
            string str = ("Elektriklesdirdiklerimizdensinizmi gelmisiz?");
            Console.WriteLine(Cumle(str));


            //Verilmiş string dəyərindəki sözlərin sayını tapan metod (boşluqlarla ayrılan bütün ifadələri söz kimi nəzərə alın)
            string str1 = ("Men kod yaza bilmirem");
            Console.WriteLine(Cumle1(str1));



            //Verilmiş ədədlər siyahısından içində yalnız müsbət ədədlər qalan yeni bir array düzəldən metod.
            int[] number = { 1, -2, -3, 4, 5, 6, -7, -8, 9 };
            var numberss= Reqemler(number);
            for (int i = 0; i < numberss.Length; i++)
            {
                Console.WriteLine(numberss[i]);
            }


            //Verilmiş yazılar siyahısında neçə yazıda rəqəm olduğunu qaytaran metod
            string[] sentence = { "Baki10", "Gence", "Sumqayit", "Tovuz" };
            Console.WriteLine(Yazilar(sentence));



        }
        //Verilmiş string dəyərindəki ilk sözü tapan metod (ilk söz ilk boşluğa qədərki ifadədir)
        static string Cumle(string str)
        {
         string s = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ' )
                {
                    s += str[i];
                }
                else
                {
                    break;
                }
            }
            return s;   
            
        }


        //Verilmiş string dəyərindəki sözlərin sayını tapan metod (boşluqlarla ayrılan bütün ifadələri söz kimi nəzərə alın)
        static int Cumle1(string str)
        {
            int count  = 1;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    count++;
                }
                
            }
            return count ;
        }


        //Verilmiş ədədlər siyahısından içində yalnız müsbət ədədlər qalan yeni bir array düzəldən metod.
        static int[] Reqemler(int[] nums)
        {
            int count = 0;
            for(int i =0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                  count++;
                }
            }
            int[] newNum= new int[count];
            int j = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    newNum[j] = nums[i];
                    j++;
                }
            }
            return newNum;  
        }


        //Verilmiş yazılar siyahısında neçə yazıda rəqəm olduğunu qaytaran metod
        static int Yazilar(string[] soz)
        {
            char[] charss = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            int count = 0;
            for (int i = 0; i < soz.Length; i++)
            {
                for (int j = 0; j < soz[i].Length; j++)
                {
                    if (soz[i][j] > 47 && soz[i][j] < 58)
                    {
                        count++;
                        break;
                    }
                }
            }
            return count;
        }



    }
}
