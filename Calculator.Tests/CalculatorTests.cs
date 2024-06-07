using Xunit;

namespace Calculator.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void TestAdd()
        {
            Assert.Equal(6L, Add.Eval(1L, 5L));
        }

        [Fact]
        public void TestSubtract()
        {
            Assert.Equal(7L, Subtract.Eval(8L, 1L)); // Ensure the Subtract method exists
        }

        [Fact]
        public void TestMultiply()
        {
            Assert.Equal(6L, Multiply.Eval(2L, 3L)); // Ensure the Multiply method exists
        }

        [Fact]
        public void TestAddOperation()
        {
            Assert.Equal(8, Evaluator.Eval("+", 6, 2));
        }

        [Fact]
        public void TestSubtractOperation()
        {
            Assert.Equal(4, Evaluator.Eval("-", 6, 2));
        }

        [Fact]
        public void TestMultiplyOperation()
        {
            Assert.Equal(12, Evaluator.Eval("*", 6, 2));
        }

        [Fact]
        public void TestSequentialOperations()
        {
            float result1 = Evaluator.Eval("+", 2, 3);
            float result2 = Evaluator.Eval("*", result1, 2);
            Assert.Equal(10, result2);
        }
    }
}
