﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace double_linked_list
{
    class Node
    {
        /* Node class represents the node of doubly linked list.
         * it consist of the information part and links to.
         * its seccending and preeceding
         * in terms of next and previous */
        public int noMhs;
        public string name;
        //point to the suceeding node
        public Node next;
        //point to the preeceding node
        public Node prev;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
