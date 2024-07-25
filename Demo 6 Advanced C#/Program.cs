using Demo_6_Advanced_C_.genarics;
using System;
    
namespace Demo_6_Advanced_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // #region
             //int A = 10; int B = 30;
             //Console.WriteLine($" A: {A}");
             //Console.WriteLine($" B: {B} ");
              //Helper.Swap<int>(ref A, ref B );
            // Console.WriteLine("After swaping");
             //Console.WriteLine($" A: {A}");
             //Console.WriteLine($" A: {A}");

            // Point P01 = new Point(1, 2);
            // Point P02 = new Point(2, 3);
             //Helper.Swap<Point>(ref P01, ref P02);

             //#endregion 
             int[] Numbers = { 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

             int index=  Helper<int>.SearchArray(Numbers, 6);
             Console.WriteLine(index);

            Employee E01 = new Employee() { id = 10, name = "mohamed", salary = 10000 };
            Employee E02 = new Employee() { id = 20, name = "ahamed", salary = 9000 };            


            if (E01.Equals(E02))
            {
                Console.WriteLine("equal");
            }
            else
            {
                Console.WriteLine("not equal");
            }
            Console.WriteLine($"HashCode Of Employee 01 = {E01.GetHashCode()}");
            Console.WriteLine($"HashCode Of Employee 02 = {E02.GetHashCode()}");



             

             
        }
    }
}
