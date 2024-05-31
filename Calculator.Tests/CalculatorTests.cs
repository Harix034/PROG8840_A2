namespace Calculator.Tests;

public class CalculatorTests
{
    [Fact]
    public void TestAdd()
    {
        Assert.Equal(6L, Add.Eval(1L, 5L));
    }
    [Fact]
    public void TestMult()
    {
        Assert.Equal(6L, Multiply.Eval(2L, 3L));
    }
    [Fact]
    public void TestAddOperation()
    {
        Assert.Equal(8, Evaluator.Eval("+", 6, 2));
    }
    [Fact]
    public void TestMultiplyOperation()
    {
        Assert.Equal(12, Evaluator.Eval("*", 6, 2));
    }
    [Fact]
    public void Add_TwoPositiveNumbers_ReturnsCorrectResult()
    {
        // Arrange
        float lhs = 10.0f;
        float rhs = 5.0f;

        // Act
        float result = Add.Eval(lhs, rhs);

        // Assert
        Assert.Equal(15.0f, result);
    }

    [Fact]
    public void Add_TwoNegativeNumbers_ReturnsCorrectResult()
    {
        // Arrange
        float lhs = -10.0f;
        float rhs = -5.0f;

        // Act
        float result = Add.Eval(lhs, rhs);

        // Assert
        Assert.Equal(-15.0f, result);
    }

    [Fact]
    public void Add_PositiveAndNegativeNumber_ReturnsCorrectResult()
    {
        // Arrange
        float lhs = 10.0f;
        float rhs = -5.0f;

        // Act
        float result = Add.Eval(lhs, rhs);

        // Assert
        Assert.Equal(5.0f, result);
    }
    [Fact]
    public void Multiply_TwoPositiveNumbers_ReturnsCorrectResult()
    {
        // Arrange
        float lhs = 10.0f;
        float rhs = 5.0f;

        // Act
        float result = Multiply.Eval(lhs, rhs);

        // Assert
        Assert.Equal(50.0f, result);
    }

    [Fact]
    public void Multiply_PositiveAndNegativeNumber_ReturnsCorrectResult()
    {
        // Arrange
        float lhs = 10.0f;
        float rhs = -5.0f;

        // Act
        float result = Multiply.Eval(lhs, rhs);

        // Assert
        Assert.Equal(-50.0f, result);
    }

    [Fact]
    public void Multiply_ByZero_ReturnsZero()
    {
        // Arrange
        float lhs = 10.0f;
        float rhs = 0.0f;

        // Act
        float result = Multiply.Eval(lhs, rhs);

        // Assert
        Assert.Equal(0.0f, result);
    }
    [Fact]
    public void Subtract_TwoPositiveNumbers_ReturnsCorrectResult()
    {
        // Arrange
        float lhs = 10.0f;
        float rhs = 5.0f;

        // Act
        float result = Evaluator.Eval("-", lhs, rhs);

        // Assert
        Assert.Equal(5.0f, result);
    }

    [Fact]
    public void Subtract_TwoNegativeNumbers_ReturnsCorrectResult()
    {
        // Arrange
        float lhs = -10.0f;
        float rhs = -5.0f;

        // Act
        float result = Evaluator.Eval("-", lhs, rhs);

        // Assert
        Assert.Equal(-5.0f, result);
    }

    [Fact]
    public void Subtract_PositiveAndNegativeNumber_ReturnsCorrectResult()
    {
        // Arrange
        float lhs = 10.0f;
        float rhs = -5.0f;

        // Act
        float result = Evaluator.Eval("-", lhs, rhs);

        // Assert
        Assert.Equal(15.0f, result);
    }
}