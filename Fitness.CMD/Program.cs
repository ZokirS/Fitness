using Fitness.BL.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: \n");
            var name = Console.ReadLine();

            Console.WriteLine("Enter gender: \n");
            var gender = Console.ReadLine();

            Console.WriteLine("Enter birth date: \n");
            var birthdate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter weight: \n");
            var weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter height");
            var height = double.Parse(Console.ReadLine());

            var userController = new UserController(name, gender, birthdate, weight, height);
            userController.Save();
        }
    }
}
