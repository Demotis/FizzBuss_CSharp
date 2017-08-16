using System;
using System.Linq;
using System.Collections.Generic;
					
public class Program
{
    public static void Main()
    {
        var words = new List<Tuple<int, string>>
        {
            new Tuple<int, string> (3, "Fizz"),
            new Tuple<int, string> (5, "Buzz"),
        };

        for (var i = 1; i <= 100; i++)
            Console.WriteLine(string.Format(
                    "{0} {1}",
                    i.ToString("D3"),
                    String.Join("", words.Where(o => i % o.Item1 == 0).Select(o => o.Item2))
                ));
    }
}
