using System.Collections.Generic;

namespace Mcba.Infraestruture
{
    public class StringComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            if (string.Compare(x, y) > 0)
            {
                return 1;
            }

            if (string.Compare(x, y) < 0)
            {
                return -1;
            }

            return 0;
        }
    }
}