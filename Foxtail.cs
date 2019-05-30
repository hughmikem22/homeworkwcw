using System;

namespace Programs1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cars car1 = new Cars("Chevrolet", "Corvette", "Red", 1983, 345, 3.6 );
            Cars car2 = new Cars("BMW", "830i", "Midnight Blue", 1992, 236, 2.8);
            Cars car3 = new Cars("Mercedes Benz","Mclass","Maroon", 2018, 255, 3.2);
            Cars car4 = new Cars("Nissan", "altima" , "black", 2016, 243, 3.6);
            Cars car5 = new Cars("BMW", "328i" , "blue", 2009, 267, 3.9);
            Cars car6 = new Cars("Ford", "bronco 2" , "white", 1988, 212, 4.6);
            Cars car7 = new Cars("Chevrolet", "Malibu" , "blue", 1999, 180, 2.7);



            Console.WriteLine(car2);
            


        }
    }
}
