using System.Net.Security;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace test
{
    internal static class Program
    {
        internal static int Count(this string str)
        {
            var count = str.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Length;
            return count;
        }
        static void Main(string[] args)
        {
            string str = "abd ddodi";
            Console.WriteLine(str.Count());
            
        }

    }
}

