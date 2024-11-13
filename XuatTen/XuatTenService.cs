using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XuatTen
{
    public class UserProfile
    {
        public string Name { get; set; }
    }
    public class XuatTenService
    {
        public string GetName(UserProfile profile)
        {
            if (profile == null)
            {
                throw new NullReferenceException("Đối tượng hồ sơ không thể là null.");
            }
            return profile.Name;
        }
    }
}
