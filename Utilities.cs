using System;
using System.Collections.Generic;

namespace SPZLab6Var1
{
    public static class Utilities
    {
        public static T GetRandomElement<T>(this List<T> source) => source[new Random().Next(0, source.Count)];
    }
}

