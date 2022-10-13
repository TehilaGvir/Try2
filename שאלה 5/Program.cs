using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace שאלה_5
{
    public delegate bool Delhw<T>(T item);
    class Program
    {

        static void Main(string[] args)
        {

        }
    }
    public static class staticClasshw
    {
        public static IEnumerable<T1> FilterGen<T1>(this IEnumerable<T1> list, Delhw<T1> functionToTnai)
        {
            foreach (var item in list)
            {
                if (functionToTnai(item))
                    yield return item;
            }
        }
    }
}
