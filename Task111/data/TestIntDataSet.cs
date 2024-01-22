using System.Collections;

namespace LINQ;

public class TestIntDataSet : IEnumerable<int>
{
    public IEnumerator<int> GetEnumerator()
    {
        for (int i = 0; i <= 10; i++)
        {
            yield return new Random().Next(0, 12);
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}