using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

/* Question: Given a list of numbers, find the sum of the sum of all values excluding the 
 * highest and the sum of all values excluding the lowest. */
public static class Program {
    public static (int High, int Low) HighLowSum(int[] numbers) {
        var sorted = numbers.OrderBy(x => x);
        var highSum = sorted.Skip(1).Sum();
        var lowSum = sorted.Reverse().Skip(1).Sum();
        
        return (highSum, lowSum);
    }
}
