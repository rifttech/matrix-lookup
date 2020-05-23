using System;



namespace MatrixLookup
{

    class MatrixSolver
    {
        private readonly int[,] matrix;
        private readonly Action<string> log;
        public MatrixSolver(int[,] matrix, Action<string> log) {
            this.matrix = matrix;
            this.log = log;
        }
        
        public void solve()
        {
            var width = this.matrix.GetLength(0);
            var height = this.matrix.GetLength(1);

            var maxRank = (width > height) ? height : width;
            
            while (maxRank > 1)
            {
                var hasSolution = false;
                log("Поиск матриц ранга: " + maxRank);
                for (int i = 0; i < this.matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < this.matrix.GetLength(1); j++)
                    {
                        if (testBound(matrix, i, j, maxRank))
                            if (testPredicate(matrix, i, j, maxRank)) {
                                hasSolution = true;
                                log("Найдена матрица:");
                                string temp = "";
                                for (int k = i; k <= i+ maxRank-1; k++)
                                {
                                    for (int n = j; n <= j + maxRank - 1; n++)
                                    {
                                        temp += matrix[k, n] + "\t";
                                    }
                                    temp += "\r\n";
                                }
                                log(temp);
                            }
                        
                    }

                }
                if (!hasSolution)
                {
                    log("Подходяших подматриц не обнаружено");
                }
                maxRank--;
            }
            
        }
        /// <summary>
        /// Проверяет границы матрицы    
        /// <returns></returns>
        private bool testBound(int[,] a, int i, int j, int rank) {
            var testRigthBound =  (j + rank - 1) <= a.GetLength(1) - 1;
            var testBottomBound = (i + rank - 1) <= a.GetLength(0) - 1;
            return testRigthBound && testBottomBound;
        }
        /// <summary>
        /// Проверяет выполняется исходное условие
        /// <returns></returns>
        private bool testPredicate(int[,] a, int i, int j, int rank) {
            var lt = a[i, j];
            var rt = a[i, j + rank - 1];
            var lb = a[i + rank - 1, j];
            var rb = a[i + rank - 1, j + rank - 1];

            return Array.TrueForAll<int>(new int[] { lt, rt, lb, rb }, val => (lt == val));
        }

        
    }
}
