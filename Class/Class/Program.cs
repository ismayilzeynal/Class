using Class.Models;
using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {

            Car BMW = new Car(2022, "black", "F90", "BMW", 0.14, 68, 25);
            BMW.ShowInfo();
            BMW.Drive(150);



            // electric cars crying :))
        }
    }
}
