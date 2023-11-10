using System;

namespace BusquedaBinaria_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 20, 30, 42, 52, 72, 100 };
            int X = 30;
            int pos = BusquedaBinaria(A, 0, A.Length, X);
            Console.WriteLine("El valor {0} está en : {1}", X, pos);

            Console.ReadLine();


        }


        static int BusquedaBinaria(int[] A, int IZQ, int DER, int X)
        {

            if ( DER <= IZQ)
            {
                return -1;
            }
            else
            {
                int CEN = (IZQ + DER) / 2;

                if ( A[CEN] ==  X )
                {
                    return CEN;
                }
                else if( X < A[CEN] )
                {
                    return BusquedaBinaria(A, IZQ, CEN,X);
                }
                else
                {
                    return BusquedaBinaria(A, CEN , DER, X);
                }
            }

        }
    }
}
