using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Datastructure
{
    class ArrayListClass
    {
        public static void Arraylistex()
        {
            
            ArrayList myAL = new ArrayList();
            myAL.Add("Hello");
            myAL.Add(1);
            myAL.Add(1.1);
            myAL.Add(1.4);
            myAL.Add(1.2);

            foreach (var item in myAL)
            {
                if(Convert.ToString(item) == Convert.ToString(1.2))
                {
                    Console.WriteLine("Yes");
                }
            }
        }

    }
}
