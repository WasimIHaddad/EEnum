using System;

namespace EEnum
{
     class Program
    {
        static void Main(string[] args)
        {
            foreach(var month in Enum.GetNames(typeof(Month)))
            {
                Console.WriteLine($"{month} = {(int)Enum.Parse(typeof(Month),month)}" );
            }
            
        }
    }
}
