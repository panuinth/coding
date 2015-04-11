using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class HashMap
{
    //private int ind;
    //private string val;

	public HashMap()
	{
	}

    //public int Ind
    //{
    //    get;
    //    set;
    //}

    public string[] Val
    {
        get;
        set;
    }

    public void Add(int index, string assignedVal)
    {
        this.Val[index] = assignedVal;
    }


    public static void Main()
    {
        HashMap hashMap = new HashMap();
        hashMap.Add(0, "test");
        //hashMap.Ind = 1;
        //hashMap.Val = "Test";
        Console.WriteLine("{0}, {1}", hashMap.Val, hashMap.Val);
        //Hashtable hashtable = new Hashtable();
        //hashtable[1] = "One";
        //hashtable[2] = "Two";
        //hashtable[13] = "Thirteen";

        //System.Console.WriteLine("Hello, World!");
        //foreach (DictionaryEntry entry in hashtable)
        //{
        //    Console.WriteLine("{0}, {1}", entry.Key, entry.Value);
        //}
    }
}
