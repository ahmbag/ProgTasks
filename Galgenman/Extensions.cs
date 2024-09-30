using System.Collections.Generic;
using System;

public static class Extensions
{
    private static Random rnd = new Random();

    public static T PickRandom<T>(this IList<T> source)
    {
        int randIndex = rnd.Next(source.Count);
        return source[randIndex];
    }
}