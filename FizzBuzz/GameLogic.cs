namespace FizzBuzz;

internal class GameLogic
{
    static internal void FizzBuzz(string inputString)
    {
        var list = new List<string>();
        var input = Convert.ToInt32(inputString);

        for (int i = 1; i <= input; i++)
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
    }
}