using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace Assignment5_CollectionFramework
{
    internal class StackException : Exception
    {
        public StackException(string message) : base(message)
        {

        }
    }
}

namespace Assignment5_CollectionFramework
{
    class MyStack<T>
    {
        private int[] Array;
        private int Val;
        private int Size;
        private int Index;

        public MyStack(int size)
        {
            Size = size;
            Array = new int[Size];
            Index = 0;
        }

        public MyStack<T> CloneStack()
        {
            MyStack<T> stack = new MyStack<T>(this.Size);
            for (int i = 0; i < Index; i++)
            {
                stack.Push(this.Array[i]);
            }
            return stack;
        }

        public void Push(int num)
        {
            if (Index < Size)
            {
                Array[Index++] = num;
                Val = Array[Index - 1];
            }
            else throw new StackException("\n\tStack OverFlow.");
        }

        public void Pop()
        {
            if (Index > 0)
            {
                Index--;
                if (Index > 0) Val = Array[Index - 1];
            }
            else throw new StackException("\n\tStack UnderFlow.");
        }

        public int Peek()
        {
            if (Index > 0)
            {
                return Val;
            }
            else throw new StackException("\n\tEmpty Stack");
        }
        public void Show()
        {
            if (Index > 0)
            {
                Console.Write("\n\t");
                for (int i = 0; i < Index; i++)
                {
                    Console.Write(this.Array[i] + " ");
                }
                Console.WriteLine();
            }
            else throw new StackException("\n\tEmpty Stack");
        }
    }
}

namespace Assignment5_CollectionFramework
{
    class systemarray
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("\n 1. Array Operation\n 2. Stack\n 3. Player\n 0. Exit\n Enter Operation: ");
                int outerOpt=Convert.ToInt32(Console.ReadLine());
                if (outerOpt == 0) break;
                if (outerOpt == 1)
                {
                    int[] intArray = new int[] { 1, 5, 3, 6, 4, 2, 8, 7 };
                    string[] stringArray = new string[] { "India", "Pakistan", "Srilanka", "Bhutan", "Nepal", "Bangladesh", "China" };
                    Console.WriteLine("\n Original String Array:");
                    Show(stringArray);
                    Console.WriteLine(" Original Integer Array:");
                    Show(intArray);

                    int[] copyIntArray = new int[intArray.Length];
                    Array.Copy(intArray, copyIntArray, intArray.Length);
                    string[] copyStringArray = new string[stringArray.Length];
                    Array.Copy(stringArray, copyStringArray, stringArray.Length);
                    Console.WriteLine("\n Copied String Array:");
                    Show(copyStringArray);
                    Console.WriteLine(" Copied Integer Array:");
                    Show(copyIntArray);

                    int[] sortIntArray = new int[intArray.Length];
                    Array.Copy(intArray, sortIntArray, intArray.Length);
                    Array.Sort(sortIntArray);
                    string[] sortStringArray = new string[stringArray.Length];
                    Array.Copy(stringArray, sortStringArray, stringArray.Length);
                    Array.Sort(sortStringArray);
                    Console.WriteLine("\n Sorted String Array:");
                    Show(sortStringArray);
                    Console.WriteLine(" Sorted Integer Array:");
                    Show(sortIntArray);

                    int[] clearIntArray = new int[intArray.Length];
                    Array.Copy(intArray, clearIntArray, intArray.Length);
                    Array.Clear(clearIntArray, 0, clearIntArray.Length);
                    string[] clearStringArray = new string[stringArray.Length];
                    Array.Copy(stringArray, clearStringArray, stringArray.Length);
                    Array.Clear(clearStringArray, 0, clearStringArray.Length);
                    Console.WriteLine("\n String Array is Cleared");
                    Console.WriteLine(" Integer Array is Cleared");

                    int[] revIntArray = new int[intArray.Length];
                    Array.Copy(intArray, revIntArray, intArray.Length);
                    Array.Reverse(revIntArray);
                    string[] revStringArray = new string[stringArray.Length];
                    Array.Copy(stringArray, revStringArray, stringArray.Length);
                    Array.Reverse(revStringArray);
                    Console.WriteLine("\n Reversed String Array:");
                    Show(revStringArray);
                    Console.WriteLine(" Reversed Integer Array:");
                    Show(revIntArray);
                }







                static void Show<T>(T[] Array)
                {
                    Console.Write(" [ ");
                    foreach (T t in Array)
                    {
                        Console.Write(t + " ");
                    }
                    Console.WriteLine("]");
                }
            }
        }
    }
}