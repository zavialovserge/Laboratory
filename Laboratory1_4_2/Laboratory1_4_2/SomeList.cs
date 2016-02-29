using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory1_4_2
{
    public static class SomeList
    {
        public static Func<TArg2, Func<TArgl, TResult>> Bnd<TArgl, TArg2, TResult>(this Func<TArgl, TArg2, TResult> f)
        {
            return (y) => ((x) => f(x, y));
        }
    }
}
