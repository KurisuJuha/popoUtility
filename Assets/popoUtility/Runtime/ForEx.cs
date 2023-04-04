using System;
using System.Collections.Generic;

namespace JuhaKurisu.PopoTools.Utility
{
    public static class ForEx
    {
        public static IEnumerable<T> For<T>(IEnumerable<T> value, Action<int> action)
        {
            int i = 0;
            foreach (var item in value)
            {
                action.Invoke(i);
                i++;
            }

            return value;
        }
    }
}