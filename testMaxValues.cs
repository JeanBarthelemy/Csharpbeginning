using System;
 class Test
    {
        static void Main()
        {
            int x = int.MaxValue;
            long y = long.MaxValue;
            short z = short.MaxValue;
            ulong additionResult = (ulong)x + (ulong)y + (ulong)z;
            
            System.Console.WriteLine(additionResult);
        }
    }
