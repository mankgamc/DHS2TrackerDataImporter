using System;
using System.Collections.Generic;
using System.Text;

namespace enrollmentNamespace
{
   public  class events
    {
        public string responseType { get; set; }
        public string status { get; set; }
        public int imported { get; set; }
        public int updated { get; set; }
        public int ignored { get; set; }
        public int deleted { get; set; }

        
    }
}
