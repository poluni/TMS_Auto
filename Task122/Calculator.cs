using System.Numerics;

namespace Task122;

public class Calculator
{
    internal TResult Div<T, TResult>(T x, T y) where T : INumber<T>
                                               where TResult : INumber<TResult>
    {
        return TResult.CreateChecked(x / y);
    }
}