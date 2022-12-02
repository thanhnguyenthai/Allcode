using System;
using System.Collections.Generic;
namespace autoimplementedproperties
{
    class Program
    {
        private const long V = 1000000000000;

        static void Main(string[] args)
        {

            // auto implemented properties = shortcut when no additional logic is required in the property
            // you do not have to define a field for a property,
            // you only have to write get; and/or set ; inside the property

            // thuộc tính tự động triển khai = phím tắt khi không yêu cầu logic bổ sung trong thuộc tính
            // bạn không phải xác định trường cho thuộc tính,
            // bạn chỉ cần viết get; và/hoặc đặt ; bên trong tài sản



            Car car = new Car("Ok");
            System.Console.WriteLine(car.Model);
            Console.ReadKey();
        }
    }
    class Car
    {
       /* String model;

        public String Model
        {
            get{ return model; }
            set{model = value;}
        }
        */// Chuyển cái đống này như sau:


        public String Model {get ; set ;}
        public Car(String model)
        {
            this.Model = model;
        }
    }
}
