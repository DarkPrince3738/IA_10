using System;

namespace Task1
{
    /*Task1​    
    Перевизначте метод ToString базового типу object, який буде повертати гарно відформатовану інформацію. 
    Створіть статичний клас Painter із методами void Paint(Car car, string colour), який міняє колір.
    Виведіть інформацію про машину до і після пофарбування. Зробіть висновки і напішіть програму коректно.​*/
    
    class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car();
            car1.Color = "white";
            car1.Brand = "BMW";
            car1.MaxSpeed = 250;
            Painter.Paint(ref car1, "black");
            Console.WriteLine($"{car1.Color}, {car1.Brand}, {car1.MaxSpeed}");
        }
    }
    struct Car
    {
        private string color;
        private string brand;
        private int maxSpeed;

        public string Color
        {
            set
            {
                if(value!="white" && value != "black" && value != "red")
                {
                    throw new Exception("Wrong color");
                }
                color = value;
            }
            get
            {
                return color;
            }
        }
        public string Brand
        {
            set
            {
                if (value != "BMW" && value != "Mercedez" && value != "Mazda")
                {
                    throw new Exception("Wrong brand");
                }
                brand = value;
            }
            get
            {
                return brand;
            }
        }
        public int MaxSpeed
        {
            set
            {
                if (value > 250)
                {
                    throw new Exception("Wrong max speed");
                }
                maxSpeed = value;
            }
            get
            {
                return maxSpeed;
            }
        }
    }
    static class Painter
    {
        public static void Paint(ref Car car1, string color)
        {
            car1.Color = color;
        }
    }
}