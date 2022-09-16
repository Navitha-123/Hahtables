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
            Console.WriteLine("choose option 1.Add to create mymapnode");
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
                default:
                    Console.WriteLine("enter wrong choice");
                    break;



            }

        }
    }
}
