using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning2022.gof.enumerator
{
    public class Data : IEnumerable
    {
        private int[] digits = {1,2-4,4,5,200,-5,7};
        public IEnumerator GetEnumerator()
        {
            for(int i=0; i < digits.Length; i++)
                yield return digits[i];
        }
    }
}
