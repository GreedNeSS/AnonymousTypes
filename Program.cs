using System;

namespace AnonymousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCar = new { Color = "Pink", Make = "Saab", CurrentSpeed = 55 };

            ReflectOverAnonyousType(myCar);

            Console.WriteLine($"My car is a {myCar.Color} {myCar.Make}\n");

            BuildAnonType("BMW", "Black", 90);

            EqualityTest();
        }

        public static void ReflectOverAnonyousType(object obj)
        {
            Console.WriteLine($"Obj is an instance of: {obj.GetType().Name}");
            Console.WriteLine($"Base class of {obj.GetType().Name} is {obj.GetType().BaseType}");
            Console.WriteLine($"obj.ToString() == {obj}");
            Console.WriteLine($"obj.GetHashCode() == {obj.GetHashCode()}");
            Console.WriteLine();
        }

        public static void BuildAnonType(string make, string color, int currSpeed)
        {
            var car = new { Make = make, Color = color, CurrentSpeed = currSpeed };

            Console.WriteLine($"You have a {car.Color} {car.Make} going {car.CurrentSpeed} MPH");

            Console.WriteLine($"car.ToString(): {car}\n");
        }

        public static void EqualityTest()
        {
            var firstCar = new { Color = "Pink", Make = "Saab", CurrentSpeed = 55 };
            var secondCar = new { Color = "Pink", Make = "Saab", CurrentSpeed = 55 };

            Console.WriteLine($"firstCar.Equals(secondCar): {firstCar.Equals(secondCar)}");
            Console.WriteLine($"firstCar == secondCar: {firstCar == secondCar}");
            Console.WriteLine("firstCar.GetType().Name == secondCar.GetType().Name: " +
                (firstCar.GetType().Name == secondCar.GetType().Name));
        }
    }
}
