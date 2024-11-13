using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class tich
    {
        public int TinhTich(float a, float b)
        {
            if (!IsInteger(a) || !IsInteger(b))
            {
                throw new ArgumentException("Cả hai số phải là số nguyên.");
            }

            return (int)a * (int)b;
        }

        private bool IsInteger(float number)
        {
            return number == Math.Floor(number);
        }
    }
}
