using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportSchool111.Model
{
    public partial class trainigs
    {
        public TimeSpan preTime
        {
            get
            {
                return this.time - new TimeSpan(0,30,0);
            }
        }
    }
}
