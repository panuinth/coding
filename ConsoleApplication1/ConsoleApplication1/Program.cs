using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ConsoleApplication1
{
    class Program
    {
        static int square(int a)
        {
            return a * a;

        }

        private static void Main(string[] args)
        {
            //Array
            //int[] studentList;
            //studentList = new int[];
            //studentList[0] = 9;
            //studentList[1] = 8;

            //ArrayList studentList = new ArrayList();
            //studentList.Add("first");
            //studentList.Add("second");

            //for (var i = 0; i < studentList.Count; i++)
            //{
            //    Trace.WriteLine(studentList[i]);
            //}

            //foreach (var j in studentList)
            //{
            //    Trace.WriteLine(j);
            //}

            //int [,] multiArray = new int[2,3] {{1,2,3},{4,5,6}};
            //Trace.WriteLine(multiArray[0,1]);

            //string MANIPULATION
            //string input = "Hello how Are you";
            //string reverseStr = "";
            //string[] words = input.Split(' ');
            //int index = 0;

            //foreach (var w in words)
            //{
            //    for (var i = w.Length - 1; i >= 0; i--)
            //    {
            //        reverseStr = reverseStr + w[i];
            //    }
            //    if (index != w.Length)
            //    {
            //        reverseStr += " ";
            //    }
            //    index++;
            //}
            //Trace.WriteLine(reverseStr);

            //string input = "Hello how Are you";
            //string[] words = input.Split(' ');
            //string output = "";
            //for(var i=words.Length - 1; i >= 0 ;i--)
            //{
            //    output += words[i];
            //    if (i != 0)
            //    {
            //        output += " ";
            //    }
            //}
            //Trace.WriteLine(output);

            //int t = Convert.ToInt32(Console.ReadLine());
            //int val1, val2, sum;
            //for (int i = 0; i < t; i++)
            //{
            //    String elements = Console.ReadLine();
            //    String[] split_elements = elements.Split(' ');
            //    val1 = Convert.ToInt32(split_elements[0]);
            //    val2 = Convert.ToInt32(split_elements[1]);
            //    sum = solveMeSecond(val1, val2);
            //    Console.WriteLine(sum);
            //}

            //int start = Convert.ToInt32(Console.ReadLine());
            //int end = Convert.ToInt32(Console.ReadLine());
            double start = Convert.ToInt32(Console.ReadLine());
            double end = Convert.ToInt32(Console.ReadLine());
            double squareResult;
            string output = "";
            if (end > 100000)
            {
                end = 100000;
            }
            if ( (start > 0) && (end > 0) && (start != 0) && (end != 0) )
            {
                for (var i = start; i <= end; i++)
                {
                    squareResult = i * i;
                    string sub = Convert.ToString(squareResult);
                    int strCount = sub.Length;
                    string firstPart;
                    string secondPart;
                    if ((Convert.ToString(squareResult).Length < 2))
                    {
                        firstPart = sub.Substring(0, 1);
                        secondPart = "0";
                    }
                    else
                    {
                        firstPart = sub.Substring(0, strCount/2);
                        int subStrLength;
                        if (strCount%2 == 0)
                        {
                            subStrLength = strCount/2;
                        }
                        else
                        {
                            subStrLength = (strCount/2) + strCount%2;

                        }
                        secondPart = sub.Substring(strCount/2, subStrLength);
                    }
                    int plusResult = Convert.ToInt32(firstPart) + Convert.ToInt32(secondPart);
                    if (plusResult == i)
                    {
                        output += i + " ";
                    }

                }
            }
            if (output == "")
            {
                Trace.WriteLine("INVALID RANGE");
            }
            else
            {
                Trace.WriteLine(output);
            }
        }
    }
}
