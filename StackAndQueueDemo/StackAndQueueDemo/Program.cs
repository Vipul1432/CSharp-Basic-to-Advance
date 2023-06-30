namespace StackAndQueueDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            Console.WriteLine(stack.TryPeek(out int result1));
            Console.WriteLine(result1);
            Console.WriteLine(stack.TryPop(out int result));
            Console.WriteLine(result);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());

            foreach (var item in stack)
            {
                Console.WriteLine(item);
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------Queue-------------------");

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            //! return first value 
            Console.WriteLine(queue.Peek());
            //! return first value 
            Console.WriteLine(queue.First());
            //! return last value 
            Console.WriteLine(queue.Last());
            //! return boolean value
            Console.WriteLine(queue.Contains(3));
            //! reverse the queue
            Console.WriteLine(queue.Reverse().First());
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            } 
        }
    }
}