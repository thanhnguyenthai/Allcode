using System;

namespace overloadedconstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            // overloaded constructors = technique to create multiple constructors, with a diff set of parameters
            // name + parameters = signature
            // quá tải hàm tạo = kỹ thuật tạo nhiều hàm tạo, với một bộ tham số khác 
            // tên + tham số = chữ ký


            Pizza pizza = new Pizza("stuffed creust", "red sauce", "mozzarella");

            Console.ReadKey();
        }
      
    }

    class Pizza
    {
        String bread;
        String sauce;
        String cheese;
        String topping;

        public Pizza(String bread)
        {
            this.bread = bread;
            
        }

        public Pizza(String bread, String sauce)
        {
            this.bread = bread;
            this.sauce = sauce;
            
        }

        public Pizza(String bread, String sauce, String cheese)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
            
        }
        public Pizza(String bread, String sauce, String cheese, String topping)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
            this.topping = topping;
        }
    }

}

