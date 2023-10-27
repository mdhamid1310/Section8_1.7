using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SinglyLibrary;

namespace Section8_1._7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {
                runApp();
                Console.ReadLine();

            }

        }

        private static void runApp()
        {
            SingleLinkedList linkedList = new SingleLinkedList();

            // Adding nodes to the linked list
            linkedList.AddNode(1);
            linkedList.AddNode(2);
            linkedList.AddNode(3);
            linkedList.AddNode(4);

            Console.WriteLine("Linked List:");
            linkedList.DisplayList();
        }
    }
}
