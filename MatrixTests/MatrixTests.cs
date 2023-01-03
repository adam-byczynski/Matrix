namespace MatrixTests
{
    public class Tests
    {
        private readonly Matrix _matrix1 = new (rows: 3, columns: 3);
        private readonly Matrix _matrix2 = new (rows: 3, columns: 3);

        public Tests()
        {
            _matrix1.matrix = new[,]
            {
                { 2, 6, 7 }, { 9, 6, 5 }, { 4, 3, 9 }
            };

            _matrix2.matrix = new[,]
            {
                { 3, 4, 8 }, { 8, 7, 8 }, { 10, 8, 9 }
            };
        }

        [Test]
        public void TestAddMatrices()
        {
            Matrix result = new Matrix(rows: 3, columns: 3)
            {
                matrix = new[,]
                {
                    { 5, 10, 15 }, { 17, 13, 13 }, { 14, 11, 18 }
                }
            };

            CollectionAssert.AreEqual(result.matrix, MatrixCalculator.AddMatrices(_matrix1, _matrix2).matrix);
        }

        [Test]
        public void TestSubtractMatrices()
        {
            Matrix result = new Matrix(rows: 3, columns: 3)
            {
                matrix = new[,]
                {
                    { -1, 2, -1 }, { 1, -1, -3 }, { -6, -5, 0 }
                }
            };

            CollectionAssert.AreEqual(result.matrix, MatrixCalculator.SubtractMatrices(_matrix1, _matrix2).matrix);
        }

        [Test]
        public void TestMultiplyMatrixByScalar()
        {
            Matrix result = new Matrix(rows: 3, columns: 3)
            {
                matrix = new[,]
                {
                    { 10, 30, 35 }, { 45, 30, 25 }, { 20, 15, 45 }
                }
            };
            const int scalar = 5;

            CollectionAssert.AreEqual(result.matrix, MatrixCalculator.MultiplyMatrixByScalar(_matrix1, scalar).matrix);
        }

        [Test]
        public void TestMultiplyMatrices()
        {
            Matrix result = new Matrix(rows: 3, columns: 3)
            {
                matrix = new[,]
                {
                    { 124, 106, 127 }, { 125, 118, 165 }, { 126, 109, 137 }
                }
            };

            CollectionAssert.AreEqual(result.matrix, MatrixCalculator.MultiplyMatrices(_matrix1, _matrix2).matrix);
        }

        [Test]
        public void TestTransposeMatrix()
        {
            Matrix result = new Matrix(rows: 3, columns: 3)
            {
                matrix = new[,]
                {
                    { 3, 8, 10 }, { 4, 7, 8 }, { 8, 8, 9 }
                }
            };

            CollectionAssert.AreEqual(result.matrix, MatrixCalculator.TransposeMatrix(_matrix2).matrix);
        }

        [Test]
        public void TestIsIdentityMatrix()
        {
            Matrix testedMatrix = new Matrix(rows: 3, columns: 3)
            {
                matrix = new[,]
                {
                    { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 }
                }
            };
            
            bool result = true;
            
            Assert.AreEqual(result, testedMatrix.IsIdentityMatrix());
        }

        [Test]
        public void TestCalculateDeterminant()
        {
            int matrix1DeterminantResult = -267;

            Assert.AreEqual(matrix1DeterminantResult, _matrix1.CalculateDeterminant());
        }
        
        [Test]
        public void TestMakeIdentity()
        {
            Matrix testedMatrix = new Matrix(rows: 3, columns: 3)
            {
                matrix = new[,]
                {
                    { 2, 6, 7 }, { 9, 6, 5 }, { 4, 3, 9 }
                }
                
            };
            bool resultBefore = false;
            
            Assert.AreEqual(resultBefore, testedMatrix.IsIdentityMatrix());
            
            testedMatrix.matrix = new[,]
            {
                { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 }
            };
            bool resultAfter = true;
            
            Assert.AreEqual(resultAfter, testedMatrix.IsIdentityMatrix());
        }
    }
}