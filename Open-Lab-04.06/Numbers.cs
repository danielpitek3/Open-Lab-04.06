using System;
using System.Collections.Generic;

namespace Open_Lab_04._06
{
    public class Numbers
    {
        public int[] NoOdds(int[] numbers)
        {
            int i = 0;
            var list = new List<int>();
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    list.Insert(i, number);
                    i++;
                }
            }

            return list.ToArray();
        }
    }
}
