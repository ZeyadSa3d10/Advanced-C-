using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apply_For_Delegete
{
    // Non  Generic Delegete
    //public delegate bool DelegeteFunc(int A, int B);

    // Generic Delegete
    public delegate Tout DelegeteFunc<in T1,in T2,out Tout>(  T1 A,  T2 B);
    internal class SortingAlgorithms<T>
    {
        //public static void BubbleSort(T[] Arr, DelegeteFunc<T, T, bool> delegeteFunc)
        //{
        //    if (Arr is not null && delegeteFunc is not null)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            for (int j = 0; j < Arr.Length - j - 1; j++)
        //            {
        //                if (delegeteFunc.Invoke(Arr[j], Arr[j + 1]))
        //                {
        //                    Swap(ref Arr[j], ref Arr[j + 1]);
        //                }
        //            }
        //        }
        //    }
        //}

        //private static void Swap(ref T v1, ref T v2)
        //{
        //    T temp = v1;
        //    v1 = v2;
        //    v2 = temp;
        //}
    }
}
