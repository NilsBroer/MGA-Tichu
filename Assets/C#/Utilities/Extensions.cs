using System;
using System.Collections.Generic;

namespace Utilities
{
    public static class Extensions
    {
        private static readonly Random rng = new Random();  

        public static void Randomize<T>(this IList<T> list)  
        {  
            var n = list.Count;  
            while (n > 1) {  
                n--;  
                var k = rng.Next(n + 1);  
                var value = list[k];  
                list[k] = list[n];  
                list[n] = value;  
            }  
        }
    }
}