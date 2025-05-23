namespace Apply_For_Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Non Generic Swap
            //int x = 10;
            //int y = 20;
            //Helper.Swap(ref x,ref y);
            //Console.WriteLine(x);
            //Console.WriteLine(y);


            //object x = 10;
            //object y = 20;    // Boking
            //Helper.Swap(ref x,ref y);
            //Console.WriteLine(x);
            //Console.WriteLine(y);

            //object P1 = new Point(1,2);
            //object P2 = new Point(4,3);
            //Helper.Swap(ref P2 ,ref P1);
            //Console.WriteLine(P1);
            //Console.WriteLine(P2); 
            #endregion

            #region Generic Swap
            //int x = 10;
            //int y = 20;
            //Helper.Swap<int>(ref x, ref y);
            //Console.WriteLine(x);
            //Console.WriteLine(y);


            //double x = 10;
            //double y = 20;    
            //Helper.Swap<double>(ref x, ref y);
            //Console.WriteLine(x);
            //Console.WriteLine(y);

            //Point P1 = new Point(1, 2);
            //Point P2 = new Point(4, 3);
            //Helper.Swap<Point>(ref P2, ref P1);
            //Console.WriteLine(P1);
            //Console.WriteLine(P2);
            #endregion

            //int[] numbers = { 1,2,3,4,5};
            //int Position = Helper<char>.SearchArray(numbers,2);
            //Console.WriteLine(Position);

            //Employee Emp01 = new Employee(10,"Hesham",2000);
            //Employee Emp02 = new Employee(10,"Hesham",2000);
            //Employee Emp02 = new Employee(20,"Ahmed",5000);
            //if (Emp01==Emp02)
            //{
            //    Console.WriteLine("Equal");
            //}
            //else
            //{
            //    Console.WriteLine("Not Equal");
            //}


            //Employee Emp01 = new Employee(2000, "Hesham", 10);
            //Employee Emp02 = new Employee(10, "Hesham", 2000);
            //Employee[] Employees =
            //{

            //new Employee (10,"Hesham",5000),
            //new Employee (30,"Hesham",4000),
            //new Employee (40,"Hesham",3000),
            //new Employee (50,"Hesham",5500),

            //};

            //Console.WriteLine(Emp01.Equals(Emp02));
            //int result = Helper<Employee>.LinearSearch(Employees, Emp01, new EmployeeIdIEqutableComparer());
            
            //Console.WriteLine(result);


            int[] Numbers = { 10, 20, 50, 40, 50 };
            Helper<int>.BubbleSort(Numbers);
            foreach (int number in Numbers) { Console.WriteLine(number); }

        }
    }
}
