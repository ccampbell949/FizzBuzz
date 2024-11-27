using System.ComponentModel;

int n = 50;

var list = new List<string>();


for (int i = 1; i <= n; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        list.Add("FizzBuzz");
    }

    else if (i % 3 == 0)
    {
        list.Add("Fizz");
        //Console.WriteLine("Fizz");
    }

    else if (i % 5 == 0)
    {
        list.Add("Buzz");
        //Console.WriteLine("Buzz");
    }

    else
    {
        list.Add(i.ToString());
        //Console.WriteLine(i.ToString());
    }
}

list.ForEach(i => Console.Write(i + " "));



