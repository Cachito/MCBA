using System.Text;

namespace Mcba.Seguridad
{
    public static class DvValue
    {
        public static long GetDvValue(string dvString)
        {
            var asciiBytes = Encoding.ASCII.GetBytes(dvString);
            var sum = 0;
            var pos = 1;
            foreach (var b in asciiBytes)
            {
                sum += (b * pos);
                pos++;
            }

            return sum;
        }
    }
}
