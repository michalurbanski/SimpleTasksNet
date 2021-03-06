﻿using System;

namespace SimpleTasksNet.Common.Helpers
{
    public static class ObjectHelpers
    {
        public static void ThrowIfNull(this object that, string name)
        {           
            if (that == null)
            {
                throw new ArgumentNullException(name);
            }
        }

        public static void ThrowIfNullOrEmpty(this string that, string name)
        {
            if(string.IsNullOrWhiteSpace(that))
            {
                throw new ArgumentException(name);
            }
        }
    }
}
