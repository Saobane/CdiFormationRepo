﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary.Interfaces
{
    public interface IMyLinkedList<T> :ICustomList<T>
    {
        void AddAfter(T afterElement, T element);
        void Remove(Node<T> element);
        Node<T> GetNode(T element);
        void PrintMyLinkedList();
        //new 
        void ReverseLinkedList();
    }
}
