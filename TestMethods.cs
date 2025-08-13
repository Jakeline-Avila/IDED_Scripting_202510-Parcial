using System.Collections.Generic;

namespace TestProject1
{
    internal class TestMethods
    {
        internal static uint StackFirstPrime(Stack<uint> stack)
        {

            
            return 0;
        }

        internal static Stack<uint> RemoveFirstPrime(Stack<uint> stack)
        {
             if (stack == null || stack.Count == 0) return stack;

   
        bool IsPrime(uint n)
    {
        if (n < 2) return false;
        for (uint d = 2; d * d <= n; d++)
            if (n % d == 0) return false;
        return true;
    }

     var temp = new Stack<uint>();
        bool removed = false;

    
        while (stack.Count > 0)
     {
        uint x = stack.Pop();
        if (!removed && IsPrime(x))
        {
            removed = true;            
        }
        else
        {
            temp.Push(x);
        }
    }


    while (temp.Count > 0)
        stack.Push(temp.Pop());

    return stack;
        }

        internal static Queue<uint> CreateQueueFromStack(Stack<uint> stack)
        {

             var queue = new Queue<uint>();
    
        foreach (var item in stack) 
        {
        queue.Enqueue(item);
         }
    
    return queue;
          
        }

        internal static List<uint> StackToList(Stack<uint> stack)
        {
             var list = new List<uint>(stack.Count);

        foreach (var item in stack) 
        {
        list.Add(item);
        }

        return list;
         
        }

        internal static bool FoundElementAfterSorted(List<int> list, int value)
        {
            return false;
        }
    }
}