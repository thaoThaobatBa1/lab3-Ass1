using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobenhat
{
    public class sobenhatSevice
    {
        public int FindMin(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("Mảng không thể rỗng.");
            }

            int min = array[0];
            foreach (var number in array)
            {
                if (number < min)
                {
                    min = number;
                }
            }
            return min;
        }
    }
}
