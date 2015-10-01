using System;
using System.Collections.Generic;
using System.Linq;
 
class CountSymbols
{
    static void Main()
    {
        Console.WriteLine("Please, enter your text:");
        List<char> charList = new List<char>();
        charList.AddRange(Console.ReadLine().ToCharArray());
        SortedSet<char> distinctedChars = new SortedSet<char>();
        charList.ForEach(x => distinctedChars.Add(x));

        foreach (var item in distinctedChars)
        {
            Console.WriteLine("{0} : {1} time/s", item, charList.Count(x => x == item));
        }
    }
}