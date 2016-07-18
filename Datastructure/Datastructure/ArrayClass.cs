using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure
{
    class ArrayClass
    {
        private static void Array()
        {
            int[] a1 = new int[5];
            for (int i = 0; i < a1.Length; i++)
            {
                a1[i] = i + 1;
            }
        }

        public static int Arrayint(int[] arrayint)
        {
            int sum = 0;

            foreach (var item in arrayint)
            {
                sum += item;
            }


            return sum;

        }

        

    }

    class Array<T>
    {
        public static T Arrayint(T[] arrayint)
        {
            dynamic sum = arrayint[0];

            foreach (var item in arrayint)
            {
                sum += item;
            }


            return sum;

        }

    }
}
