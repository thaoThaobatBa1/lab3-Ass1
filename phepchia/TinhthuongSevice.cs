using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phepchia
{
    public class TinhthuongSevice
    {
        public float TinhThuong(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Không thể chia cho 0.");
            }
            return (float)a / b;
        }
    }
}
