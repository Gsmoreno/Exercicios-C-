﻿using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i= 1; i <= 10; i++){
                for(int j = 11; j <= 10; j++){
                    Console.Write($"{i, -2} x {j,-2} = {i * j, -3} ");
                }
                Console.WriteLine();
            }
        }
    }
}
