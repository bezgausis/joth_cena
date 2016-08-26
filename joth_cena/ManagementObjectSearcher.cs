using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace slotmachine
{
    class ManagementObjectSearcher
    {
        private string p;
        private string p_2;

        public ManagementObjectSearcher(string p, string p_2)
        {
            // TODO: Complete member initialization
            this.p = p;
            this.p_2 = p_2;
        }

        internal IEnumerable<ManagementObject> Get()
        {
            throw new NotImplementedException();
        }
    }
}
