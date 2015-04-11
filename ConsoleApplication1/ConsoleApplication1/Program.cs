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
        static void Main(string[] args)
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

            string input = "Hello how Are you";
            string[] words = input.Split(' ');
            string output = "";
            for(var i=words.Length - 1; i >= 0 ;i--)
            {
                output += words[i];
                if (i != 0)
                {
                    output += " ";
                }
            }
            Trace.WriteLine(output);
        }
    }
}
