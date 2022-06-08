  static void SumaFilaColumna (double[,]M )    ///codigo usado en un tp. que no lo termine usando pero esta bastante interesante 
        {
            double []Filas = new double [M.GetLength(0)];
            double[] Columnas = new double [M.GetLength(1)];
            
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    Filas[j]= M[i,j];
                }

                MostrarSumaFilas(Filas, i);
            }
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    Columnas[j]= M[j,i];
                }

                MostrarSumaColumna(Columnas, i);
            }


        }
        static void MostrarSumaFilas (double []F, int Pos)
        {
            double SumaFila = 0;
           
            for (int i = 0; i < F.Length; i++)
            {
                SumaFila += F[i];
            }

            System.Console.WriteLine($"La suma de la fila {Pos} es: {SumaFila}.");
        }
        static void MostrarSumaColumna (double []C, int Pos)
        {
            double SumaColumna = 0;

            for (int i = 0; i < C.Length; i++)
            {
                SumaColumna += C[i];
            }
            System.Console.WriteLine($"La suma de la columna {Pos} es: {SumaColumna}.");
        }