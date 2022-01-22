using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashingAndBST
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("***Hashing Problem***");
            Console.WriteLine("***USE CASE 1-To find frequency of words in a sentence*** ");
            Console.WriteLine("***USE CASE 2-To find frequency of words in a paragraph** ");
            Console.WriteLine("Enter the option");
            int num = Convert.ToInt32(Console.ReadLine());
            MapNode<string, int> myMapNode = new MapNode<string, int>(6);
            switch (num)
            {
                case 1:
                    string[] words = { "to", "be", "or", "not", "to", "be" };
                    int count = 1;
                    foreach (string i in words)
                    {
                        count = myMapNode.CheckHash(i);
                        if (count > 1)
                        {
                            myMapNode.Add(i, count);
                        }
                        else
                        {
                            myMapNode.Add(i, 1);
                        }
                    }

                    IEnumerable<string> uniqueItems = words.Distinct<string>();
                    foreach (var i in uniqueItems)
                    {
                        myMapNode.Display(i);
                    }
                    break;
                case 2:

                    MapNode<string, int> myMap = new MapNode<string, int>(10);
                    string[] Paragraph;
                    string input = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
                    Paragraph = input.Split(' ');
                    //Given string input

                    int counts = 1;
                    foreach (string i in Paragraph)
                    {
                        counts = myMap.CheckHash(i);
                        if (counts > 1)
                        {
                            myMap.Add(i, counts);
                        }
                        else
                        {
                            myMap.Add(i, 1);
                        }
                    }
                    Console.WriteLine("\n---------Frequency of words in paragraph---------\n");
                    IEnumerable<string> distinct = Paragraph.Distinct<string>();
                    foreach (var i in distinct)
                    {
                        myMap.Display(i);
                    }

                    break;

                default:
                    Console.WriteLine("Enter the valid option!!!");
                    break;

            }

            Console.ReadLine();
        }
    }
}
