using System;
using System.Collections.Generic;
namespace TestProject1
{
    internal class Sandbox
    {
        public static void Main(string[] args)
        {
               
    {
            // Pila para probar RemoveFirstPrime, CreateQueueFromStack y StackToList
            var pila = new Stack<uint>(new uint[] { 2, 34, 67, 89, 12, 45, 78, 56, 23, 90, 14, 38 });

            Console.WriteLine("Pila original (TOP -> BOTTOM):");
            foreach (var n in pila) Console.Write(n + " ");
            Console.WriteLine();

            // --- Probar RemoveFirstPrime ---
            TestMethods.RemoveFirstPrime(pila);
            Console.WriteLine("\nDespués de RemoveFirstPrime:");
            foreach (var n in pila) Console.Write(n + " ");
            Console.WriteLine();

            // --- Probar CreateQueueFromStack ---
            var cola = TestMethods.CreateQueueFromStack(pila);
            Console.WriteLine("\nCola creada desde la pila:");
            foreach (var n in cola) Console.Write(n + " ");
            Console.WriteLine();

            // --- Probar StackToList ---
            var listaPila = TestMethods.StackToList(pila);
            Console.WriteLine("\nLista creada desde la pila:");
            foreach (var n in listaPila) Console.Write(n + " ");
            Console.WriteLine();

            // --- Probar FoundElementAfterSorted ---
            var listaEnteros = new List<int> { -50, 23, 87, -12, 4, 95, -66, 8, 32, -71, 42, -18 };
            Console.WriteLine("\n¿Está el número 42 después de ordenar? " +
                              TestMethods.FoundElementAfterSorted(listaEnteros, 42));

            Console.WriteLine("Lista ordenada:");
            foreach (var n in listaEnteros) Console.Write(n + " ");
            Console.WriteLine();
        }
    }
}
}
        
    


    
