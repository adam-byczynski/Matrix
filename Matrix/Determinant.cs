public static class Determinant
{
    private static int CalculateDeterminantOf2X2Matrix(int[,] matrix)
    {
        return matrix[0, 0] * matrix [1, 1] - matrix[1, 0] * matrix[0, 1];
    }

    public static int CalculateDeterminantRecursively(int[,] matrix, int size)
    {
        int determinant = 0;
        int[,] submatrix = new int[size, size];
        
        // If the size of the matrix is 2, calculate the determinant directly.
        if (size == 2)
        {
            return CalculateDeterminantOf2X2Matrix(matrix);
        }
        else
        {
            // Loop over the elements in the first row of the matrix.
            for (int elementIndex = 0; elementIndex < size; elementIndex++)
            {
                // Initialize indices for the submatrix.
                int submatrixRowIndex = 0;
                
                // Loop over the rows of the matrix, starting from the second row.
                for (int rowIndex = 1; rowIndex < size; rowIndex++)
                {
                    int submatrixColumnIndex = 0;
                    
                    // Loop over the columns of the matrix.
                    for (int columnIndex = 0; columnIndex < size; columnIndex++)
                    {
                        // Skip the element in the first row and column that is being used to calculate the cofactor.
                        if (columnIndex == elementIndex)
                            continue;
                        
                        // Add the element to the submatrix.
                        submatrix[submatrixRowIndex, submatrixColumnIndex] = matrix[rowIndex, columnIndex];
                        submatrixColumnIndex++;
                    }
                    submatrixRowIndex++;
                }
                
                // Calculate the cofactor of the element.
                int operationSign = (int)Math.Pow(-1, elementIndex);
                int cofactor = matrix[0, elementIndex];
                
                determinant += (operationSign * cofactor * CalculateDeterminantRecursively(submatrix, size - 1 ));
            }
        }
        return determinant;
    }
}

