using System;

namespace CSharp_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string aStringExample = "";
            int x = 10;
            double y = 10.1;
            char aSinggleCharacter = 'A';
            bool isFinish = false;

            Console.WriteLine($"string {aStringExample}; int {x} bool {isFinish} double {y}  char {aSinggleCharacter} ");

            string dogName = "Ralph";
            int dogAge = 10;

            Console.WriteLine($"My dog's name is {dogName}, He is {dogAge} years old");
        }
    }
}
