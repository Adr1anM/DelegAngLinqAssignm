using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDelegLinq
{
    public delegate int Transformer(int value);
    public static class Util
    {
        public static void Transform(List<int> list , Transformer t) 
        {
            for(int i = 1; i< list.Count; i++)
            {
                list[i] = t(list[i]);
            }
        }


        public static void DevideByTwo( this List<int> list, Func<int, int> func)
        {
            for(int i = 1; i< list.Count; i++)
            {
                list[i] = func(list[i]);    
            }
        }
    }
}
