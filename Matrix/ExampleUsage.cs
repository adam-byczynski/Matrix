// Usage examples of Matrix Calculations

public class ExampleUsage {
    public ExampleUsage()
    {
        Examples();
    }

    private void Examples() 
    {      
        Matrix matrix1 = new Matrix(rows: 3, columns: 3);
        Console.WriteLine("Matrix 1");
        matrix1.DisplayMatrix();
        
        Matrix matrix2 = new Matrix(rows: 3, columns: 3);
        Console.WriteLine("Matrix 2");
        matrix2.DisplayMatrix();
        
        ExampleAdd(matrix1, matrix2);
        ExampleSubtract(matrix1, matrix2);
        ExampleMultiply(matrix1, matrix2);
        ExampleScalarMultiply(matrix1, scalar: 5);
        ExampleTranspose(matrix2);
        ExampleCalculateDeterminant(matrix2, "matrix2");
        ExampleIdentity(matrix1, "matrix1");
        ExampleIdentity(matrix2, "matrix2");
        
        Matrix matrix3 = new Matrix(rows: 4, columns: 4);
        matrix3.MakeIdentity();        
        
        ExampleMakeIdentity(matrix3, "matrix3");
    }

    private static void ExampleAdd(Matrix matrix1, Matrix matrix2) 
    {
        Matrix result = MatrixCalculator.AddMatrices(matrix1, matrix2);
        Console.WriteLine("Matrix addition");
        result.DisplayMatrix();
    }

    private static void ExampleSubtract(Matrix matrix1, Matrix matrix2) 
    {
        Matrix result = MatrixCalculator.SubtractMatrices(matrix1, matrix2);
        Console.WriteLine("Matrix subtraction");
        result.DisplayMatrix();
    }

    private static void ExampleMultiply(Matrix matrix1, Matrix matrix2) 
    {
        Matrix result = MatrixCalculator.MultiplyMatrices(matrix1, matrix2);
        Console.WriteLine("Matrix multiplication");
        result.DisplayMatrix();
    }

    private static void ExampleScalarMultiply(Matrix matrix1, int scalar) 
    {
        Matrix result = MatrixCalculator.MultiplyMatrixByScalar(matrix1, scalar);
        Console.WriteLine("Matrix 1 multiplication by scalar");
        result.DisplayMatrix();
    }

    private static void ExampleTranspose(Matrix matrix) 
    {
        Matrix result = MatrixCalculator.TransposeMatrix(matrix);
        Console.WriteLine("Matrix 2 transposition");
        result.DisplayMatrix();
    }
    
    private static void ExampleIdentity(Matrix matrix, string matrixName)
    {
        string result = matrix.IsIdentityMatrix() ? "true" : "false";
        Console.WriteLine($"Identity test of {matrixName}: {result}");
    }

    private static void ExampleMakeIdentity(Matrix matrix, string matrixName)
    {
        Console.WriteLine("");

        Console.WriteLine(matrix.IsIdentityMatrix()
            ? $"{matrixName} is an identity matrix."
            : $"{matrixName} is not an identity matrix.");
        matrix.DisplayMatrix();        
    }

    private static void ExampleCalculateDeterminant(Matrix matrix, string matrixName)
    {
        Console.WriteLine($"Determinant of {matrixName}: {matrix.CalculateDeterminant()}");
    }
}