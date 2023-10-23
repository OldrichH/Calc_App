namespace Calculator_App.Data.Interfaces
{
    public interface IOperation<T>
    {
        string Symbol { get; }
        T Calculate(T a, T b);
    }
}
