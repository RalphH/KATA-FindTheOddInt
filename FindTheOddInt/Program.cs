using System;

using System.Linq;

namespace FindTheOddInt
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    public static class Kata
    {
        public static int find_it(int[] seq)
        {            
            var oddnums = seq.GroupBy(num => num)
                        .Select(group =>
                        {
                            var num = new
                            {
                                Num = group.Key,
                                Count = group.Count()
                            };
                            return num;
                        })
                        .Where(num => num.Count % 2 != 0);                        
            return oddnums.First().Num;
        }

    }
}
