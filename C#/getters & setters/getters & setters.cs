using System;
using System.Collections.Generic;
namespace gettersvssetters
{
    class Program
    {
        private const long V = 1000000000000;

        static void Main(string[] args)
        {

            // getters & setters = add security to fields by encapsulation 
            // They re accesors within properties

            // Properties = combine aspects of both fields and methods ( share name with a field)
            // get accessor = used to return the property value 
            // set accessor = used to assign a new value 
            // value keyword = defines the value being assigned by the set ( parameter )

            // getters & setters = thêm bảo mật cho các trường bằng cách đóng gói
            // Chúng là accesor bên trong các thuộc tính

            // Thuộc tính = kết hợp các khía cạnh của cả hai trường và phương thức ( chia sẻ tên với một trường)
            // get accessor = dùng để trả về giá trị thuộc tính
            // set accessor = dùng để gán giá trị mới

            // từ khóa giá trị = xác định giá trị được gán bởi bộ (tham số)



            Car car = new Car(400);

            car.Speed = 1000000000;

            System.Console.WriteLine(car.Speed);
            Console.ReadKey();
        }
    }
    class Car
    {
        private int speed;
        public Car(int speed)
        {
            Speed = speed;
        }

        public int Speed
        {
            get { return speed; } // read
            set // write
            {   
                if(value > 500)
                {
                    speed = 500;
                }
                else 
                {
                    speed = value;
                }
               
            }
        }
    }
}
