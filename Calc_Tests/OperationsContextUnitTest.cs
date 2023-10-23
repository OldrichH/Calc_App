using Calculator_App.Data;
using Calculator_App.Models;
using NuGet.Frameworks;

namespace Calc_Tests
{
    public class OperationsContextUnitTest
    {
        private OperationsContext context = new OperationsContext();
        [Fact]
        public void Calculate_5plus5_Equals10()
        {
            Calculator c = new Calculator()
            {
                Operation = "+",
                ValueA = 5,
                ValueB = 5,
            };
            Assert.Equal(10, context.Calculate(c));
        }
        [Fact]
        public void Calculate_5plus5_NotEquals5() 
        {
            Calculator c = new Calculator()
            {
                Operation = "+",
                ValueA = 5,
                ValueB = 5,
            };
            Assert.NotEqual(5, context.Calculate(c));
        }
        [Fact]
        public void Calculate_10minu5_Equals5()
        {
            Calculator c = new Calculator()
            {
                Operation = "-",
                ValueA = 10,
                ValueB = 5,
            };
            Assert.Equal(5, context.Calculate(c));
        }
        [Fact]
        public void Calculate_10minus5_NotEquals10()
        {
            Calculator c = new Calculator()
            {
                Operation = "-",
                ValueA = 10,
                ValueB = 5,
            };
            Assert.NotEqual(10, context.Calculate(c));
        }
        [Fact]
        public void Calculate_2multiplicated2_Equals4()
        {
            Calculator c = new Calculator()
            {
                Operation = "*",
                ValueA = 2,
                ValueB = 2,
            };
            Assert.Equal(4, context.Calculate(c));
        }
        [Fact]
        public void Calculate_2multiplicated2_NotEquals2()
        {
            Calculator c = new Calculator()
            {
                Operation = "*",
                ValueA = 2,
                ValueB = 2,
            };
            Assert.NotEqual(2, context.Calculate(c));
        }
        [Fact]
        public void Calculate_2divided2_Equals1()
        {
            Calculator c = new Calculator()
            {
                Operation = "/",
                ValueA = 2,
                ValueB = 2,
            };
            Assert.Equal(1, context.Calculate(c));
        }
        [Fact]
        public void Calculate_2divided2_NotEquals2()
        {
            Calculator c = new Calculator()
            {
                Operation = "/",
                ValueA = 2,
                ValueB = 2,
            };
            Assert.NotEqual(2, context.Calculate(c));
        }
    }
}