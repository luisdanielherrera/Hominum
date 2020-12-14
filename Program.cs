using Hominum.App;
using System;

namespace Hominum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hominum!");
            Engine Word = new Engine();
            Word.Initialized();
        }
    }
}
