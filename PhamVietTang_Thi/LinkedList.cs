using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//23DH113104_PhamVietTang
namespace PhamVietTang_Thi
{
    internal class LinkedList
    {
        private LinkedListNode head;

        public LinkedList()
        {
            head = null;
        }

        public void AddMeaning(string meaning)
        {
            LinkedListNode newNode = new LinkedListNode(meaning);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                LinkedListNode current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public void DisplayMeanings()
        {
            LinkedListNode current = head;
            while (current != null)
            {
                Console.WriteLine($"- {current.Meaning}");
                current = current.Next;
            }
        }
    }
}
