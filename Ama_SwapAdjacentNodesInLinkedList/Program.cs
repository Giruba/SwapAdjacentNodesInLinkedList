using System;

namespace Ama_SwapAdjacentNodesInLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Swap adjacent nodes in Linked list!");
            Console.WriteLine("----------------------------------");

            LinkedList linkedList = GetLinkedListFromInput();
            linkedList.SwapAdjacentNodes(linkedList.GetLinkedListHead());

            Console.ReadLine();
        }

        private static LinkedList GetLinkedListFromInput() {
            LinkedList linkedList = null;

            Console.WriteLine("Enter the number of elements" +
                " in the linked list");
            try
            {
                int noElements = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the elements separated by space");
                String[] elements = Console.ReadLine().Split(' ');
                linkedList = new LinkedList();
                for (int index = 0; index < noElements; index++) {
                    linkedList.SetLinkedListHead(
                    linkedList.Append(linkedList.GetLinkedListHead(), 
                        int.Parse(elements[index])));
                }
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }


            return linkedList;
        }
    }
}
