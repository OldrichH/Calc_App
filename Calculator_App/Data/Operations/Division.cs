using Calculator_App.Data.Interfaces;

namespace Calculator_App.Data.Operations
{
    public class Division : IOperation<double>
    {
        string symbol = "/";
        public string Symbol
        {
            get
            {
                return symbol;
            }
        }

        public double Calculate(double a, double b)
        {
            if (this.Validate(b)) return a / b;

            throw new ArgumentException("Parameter cannot be \"0\"", nameof(b));
        }

        private bool Validate(double b) 
        {
            if (b == 0) return false;
            return true;       
        }
    }
}
