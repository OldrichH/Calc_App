using Calculator_App.Data.Operations;
using Calculator_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Tests
{
    public class OperationsUnitTest
    {
        Addition a = new Addition();
        [Fact]
        public void Calculate_1plus2_Equals3()
        {
            Assert.Equal(3, a.Calculate(1, 2));
        }
        [Fact]
        public void Calculate_1plus2_NotEquals1()
        {
            Assert.NotEqual(1, a.Calculate(1, 2));
        }

        Substraction s = new Substraction();
        [Fact]
        public void Calculate_3minus1_Equals2()
        {
            Assert.Equal(2, s.Calculate(3, 1));
        }
        [Fact]
        public void Calculate_3minus1_NotEquals3()
        {
            Assert.NotEqual(3, s.Calculate(3, 1));
        }

        Multiplication m = new Multiplication();
        [Fact]
        public void Calculate_2multiplicated2_Equals4()
        {
            Assert.Equal(4, m.Calculate(2, 2));
        }
        [Fact]
        public void Calculate_2multiplicated2_NotEquals2()
        {
            Assert.NotEqual(2, m.Calculate(2, 2));
        }

        Division d = new Division();
        [Fact]
        public void Calculate_2divided2_Equals1()
        {
            Assert.Equal(1, d.Calculate(2, 2));
        }
        [Fact]
        public void Calculate_2divided2_NotEquals2()
        {
            Assert.NotEqual(2, d.Calculate(2, 2));
        }
        [Fact]
        public void Calculate_2divided0_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => d.Calculate(2,0));
        }
    }
}
