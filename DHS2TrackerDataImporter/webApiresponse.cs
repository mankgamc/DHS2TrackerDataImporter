﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHS2TrackerDataImporter
{
   public  class webApiresponse
    {
        public string httpStatus { get; set; }
        public string httpStatusCode { get; set; }
        public string status { get; set; }
        public string message { get; set; }
        public response response;
    }
}
