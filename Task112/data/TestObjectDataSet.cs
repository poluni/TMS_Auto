using System.Collections;
using LINQ.models;

namespace LINQ;

public class TestObjectDataSet : IEnumerable<Client>
{
    public IEnumerator<Client> GetEnumerator()
    {

        var list = new List<Client>()
        {
            new Client(2018, 12, 358),
            new Client(2020, 4, 15),
            new Client(2024, 1, 0),
            new Client(2023, 11, 1),
            new Client(2023, 12, 0),
        };

        foreach (Client s in list)
        {
            yield return s;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}