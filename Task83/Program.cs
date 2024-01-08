namespace Task83
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> numberList = new LinkedList<int>();
            numberList.AddLast(1);
            numberList.AddLast(2);
            numberList.AddLast(3);
            numberList.AddLast(4);
            numberList.AddLast(4);
            numberList.AddLast(5);

            Console.WriteLine("Элементы в списке:");
            Helper.PrintCollection(numberList);

            LinkedListNode<int> currentNode = numberList.First;
            while (currentNode.Next != null)
            {
                if (currentNode.Value != currentNode.Next.Value) currentNode = currentNode.Next;
                else numberList.Remove(currentNode.Value);
            }

            Console.WriteLine("Элементы в списке:");
            Helper.PrintCollection(numberList);
        }
    }
}
