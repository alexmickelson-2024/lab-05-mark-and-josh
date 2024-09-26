using System.Threading.Tasks.Dataflow;
using FluentAssertions;
using static MainProgram.Program;

namespace TestProject;

public class UnitTest1
{
    /*[Fact]
    public void TestLayoutOfDisplayBoard()
    {
        // Arrange
            char[] board = new char[9] { 'O', 'X', 'O', 'd', 'e', 'O', 'g', 'h', 'i' };
        // Act
            DisplayBoard(board);
        // Assert

    }*/

    [Fact]
    public void TestHasWinnerTopRow()
    {
        //Arrange
        char[] board = new char[9] { 'X', 'X', 'X', 'd', 'e', 'O', 'g', 'h', 'i' };
        
        // Act
        bool result = HasWinner(board);

        // Assert
        result.Should().BeTrue();

    }

    [Fact]
    public void TestHasWinnerMiddleRow()
    {
        //Arrange
        char[] board = new char[9] { 'a', 'b', 'c', 'X', 'X', 'X', 'g', 'h', 'i' };
        
        // Act
        bool result = HasWinner(board);

        // Assert
        result.Should().BeTrue();

    }

    [Fact]
    public void TestHasWinnerBottomRow()
    {
        //Arrange
        char[] board = new char[9] { 'a', 'b', 'c', 'd', 'e', 'f', 'X', 'X', 'X' };
        
        // Act
        bool result = HasWinner(board);

        // Assert
        result.Should().BeTrue();

    }

    [Fact]
    public void TestHasWinnerLeftColumn()
    {
        //Arrange
        char[] board = new char[9] { 'X', 'b', 'c', 'X', 'e', 'f', 'X', 'h', 'i' };
        
        // Act
        bool result = HasWinner(board);

        // Assert
        result.Should().BeTrue();

    }

    [Fact]
    public void TestHasWinnerMiddleColumn()
    {
        //Arrange
        char[] board = new char[9] { 'a', 'X', 'c', 'd', 'X', 'f', 'g', 'X', 'i' };
        
        // Act
        bool result = HasWinner(board);

        // Assert
        result.Should().BeTrue();

    }

    [Fact]
    public void TestHasWinnerRightColumn()
    {
        //Arrange
        char[] board = new char[9] { 'a', 'b', 'X', 'd', 'e', 'X', 'g', 'h', 'X' };
        
        // Act
        bool result = HasWinner(board);

        // Assert
        result.Should().BeTrue();

    }

    [Fact]
    public void TestHasWinnerTopLeftDiagonal()
    {
        //Arrange
        char[] board = new char[9] { 'X', 'b', 'c', 'd', 'X', 'f', 'g', 'h', 'X' };
        
        // Act
        bool result = HasWinner(board);

        // Assert
        result.Should().BeTrue();

    }

    [Fact]
    public void TestHasWinnerTopRightDiagonal()
    {
        //Arrange
        char[] board = new char[9] { 'a', 'b', 'X', 'd', 'X', 'f', 'X', 'h', 'i' };
        
        // Act
        bool result = HasWinner(board);

        // Assert
        result.Should().BeTrue();

    }
}