using System;
using System.Collections.Generic;
using System.Text;

namespace DAY6
{
    class Class3
    {
        public static void Main()
        {
            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
            keyValuePairs.Add(1, "Preetha");
            keyValuePairs.Add(2, "pranesh");
            keyValuePairs.Add(3, "sethra ");
            if(keyValuePairs.ContainsKey(12)==true)
            {
                Console.WriteLine("key found");
            }
            else
            {
                Console.WriteLine("key not found");
            }
            if (keyValuePairs.ContainsValue("pavithra"))
            {
                Console.WriteLine("value found");
            }
            else
            {
                Console.WriteLine("value not found");
            }
        }
    }
}
