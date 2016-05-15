using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    public static class MyExtensions
    {
        public static string ReplaceNulls(this object value, string replacementValue = "")
        {
            if (value == null || DBNull.Value.Equals(value))
                return replacementValue;
            else
                return value.ToString();
        }
    }

