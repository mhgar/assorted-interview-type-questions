using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

/* Question: Given a set of numbers, find the number of occurences of the single highest number in the set. */
public static class Program {
    public static int HighestNumberCount(int[] numbers) {
        var highest = numbers.Aggregate((high, next) => next > high ? next : high);
        return numbers.Count(x => x == highest);
    }
}
