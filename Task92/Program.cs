namespace Task92
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Storage<int>.Add(5);
            Storage<string>.Add("4");
            Storage<int>.Add(6);
            Storage<string>.Add("7");
            SomeObject someObject = new SomeObject();
            Storage<SomeObject>.Add(someObject);

            Storage<int>.GetLength();
            Storage<string>.GetLength();
            Storage<SomeObject>.GetLength();

            Storage<int>.Show();
            Storage<string>.Show();
            Storage<SomeObject>.Show();

            Storage<int>.GetElementByIndex(0);
            Storage<string>.GetElementByIndex(0);
            Storage<SomeObject>.GetElementByIndex(0);

            Storage<int>.Remove(5);
            Storage<string>.Remove("4");
            Storage<SomeObject>.Remove(someObject);

            Storage<int>.Show();
            Storage<string>.Show();
            Storage<SomeObject>.Show();
        }
    }
}
