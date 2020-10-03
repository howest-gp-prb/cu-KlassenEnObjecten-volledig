using System;
using Prb.ClassesAndObjects.CORE;

namespace Prb.ClassesAndObjects.CONS
{
    class Program
    {
        static void Main(string[] args)
        {
            Car newCar;
            newCar = new Car();

            newCar.color = "zwart";
            newCar.brand = "Hyundai";
            newCar.price = 15000M;

            Car secondCar;
            secondCar = new Car();
            secondCar.color = "wit";
            secondCar.brand = "Ford";
            secondCar.price = 9000M;

            Car thirdCar = new Car("Audi", "blauw", 25000M);

            //decimal costDifference = newCar.PriceDifference(thirdCar);
            decimal costDifference = Car.PriceDifference(newCar,thirdCar);

            Console.WriteLine($"De nieuwe auto is een {newCar.brand}, is {newCar.color} van kleur en kost {newCar.price}");
            Console.WriteLine("============");
            Console.WriteLine($"De tweede auto is een {secondCar.brand}, is {secondCar.color} van kleur en kost {secondCar.price}");
            Console.WriteLine("============");
            Console.WriteLine($"De derde auto is een {thirdCar.brand}, is {thirdCar.color} van kleur en kost {thirdCar.price}");
            Console.WriteLine("============");
            Console.WriteLine($"We hebben nu {Car.carCount} auto's");

            Console.WriteLine("============");
            Console.WriteLine($"Prijsverschil tussen {newCar.price} en {thirdCar.price} is {costDifference}");

            Console.ReadLine();
        }
    }
}
