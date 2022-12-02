using System;
using System.Collections.Generic;
namespace generic

{
    class Program
    {
        private const long V = 1000000000000;

        static void Main(string[] args)
        {

            // generic = " not specific to a particular data type "
            // add < T > to : classes, methods, fields, ect...
            // allows for code reusability for different data types

            // chung chung = "không dành riêng cho một loại dữ liệu cụ thể"
            // thêm <T> vào: lớp, phương thức, trường, v.v...
            // cho phép sử dụng lại mã cho các loại dữ liệu khác nhau


            int[] intArray = { 0, 1, 2, 3, 4, 5, 6, 7};
            double[] doubleArray = {1.0, 2.0, 3.0, 4.0, 5.0};
            String[] stringArray ={"1","2","3","4","5","6","7"};


            displayElements(intArray);
            displayElements(doubleArray);
            displayElements(stringArray);
            Console.ReadKey();
        }
        public static void displayElements<Thing>(Thing[] array)
        {
            foreach (Thing item in array)
            {
                System.Console.WriteLine(item + " ");
            }
            System.Console.WriteLine();
        }
   }
}
