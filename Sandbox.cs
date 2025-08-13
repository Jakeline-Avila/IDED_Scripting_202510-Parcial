using System;
using System.Collections.Generic;
namespace TestProject1
{
    internal class Sandbox
    {
        public static void Main(string[] args)
        {
            
            var pila = new Stack<uint>(new uint[] { 2, 34, 67, 89, 12, 45, 78, 56, 23, 90, 14, 38 });

            Console.WriteLine("Pila original (TOP → BOTTOM):");
            foreach (var n in pila)
                Console.Write(n + " ");
            Console.WriteLine();

           
            TestMethods.RemoveFirstPrime(pila);

            Console.WriteLine("Pila después de eliminar el primer primo:");
            foreach (var n in pila)
                Console.Write(n + " ");
            Console.WriteLine();
        }
    }
}

    
