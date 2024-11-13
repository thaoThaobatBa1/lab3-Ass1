using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhTrungBinhCongTest
{
    public class TrungbinhcongSevice
    {
        public double TinhTrungBinhCong(List<double> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                throw new ArithmeticException("Danh sách không thể trống.");
            }

            return numbers.Average();
        }
    }
}
