using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apply_For_Generic
{
    internal static class Helper<T> where T : IEquatable<T>
    {
        #region Swap
        #region Generic Swap
        public static void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }

        //public static int SearchArray(T[] numbers, int value)
        //{
        //    if (numbers is not null)
        //    {
        //        foreach (T i in numbers)
        //        {
        //            if (i == value)
        //            {
        //                return i;
        //            }
        //        }
        //    }
        //    return -1;

        //}
        #endregion

        #region Non Generic Swap
        //public static void Swap(ref object x, ref object y)
        //{
        //    object temp = x;
        //    x = y;
        //    y = temp;
        //}
        //public static void Swap(ref double x,ref double y)
        //{
        //    double temp = x;
        //    x = y;
        //    y=temp;
        //}
        //public static void Swap(ref Point x,ref Point y)
        //{
        //    Point temp = x;
        //    x = y;
        //    y=temp;
        //} 
        #endregion

        #endregion

        public static int LinearSearch(T[] Arr, T value)
        {
            if (Arr?.Length > 0 && value is not null)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    if (value.Equals(Arr[i]))
                    {
                        return i;
                    }
                }


            }
            return -1;
        }
        
        public static int LinearSearch(T[] Arr, T value,IEqualityComparer<T> TE)
        {
            if (Arr?.Length > 0 && value is not null)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    if (TE.Equals(value, Arr[i]))
                    {
                        return i;
                    } 
                }


            }
            return -1;
        }

        public static void BubbleSort(int[] Arr)
        {
            for(int i = 0;i < Arr.Length; i++)
            {
                for(int j=0; j < Arr.Length - 1 - i; j++)
                {
                    if (Arr[j] > Arr[j + 1])
                    {
                        Helper<int>.Swap(ref Arr[j], ref Arr[j + 1]);
                    }
                }
            }
        }
    }
}

