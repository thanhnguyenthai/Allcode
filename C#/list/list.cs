using System;
using System.Collections.Generic;
namespace liste
{
    class Program
    {
        static void Main(string[] args)
        {
            // List = data structure that represents a list of object that can be accessed by index
            // Similar to array , but can dynamically increase/ decrease in size
            // using System.Collections.Generic;

            // Danh sách = cấu trúc dữ liệu đại diện cho danh sách đối tượng có thể được truy cập bằng chỉ mục
            // Tương tự như mảng nhưng có thể tự động tăng/giảm kích thước
            // sử dụng System.Collections.Generic;

          /*
            String[] food = new String[3];

            food[0] = "pizza";
            food[1] = "cheese";
            food[2] = "orange";
            */ // Không thêm được thì mình phải dùng dạng như sau:

            List<String> food = new List<String>();
            food.Add("lmao");
            food.Add("pizza");
            food.Add("hmg");
            food.Add("hotdog ");
            food.Add("mlaoasdkfasdf ");
            food.Add("lmao");
            //food.Remove("pizza");
            food.Insert(0,"Sushi");

            System.Console.WriteLine(food.Count);
            System.Console.WriteLine(food.IndexOf("pizza"));

            System.Console.WriteLine(food.LastIndexOf("lmao"));


        System.Console.WriteLine(food.Contains("pizza"));

        food.Sort();

        food.Reverse();
       // food.Clear();

       String[] foodArray = food.ToArray();



            foreach (String item in foodArray)
            {
                System.Console.WriteLine(item);
            }


            System.Console.WriteLine(food[0]);


            Console.ReadKey();  
        }
    }
    
}
