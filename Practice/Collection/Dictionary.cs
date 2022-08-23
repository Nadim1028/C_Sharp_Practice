using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Collection
{
    public class Dictionary
    {
        Dictionary<string, ArrayList> listDictionary = new Dictionary<string, ArrayList>();

        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        Dictionary<string, int[]> arrayDictionary = new Dictionary<string, int[]>();
        string str = "";

        public void PrintDictionary()
        {
            arrayDictionary.Add("contact", new int[] { 1, 2});
            arrayDictionary.Add("person", new int[] { 3, 4 });
            arrayDictionary.Add("education", new int[] { 1, 5 });

            //dictionary.Add("contact", 1);
            //dictionary.Add("education", 2);
            //dictionary.Add("personal", 3);

            foreach (KeyValuePair<string, int[]> ele1 in arrayDictionary)
            {
                //Console.WriteLine(ele1.Key + " " + ele1.Value.GetValue(0));
                if (ele1.Value.Contains(2))
                {
                    Console.WriteLine( str+ ele1.Key);
                }
            }
            Console.WriteLine("Count : {0} ", arrayDictionary.Count());

            //if (dictionary.ContainsValue(0))
            //{
            //    Console.WriteLine("Found"+"");
            //}
            //else
            //    Console.WriteLine("Not found!");


        }

    }
}
