using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("choose option 1.Add to create mymapnode \t 2.Ability to find frequency of words in a large paragraph ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    UC1MyMapNode<string, string> hashtable = new UC1MyMapNode<string, string>(5);
                    hashtable.Add("0", "To");
                    hashtable.Add("1", "be");
                    hashtable.Add("2", "or");
                    hashtable.Add("3", "not");
                    hashtable.Add("4", "To");
                    hashtable.Add("5", "be");

                    Console.WriteLine("enter the key to search the value:");
                    string key = Console.ReadLine();
                    string value = hashtable.GetV(key);
                    Console.WriteLine("{0} index valiue :{1}",key,value);
                    break;
                case 2:
                    UC2MyMapNode<string, string> hashtable1 = new UC2MyMapNode<string, string>(18);
                    hashtable1.Add("0", "Paranoids");
                    hashtable1.Add("1", "are");
                    hashtable1.Add("2", "not");
                    hashtable1.Add("3", "paranoid");
                    hashtable1.Add("4", "because");
                    hashtable1.Add("5", "they");
                    hashtable1.Add("6", "are");
                    hashtable1.Add("7", "paranoid");
                    hashtable1.Add("8", "but");
                    hashtable1.Add("9", "because");
                    hashtable1.Add("10", "they");
                    hashtable1.Add("11", "keep");
                    hashtable1.Add("12", "putting");
                    hashtable1.Add("13", "themselves");
                    hashtable1.Add("14", "deliberately");
                    hashtable1.Add("15", "into");
                    hashtable1.Add("16", "paranoid");
                    hashtable1.Add("17", "avoidable");
                    hashtable1.Add("18", "situations");

                    Console.WriteLine("enter the key to search the value :");
                    string Key = Console.ReadLine();
                    string Value = hashtable1.GetV(Key);
                    Console.WriteLine("{0} index value :{1}", Key, Value);
                    break;



                default:
                    Console.WriteLine("enter wrong choice");
                    break;



            }

        }
    }
}
