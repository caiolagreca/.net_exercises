/* 
Exercise: Generic Stack Class (Medium)
Description: Create a generic stack class that works for any type of data (e.g., integers, strings, or custom objects). The stack should implement basic operations such as Push, Pop, Peek, and IsEmpty.

Requirements:

Implement a generic class GenericStack<T>.
Implement the methods:
Push(T item) – Adds an item to the stack.
Pop() – Removes and returns the item from the top of the stack.
Peek() – Returns the item at the top without removing it.
IsEmpty() – Returns true if the stack is empty.
 */

namespace Generics
{
    public class GenericStack<T>
    {

        private List<T> _stack = new List<T>();

        public void Push(T item)
        {
            _stack.Add(item);
        }

        public bool IsEmpty() => _stack.Count == 0;

        public T Pop()
        {
            if (IsEmpty()) throw new InvalidOperationException("Stack is Empty");
            _stack.RemoveAt(_stack.Count - 1);
            return _stack[_stack.Count - 1];
        }

        public T Peek()
        {
            if (IsEmpty()) throw new InvalidOperationException("Stack is Empty");
            return _stack[_stack.Count - 1];
        }

        public static void Main(string[] args)
        {
            GenericStack<int> stack = new GenericStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Peek();
            stack.Pop();
            Console.WriteLine(stack.Peek());
        }

    }
}