using System;
using System.Collections.Generic;
using System.Text;

namespace Ama_SwapAdjacentNodesInLinkedList
{
    class LinkedListNode
    {
        int data;
        LinkedListNode next;

        public LinkedListNode() { }

        public LinkedListNode(int data) {
            this.data = data;
        }

        public void SetLinkedListNodeData(int data) {
            this.data = data;
        }

        public void SetLinkedListNextPointer(LinkedListNode linkedListNode) {
            next = linkedListNode;
        }

        public int GetLinkedListNodeData() {
            return data;
        }

        public LinkedListNode GetLinkedListNodeNextPointer() {
            return next;
        }
    }
}
