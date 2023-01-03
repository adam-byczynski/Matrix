//Class Matrix implements an object of a matrix with additional functionalities.

public class Matrix
{
public readonly int Rows;
public readonly int Columns;
public int[,] matrix;

private const int RandomMinConstraint = 0;
private const int RandomMaxConstraint = 10;

private bool IsMatrixSquare()
{
    return Rows == Columns;
}

public Matrix(int rows, int columns)
{ 
    Rows = rows;
    Columns = columns;
    
    matrix = new int[rows, columns];
    
    FillWithRandomNumbers();
}

public void FillWithRandomNumbers()
{
    Random random = new Random();
    
    for (int row = 0; row < Rows; row++)
    {
        for (int column = 0; column < Columns; column++)
        {
            matrix[row, column] = random.Next(RandomMinConstraint, RandomMaxConstraint + 1);
        }
    }
}

public void FillWithZeros()
{
    for (int row = 0; row < Rows; row++)
    {
        for (int column = 0; column < Columns; column++)
        {
            matrix[row, column] = 0;
        }
    }
}

public void SetValue(int row, int column, int value)
{
    matrix[row, column] = value;
}

public int GetValue(int row, int column)
{
    return matrix[row, column];
}

public void DisplayMatrix()
{
    for (int row = 0; row < Rows; row++)
    {
        for (int column = 0; column < Columns; column++)
        {
            Console.Write("{0,-4}", matrix[row, column] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

public bool IsIdentityMatrix()
{   
    bool isIdentity = true;

    if (!IsMatrixSquare())
    {
        isIdentity = false;
        return isIdentity;
    }
    
    for (int row = 0; row < Rows; row++)
    {
        for (int column = 0; column < Columns; column++)
        {
            if (row == column && matrix[row, column] != 1)
            {
                isIdentity = false;
            }
            else if (row != column && matrix[row, column] != 0)
            {
                isIdentity = false;
            }
        }
    }
    return isIdentity;
}

public int CalculateDeterminant()
{
    int determinant = 0;

    if(!IsMatrixSquare())
    {
        throw new Exception(@"In order to calculate determinant the matrix
                            must have equal number of rows and columns!");
    }

    int matrixSize = matrix.GetLength(0);
    determinant = Determinant.CalculateDeterminantRecursively(matrix, matrixSize);  

    return determinant;
}

public void MakeIdentity()
{
    if(!IsMatrixSquare())
    {
        throw new Exception("This matrix is not a square matrix, therefore it can't become an identity matrix!");
    }

    for (int row = 0; row < Rows; row++)
    {
        for (int column = 0; column < Columns; column++)
        {
            if (row == column)
            {
                matrix[row, column] = 1;
            }
            else if (row != column)
            {
                matrix[row, column] = 0;
            }
        }
    }
}
}

