using System;
using System.Linq;
using System.Collections.Generic;

namespace Transform{
    public delegate int Ddouble(int x);
    public static class Transform {
        public static int[] Map(this int[] a,Ddouble synt){
            for (int i = 0; i < a.Length; i++){
                a[i]=synt(a[i]);
            }
            return a;
        }
    }
}