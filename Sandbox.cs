using System;
using System.Collections.Generic;

namespace TestProject1
{
    internal class Sandbox
    {
        public static void Main(string[] args)
     {
            var pila = new Stack<uint>(new uint[] { 2, 34, 67, 89, 12, 45, 78, 56, 23, 90, 14, 38 });

            Console.WriteLine("StackFirstPrime: " + TestMethods.StackFirstPrime(pila));

            TestMethods.RemoveFirstPrime(pila);
            Console.WriteLine("Después de RemoveFirstPrime:");
            foreach (var n in pila) Console.Write(n + " ");
            Console.WriteLine();

            var cola = TestMethods.CreateQueueFromStack(pila);
            Console.WriteLine("Cola desde la pila:");
            foreach (var n in cola) Console.Write(n + " ");
            Console.WriteLine();

            var listaPila = TestMethods.StackToList(pila);
            Console.WriteLine("Lista desde la pila:");
            foreach (var n in listaPila) Console.Write(n + " ");
            Console.WriteLine();

                    var listaEnteros = new List<int> { -50, 23, 87, -12, 4, 95, -66, 8, 32, -71, 42, -18 };
            Console.WriteLine("FoundElementAfterSorted (42): " + TestMethods.FoundElementAfterSorted(listaEnteros, 42));
            Console.WriteLine("Lista ordenada:");
            foreach (var n in listaEnteros) Console.Write(n + " ");
            Console.WriteLine();
        }
    }
}



    
