﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.ManuelStandardLib.Scripts.LinqExtensions
{
    public static class LinqExtensions
    {
        public static T Random<T>(this IEnumerable<T> enumerable)
        {
            if (enumerable == null)
            {
                throw new ArgumentNullException();
            }

            // note: creating a Random instance each call may not be correct for you,
            // consider a thread-safe static instance
            var r = new Random();
            var list = enumerable as IList<T> ?? enumerable.ToList();
            return list.Count == 0 ? default(T) : list[r.Next(0, list.Count)];
        }
    }
}
