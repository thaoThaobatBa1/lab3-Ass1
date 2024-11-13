using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetElTest
{
    public class GetElementAtIndex
    {
        public T GetElement<T>(T[] array, int index)
        {
            if (index < 0 || index >= array.Length)
            {
                throw new IndexOutOfRangeException("Chỉ mục nằm ngoài phạm vi của mảng.");
            }
            return array[index];
        }
    }
}
