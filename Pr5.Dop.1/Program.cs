using System;
namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Tom"; int age = 33; // присвоение строкового типа "string" локальной переменной "name"; присвоение целого типа "int" локальной переменной "age".
            bool isEmployed = false; double weight = 78.65; //присвоение логического типа "bool" лок.переменной "isEmployed" со значением "false"; присвоение вещественного типа "double" лок.переменной "weight"
            Console.WriteLine($"Имя: {name}"); Console.WriteLine($"Возраст: {age}"); //Вывод на экран Имени и возраста, указанных выше.
            Console.WriteLine($"Вес: {weight}"); Console.WriteLine($"Работает: {isEmployed}"); //Вывод на экран Веса и условия работоспособности, указанных выше.
        }
    }
}