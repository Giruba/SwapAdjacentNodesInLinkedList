using System;
using System.Collections.Generic;
using System.Text;

namespace Ama_SwapAdjacentNodesInLinkedList
{
    class LinkedList
    {
        LinkedListNode head;

        public LinkedList() { }

        public LinkedList(LinkedListNode linkedListNode) {
            head = linkedListNode;
        }

        public void SetLinkedListHead(LinkedListNode linkedListNode) {
            head = linkedListNode;
        }

        public LinkedListNode GetLinkedListHead() {
            return head;
        }

        public LinkedListNode Append(LinkedListNode linkedListNode, int data) {
            if (linkedListNode == null) {
                linkedListNode = new LinkedListNode(data);
                return linkedListNode;
            }

            LinkedListNode current = linkedListNode;
            while (current != null && current.GetLinkedListNodeNextPointer() != null) {
                current = current.GetLinkedListNodeNextPointer();
            }

            current.SetLinkedListNextPointer(new LinkedListNode(data));
            return linkedListNode;
        }

        public void SwapAdjacentNodes(LinkedListNode linkedListNode) {
            if (linkedListNode == null) {
                Console.WriteLine("The linked list is empty!");
            }

            LinkedListNode linkedListTemp= _SwapAdjacentNodes(linkedListNode);

            while (linkedListTemp != null) {
                Console.Write(linkedListTemp.GetLinkedListNodeData()+"->");
                linkedListTemp = linkedListTemp.GetLinkedListNodeNextPointer();
            }            
        }

        private LinkedListNode _SwapAdjacentNodes(LinkedListNode linkedListNode) {
            if (linkedListNode == null) {
                return null;
            }

            LinkedListNode linkedListNodeTemp = linkedListNode;

            while (linkedListNodeTemp != null && 
                linkedListNodeTemp.GetLinkedListNodeNextPointer() != null) {
                int temp = linkedListNodeTemp.GetLinkedListNodeData();
                linkedListNodeTemp.SetLinkedListNodeData(
                    linkedListNodeTemp.GetLinkedListNodeNextPointer().
                    GetLinkedListNodeData());

                linkedListNodeTemp.GetLinkedListNodeNextPointer().
                    SetLinkedListNodeData(temp);

                linkedListNodeTemp = linkedListNodeTemp.GetLinkedListNodeNextPointer()
                    .GetLinkedListNodeNextPointer();
            }

            return linkedListNode;
        }
    }
}
