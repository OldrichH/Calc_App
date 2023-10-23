using Calculator_App.Data.Interfaces;

namespace Calculator_App.Data.Operations
{
    public class Multiplication : IOperation<double>
    {
        string symbol = "*";
        public string Symbol
        {
            get
            {
                return symbol;
            }
        }

        public double Calculate(double a, double b)
        {
            return a * b;
        }
    }
}
