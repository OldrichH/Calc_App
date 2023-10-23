using Calculator_App.Data.Interfaces;
using Calculator_App.Data.Operations;
using Calculator_App.Models;
using System.Text.RegularExpressions;

namespace Calculator_App.Data
{
    public class OperationsContext
    {
        private Logger exLog = new Logger();

        private List<IOperation<double>> operations = new List<IOperation<double>>()
        {
            new Addition(),
            new Substraction(),
            new Multiplication(),
            new Division()          
        };

        public double Calculate (Calculator c)
        {
            double result = 0;
            try
            {
                this.operations.ForEach(op =>
                {
                    if (op.Symbol == c.Operation) result = op.Calculate(c.ValueA, c.ValueB);
                });
            }
            catch (Exception ex)
            {
                this.SendError(ex);
            }

            if(c.ReturnInteger == true) return Math.Round(result);
            
            return result;
        }
        private void SendError(Exception ex) 
        {
            exLog.WriteException(ex);
        }

    }
}
