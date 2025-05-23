using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Apply_For_Delegete
{
    public delegate int CountFunc(string input);
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Example01
            {
                //CountFunc countFunc;
                //countFunc = new CountFunc(StringFunctions.CountUpper);
                //int Result = countFunc("HESHAM");
                //Console.WriteLine(Result);
                #endregion

                #region Example02
                //int[] Arr = { 5, 2, 3, 6, 8, 9, 2, 4 };
                //SortingAlgorithms<int>.BubbleSort(Arr, SortingTypes.COMPARELESS);
                //foreach (int i in Arr)
                //{
                //    Console.WriteLine(i);
                //}

                //string[] names = { "Hesham", "Ahmed", "Ali","Hassan", "Ali" };
                //SortingAlgorithms<string>.BubbleSort(names, SortingTypes.CompareStringsAsci);
                //foreach (string name in names)
                //{
                //    Console.WriteLine(name);
                //}
                #endregion

                #region Example03
                //List<int> numbers = Enumerable.Range(0, 100).ToList();
                //List<int> list = FilterList.FindOddNumbers(numbers, FliterationOfType.SortEven);


                ////List<int> Result= FilterList.FindOddNumbers(numbers);
                //foreach (int i in list)
                //{
                //    Console.Write($"{i} ");
                //}
                #endregion

                #region Built In Delegete
                //Action in this delegete there are two version 1 > Generic
                //   2 > Non Generic
                // Generic Take From 0 To 16 Parameter And Return Void 
                // Non Generic Return Void And No Parameter
                // Action action=TestBuiltinDelegete.Hello;
                // action();
                // action.Invoke();


                // // Func This Delegete Take From User From 0 To 16 input and return and data type
                // Func<int,string>  func=TestBuiltinDelegete.ConvertIntToString;
                //string Result =func(10);
                // Console.WriteLine(Result);


                // // Predict this Take one Parameter And return Bool
                // Predicate<int> predicate =TestBuiltinDelegete.CheckForPositiveNum;
                // bool result=predicate(-10);
                // Console.WriteLine(result);
                #endregion

                #region Anonymous Method
                //            //Action in this delegete there are two version 1 > Generic
                //            //   2 > Non Generic
                //            // Generic Take From 0 To 16 Parameter And Return Void
                //            // Non Generic Return Void And No Parameter
                //             Action action =delegate { Console.WriteLine("Hello World"); };
                //            action();
                //            action.Invoke();


                //            // Func This Delegete Take From User From 0 To 16 input and return and data type
                //            Func<int, string> func = TestBuiltinDelegete.ConvertIntToString;
                //            string Result = func(10);
                //            Console.WriteLine(Result);


                //            // Predict this Take one Parameter And return Bool
                //            Predicate<int> predicate =   delegate(int number) { return number > 0; }
                //;
                //        bool result = predicate(-10);
                //            Console.WriteLine(result);
                #endregion

                #region Lamda Expresion
                //Func<int, string> func = number =>  number.ToString();
                //string Result = func(10);
                //Console.WriteLine(Result);

                #endregion

                #region Dictionary
                Dictionary<string, int> dic = new Dictionary<string, int>()
                {
                    { "Hesham", 111},
                    { "Ahmed", 222},
                    { "Mohamed", 111},

                };

                //foreach (var item in dic)
                //{
                //    Console.WriteLine(item);
                //}
                foreach (KeyValuePair<string,int> item in dic)
                {
                    Console.WriteLine(item.Value);
                    Console.WriteLine(item.Key);
                }
                #endregion


            }
        }
    }
}
