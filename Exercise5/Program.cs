using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box1 = new Box();
            Console.WriteLine("Enter length for box1:");
            box1.length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter breadth for box1:");
            box1.breadth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter height for box1:");
            box1.height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Box box2 = new Box();
            Console.WriteLine("Enter length for box2:");
            box2.length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter breadth for box2:");
            box2.breadth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter height for box2:");
            box2.height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Box box3 = new Box();
            Console.WriteLine("Enter length for box3:");
            box3.length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter breadth for box3:");
            box3.breadth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter height for box3:");
            box3.height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("");


            Console.WriteLine($"Volume of box1 : {box1.getVolume()}");
            Console.WriteLine($"Volume of box2 : {box2.getVolume()}");
            Console.WriteLine($"Volume of box3 : {box3.getVolume()}");
        }
    }
}
