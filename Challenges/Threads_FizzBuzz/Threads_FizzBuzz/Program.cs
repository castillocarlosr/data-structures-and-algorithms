using System;
using System.Threading;

class FizzBuzz
{
    private int n;
    private int current;

    public FizzBuzz(int n)
    {
        this.n = n;
        this.current = 1;
    }

    public void Run()
    {
        Thread fizzThread = new Thread(new ThreadStart(Fizz));
        Thread buzzThread = new Thread(new ThreadStart(Buzz));
        Thread fizzBuzzThread = new Thread(new ThreadStart(FizzBuzzCheck));
        Thread numberThread = new Thread(new ThreadStart(Number));

        fizzThread.Start();
        buzzThread.Start();
        fizzBuzzThread.Start();
        numberThread.Start();

        fizzThread.Join();
        buzzThread.Join();
        fizzBuzzThread.Join();
        numberThread.Join();
    }

    public void Fizz()
    {
        while (current <= n)
        {
            if (current % 3 == 0 && current % 5 != 0)
            {
                Console.WriteLine("Fizz");
                current++;
            }
            Thread.Yield();
        }
    }

    public void Buzz()
    {
        while (current <= n)
        {
            if (current % 5 == 0 && current % 3 != 0)
            {
                Console.WriteLine("Buzz");
                current++;
            }
            Thread.Yield();
        }
    }

    public void FizzBuzzCheck()
    {
        while (current <= n)
        {
            if (current % 3 == 0 && current % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
                current++;
            }
            Thread.Yield();
        }
    }

    public void Number()
    {
        while (current <= n)
        {
            if (current % 3 != 0 && current % 5 != 0)
            {
                Console.WriteLine(current);
                current++;
            }
            Thread.Yield();
        }
    }
}

public class Program
{
    public static void Main()
    {
        FizzBuzz fb = new FizzBuzz(100);
        fb.Run();

        Console.ReadLine(); // wait for user input to exit
    }
}
