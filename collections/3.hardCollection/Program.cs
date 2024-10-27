/* 
Exercise 3: Customer Service Queue (Hard)
Description: In a customer service system, incoming service requests are added to a queue.
Using Queue<string>, create a system that can:

Add new clients to the queue.
Serve the next client in line (removing them).
Display the current client being served.
Show the total number of clients still in line.

Requirements:
Use Queue<string>.
Add methods to add clients, serve clients, and display the current client.
Track the queue as it updates in real time.

Tips:
Use Enqueue() to add a client and Dequeue() to serve the next client.
Peek() allows you to view the next client without removing them from the queue.
 */

namespace Collection
{
    class Program
    {
        private static Queue<string> queue = new Queue<string>();
        static void NewClients(string client)
        {
            queue.Enqueue(client);
        }

        static void ServeClient()
        {
            if (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
            else
            {
                Console.WriteLine("The queue is empty.");
            }
        }
        
        static void CurrentClient()
        {
            if (queue.Count > 0)
            {
                Console.WriteLine(queue.Peek());
            }
            else
            {
                Console.WriteLine("The queue is empty.");
            }
        }

        static void TotalClients()
        {
            var total = queue.Count;
            Console.WriteLine($"The total clients is {total}");

        }

        static void Main(string[] args)
        {
            ServeClient();
            NewClients("Caio");
            NewClients("Niedja");
            NewClients("Rodrigo");
            NewClients("Claudia");
            ServeClient();
            CurrentClient();
            TotalClients();
        }
    }
}