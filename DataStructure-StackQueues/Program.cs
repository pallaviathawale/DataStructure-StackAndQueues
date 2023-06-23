namespace DataStructure_StackQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StackQueueDemo stackqueue = new StackQueueDemo();
            //stackqueue.Push(70);
            //stackqueue.Push(30);
            //stackqueue.Push(56);
            //Console.WriteLine("-----------Stack before empty operation-----------");
            //stackqueue.Display();
            //Console.WriteLine("\n--------------------------------------------------");
            //Console.Write("\n");
            //stackqueue.IsEmpty();
            //Console.WriteLine("-----------Stack after empty operation-----------");
            //stackqueue.Display();
            //Console.WriteLine("-------------------------------------------------");


            Queue linkedListQueue = new Queue();
            linkedListQueue.Enqueue(56);
            linkedListQueue.Enqueue(30);
            linkedListQueue.Enqueue(70);
            linkedListQueue.Display();
        }
    }
    
}