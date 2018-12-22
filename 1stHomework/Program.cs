using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1. Создать простое консольное приложение и ознакомиться с его структурой
// 2. Написать приложение, которое выведет на экран Ваше имя и фамилию.
// 3. Написать приложение, которое ожидает ввода нескольких чисел и выводит на экран их сумму.

namespace FirstHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!!");

            Console.WriteLine("My name is Adilet. Adilet Akhmetkali");

            int firstNumb, secondNumb;

            Console.Write("\nEnter 2 numbers\n1st numb = ");
            firstNumb = int.Parse(Console.ReadLine());

            Console.Write("2nd numb = ");
            secondNumb = int.Parse(Console.ReadLine());

            Console.Write("Sum of numbers - " + (firstNumb + secondNumb));
            Console.ReadKey();
        }
    }
}
