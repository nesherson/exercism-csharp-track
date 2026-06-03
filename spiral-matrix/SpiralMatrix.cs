public class SpiralMatrix
{
    public static int[,] GetMatrix(int size)
    {
        var matrix = new int[size, size];

        FillMatrix(matrix);

        return matrix;
    }

    private static void FillMatrix(int[,] matrix)
    {
        var rowIndex = 0;
        var colIndex = 0;
        var counter = 0;
        var moveDirection = MoveDirection.Right;

        while (counter < matrix.Length)
        {
            matrix[rowIndex, colIndex] = counter + 1;

            if (CanMoveForward(matrix, rowIndex, colIndex, moveDirection))
            {
                (rowIndex, colIndex) = MoveForward(rowIndex, colIndex, moveDirection);
            }
            else
            {
                moveDirection = GetNewMoveDirection(moveDirection);
                (rowIndex, colIndex) = MoveForward(rowIndex, colIndex, moveDirection);
            }

            counter++;
        }
    }

    private static bool CanMoveForward(int[,] matrix, int rowIndex, int colIndex, MoveDirection direction)
    {
        return direction switch
        {
            MoveDirection.Up => rowIndex - 1 >= 0 &&
                                matrix[rowIndex - 1, colIndex] == 0,
            MoveDirection.Down => rowIndex + 1 < matrix.GetLength(0) &&
                                   matrix[rowIndex + 1, colIndex] == 0,
            MoveDirection.Left => colIndex - 1 >= 0 &&
                                   matrix[rowIndex, colIndex - 1] == 0,
            MoveDirection.Right => colIndex + 1 < matrix.GetLength(1) &&
                                   matrix[rowIndex, colIndex + 1] == 0,
            _ => throw new ArgumentOutOfRangeException(nameof(direction)),
        };

    }

    private static (int, int) MoveForward(int rowIndex, int colIndex, MoveDirection direction)
    {
        return direction switch
        {
            MoveDirection.Up => (rowIndex - 1, colIndex),
            MoveDirection.Down => (rowIndex + 1, colIndex),
            MoveDirection.Left => (rowIndex, colIndex - 1),
            MoveDirection.Right => (rowIndex, colIndex + 1),
            _ => throw new ArgumentOutOfRangeException(nameof(direction))
        };
    }

    private static MoveDirection GetNewMoveDirection(MoveDirection direction)
    {
        return direction switch
        {
            MoveDirection.Up => MoveDirection.Right,
            MoveDirection.Down => MoveDirection.Left,
            MoveDirection.Left => MoveDirection.Up,
            MoveDirection.Right => MoveDirection.Down,
            _ => throw new ArgumentOutOfRangeException(nameof(direction))
        };
    }
}

public enum MoveDirection
{
    Up,
    Down,
    Left,
    Right
}
