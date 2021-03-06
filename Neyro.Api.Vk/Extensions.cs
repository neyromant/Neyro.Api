﻿using System;

namespace Neyro.Vk
{
    public static class Extensions
    {
        public static int ToUnixTimestamp(this DateTime value)
        {
            return (int)Math.Truncate((value.ToUniversalTime().Subtract(new DateTime(1970, 1, 1))).TotalSeconds);
        }

        public static string AsString(this UserNameCases nc)
        {
            return nc.ToString().ToLower();
        }
    }
}
