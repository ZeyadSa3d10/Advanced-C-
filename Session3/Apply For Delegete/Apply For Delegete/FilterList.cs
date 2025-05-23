using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apply_For_Delegete
{
    public delegate bool SortNumbers<T>(T x);
    internal class FilterList
    {
        //public static List<T> FindOddNumbers<T>(List<T> list,SortNumbers<T> sortNumbers)
        //{
        //    List<T> result = new List<T>();
          
        //        if (list is not null && list.Count>0)
        //        {  
             
        //        for (int i=0;i<list.Count;i++)
        //        {
        //            //list[i] %2 == 1
        //            if (sortNumbers.Invoke(list[i]))
        //            {
        //                result.Add(list[i]);
        //            }
        //        }
        //        }

        //    return result;
        //}
    }
}
