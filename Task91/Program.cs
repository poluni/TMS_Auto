namespace Task91
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PointStruct<int> point1 = new(2, 3);
            PointStruct<float> point2 = new(2.2f, 3.3f);
            PointStruct<double> point3 = new(2.2, 3.3);

            point1.Show();
            point2.Show();
            point3.Show();
        }
    }
}
