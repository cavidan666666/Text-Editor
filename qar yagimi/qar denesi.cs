using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qar_yagimi
{
    class qar_denesi
    {
        public int x, y, w, h;
        public void Yagdir()
        {
            if (y <= h)
            {
                y++;
            }
        }
    }
}
