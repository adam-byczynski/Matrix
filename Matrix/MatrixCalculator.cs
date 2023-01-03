// Class MatrixCalculator implements a range of functionalities 
// and operations which can be conducted on matrices.

public static class MatrixCalculator
{
    private static void CheckAdditionAndSubtractionCompatibility(Matrix matrix1, Matrix matrix2)
    {
        if (matrix1.Rows != matrix2.Rows || matrix1.Columns != matrix2.Columns)
        {
            throw new Exception("In order to calculate both matrices have to be of the same length and width!");
        }
    }

    private static void CheckMultiplicationCompatibility(Matrix matrix1, Matrix matrix2)
    {
        if (matrix1.Columns != matrix2.Rows)
        {
            throw new Exception(@"In order to multiply matrices, the number of columns of the 1st matrix must be equal to the number of rows of the 2nd matrix!");
        }
    }

    public static Matrix AddMatrices(Matrix matrix1, Matrix matrix2)
    { 
        CheckAdditionAndSubtractionCompatibility(matrix1, matrix2);
        
        Matrix result = new Matrix(matrix1.Rows, matrix2.Columns); 

        for (int row = 0; row < matrix1.Rows; row++)
        {
            for (int column = 0; column < matrix2.Columns; column++)
            {
                result.matrix[row, column] = matrix1.matrix[row, column] + matrix2.matrix[row, column];
            }
        }
        return result;
    }

    public static Matrix SubtractMatrices(Matrix matrix1, Matrix matrix2)
    {
        CheckAdditionAndSubtractionCompatibility(matrix1, matrix2);
        
        Matrix result = new Matrix(matrix1.Rows, matrix2.Columns); 
        
        for (int row = 0; row < matrix1.Rows; row++)
        {
            for (int column = 0; column < matrix2.Columns; column++)
            {
                result.matrix[row, column] = matrix1.matrix[row, column] - matrix2.matrix[row, column];
            }
        }
        return result;
    }

    public static Matrix MultiplyMatrixByScalar(Matrix matrix, int scalar)
    {
        Matrix result = new Matrix(matrix.Rows, matrix.Columns); 
        
        for (int row = 0; row < matrix.Rows; row++)
        {
            for (int column = 0; column < matrix.Columns; column++)
            {
                result.matrix[row, column] = matrix.matrix[row, column] * scalar;
            }
        }
        return result;
    }
    
    public static Matrix MultiplyMatrices(Matrix matrix1, Matrix matrix2)
    {
        CheckMultiplicationCompatibility(matrix1, matrix2);

        Matrix result = new Matrix(matrix1.Rows, matrix2.Columns);

        for (int row = 0; row < result.Rows; row++)
        {
            for (int column = 0; column < result.Columns; column++)
            {
                int tempSum = 0;

                for (int step = 0; step < result.Columns; step++)
                {
                    tempSum += matrix1.matrix[row, step] * matrix2.matrix[step, column];
                }
                result.matrix[row, column] = tempSum;
            }
        }
        return result;
    }

    public static Matrix TransposeMatrix(Matrix matrix)
    {
        int resultRows = matrix.Columns;
        int resultColumns = matrix.Rows;
        
        Matrix result = new Matrix(resultRows, resultColumns);
        
        for (int row = 0; row < result.Rows; row++)
        {
            for (int column = 0; column < result.Columns; column++)
            {
                result.matrix[row, column] = matrix.matrix[column, row];
            }
        }
        return result;
    }

}
