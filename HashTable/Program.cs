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
            Console.WriteLine("choose option 1.Add to create mymapnode \t 2.Ability to find frequency of words in a large paragraph \t 3.Remove avoidable word from the\r\nphrase ");
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

                    string hash0 = hashtable.GetV("0");
                    string hash1 = hashtable.GetV("1");
                    string hash2 = hashtable.GetV("2");
                    string hash3= hashtable.GetV("3");
                    string hash4 = hashtable.GetV("4");
                    string hash5= hashtable.GetV("5");

                    Console.WriteLine("zeroth index value " +hash0);
                    Console.WriteLine("1st index value " + hash1);
                    Console.WriteLine("2nd index value " + hash2);
                    Console.WriteLine("3rd index value " + hash3);
                    Console.WriteLine("4th index value " + hash4);
                    Console.WriteLine("5th index value " + hash5);
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
                case 3:
                    UC3MyMapNodeRemove<string, string> hashtable2 = new UC3MyMapNodeRemove<string, string>(18);
                    hashtable2.Add("0", "Paranoids");
                    hashtable2.Add("1", "are");
                    hashtable2.Add("2", "not");
                    hashtable2.Add("3", "paranoid");
                    hashtable2.Add("4", "because");
                    hashtable2.Add("5", "they");
                    hashtable2.Add("6", "are");
                    hashtable2.Add("7", "paranoid");
                    hashtable2.Add("8", "but");
                    hashtable2.Add("9", "because");
                    hashtable2.Add("10", "they");
                    hashtable2.Add("11", "keep");
                    hashtable2.Add("12", "putting");
                    hashtable2.Add("13", "themselves");
                    hashtable2.Add("14", "deliberately");
                    hashtable2.Add("15", "into");
                    hashtable2.Add("16", "paranoid");
                    hashtable2.Add("17", "avoidable");
                    hashtable2.Add("18", "situations");

                    Console.WriteLine("enter the key to search the value :");
                    string K = Console.ReadLine();
                    hashtable2.Remove(K);
                    Console.WriteLine("{0} index value is removed ",K);
                    break;




                default:
                    Console.WriteLine("enter wrong choice");
                    break;



            }

        }
    }
}
