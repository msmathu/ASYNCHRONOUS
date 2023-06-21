﻿
class Program
{


    static async Task Main(string[] args)
    {
        var result1 = await LongProcess1();


         

        var result2 = LongProcess2();
        var result3 = await LongProcess3();    

        Console.WriteLine("After two long processes.");

         

        Console.ReadKey();
    }

    static async Task<int> LongProcess1()
    {
        Console.WriteLine("LongProcess 1 Started");

        await Task.Delay(4000);

        Console.WriteLine("LongProcess 1 Completed");

        return 67;
    }

    static async Task<int> LongProcess2()
    {
        Console.WriteLine("LongProcess 2 Started");

        await Task.Delay(4000); // hold  4 seconds

        Console.WriteLine("LongProcess 2 Completed");

        return 20;
    }

    static async Task<int> LongProcess3()
    {
        Console.WriteLine("LongProcess 3 Started");

        await Task.Delay(4000); // hold  4 seconds

        Console.WriteLine("LongProcess 3 Completed");

        return 20;
    }

    static async Task<int> LongProcess6()
    {
        Console.WriteLine("LongProcess 6 Started");

        await Task.Delay(4000); // hold  4 seconds

        Console.WriteLine("LongProcess 6 Completed");

        return 20;
    }



}
