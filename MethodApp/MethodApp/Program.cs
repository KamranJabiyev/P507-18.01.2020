using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Sum(5, 6));
            //Info("Fazil",32);
            //int result=Sum(20,30);
            //Console.WriteLine(result);
            //int res = Sum(y:10,x:15);
            //Console.WriteLine(res);
            //int[] arr = { 13, 15, 27, 35, 145, 23455 };
            //Info(arr);

            string sent = "Hello World";
            Console.WriteLine(ReverseWord(sent));

            //StringBuilder stringBuilder = new StringBuilder();

            #region Out,Ref
            //int a;
            //ChangeNum(out a);
            //Console.WriteLine(a);

            //int[] array = { 10, 100, 1000 };
            //ChangeIndex(array);
            //Console.WriteLine(array[0]);

            //string x = "M";
            //int a;
            //if(int.TryParse(x,out a))
            //{
            //    Console.WriteLine(a);
            //}
            //else
            //{
            //    Console.WriteLine("Cheviremmmedim");
            //}
            #endregion
        }

        //static string ReverseWord(string str)
        //{
        //    string result = "";

        //    string[] arr = str.Split(' ');

        //    foreach (string word in arr)
        //    {
        //        for (int i = word.Length-1; i >= 0; i--)
        //        {
        //            result += word[i];

        //        }
        //        if(result.Length<str.Length)
        //            result += " ";
        //    }
        //    return result;
        //}

        static StringBuilder ReverseWord(string str)
        {
            StringBuilder result = new StringBuilder();

            string[] arr = str.Split(' ');

            foreach (string word in arr)
            {
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    result.Append(word[i]);

                }
                if (result.Length < str.Length)
                    result.Append(" ");
            }
            return result;
        }


        #region Out,Ref
        //static void ChangeIndex(int[] arr)
        //{
        //    arr[0] = 20;
        //    Console.WriteLine(arr[0]);
        //}

        //static void ChangeNum(out int a)
        //{
        //    a = 6;
        //    Console.WriteLine(a);
        //}
        #endregion

        //static int Sum(int x, int y) => x - y;

        #region method default params
        /// <summary>
        /// 
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        //static int Sum(int n1=11,int n2=12)
        //{
        //    if (n1 < n2)
        //    {
        //        return n1 + n2;
        //    }
        //    return n1-n2;
        //}

        //static int Sum(int x)
        //{
        //    return x;
        //}
        #endregion

        #region Method overloading
        //metod imzasi - adi,parametrlerin sayi ve parametrlerin tipi
        //method overloading
        //static void Info(string name)
        //{
        //    Console.WriteLine($"1-ci: {name}");
        //}

        //static void Info(string name,string surname)
        //{
        //    Console.WriteLine($"{name} {surname}");
        //}

        //static void Info(string name,int age)
        //{
        //    Console.WriteLine($"{name} - {age}");
        //}

        //static void Info(params int[] vusal)
        //{
        //    int result = 0;
        //    foreach (int item in vusal)
        //    {
        //        result+=item;
        //    }
        //    Console.WriteLine(result);
        //}
        #endregion

    }
}
