using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using enrollmentNamespace;

namespace DHS2TrackerDataImporter
{
public  class importSummaries
    {
public string  responseType { get; set; }
        public string status { get; set; }
        public string reference { get; set; }
        public string href { get; set; }

        public importOptions importOptions;
        public importCount importCount;
        public enrollmentNamespace.enrollments enrollments { get; set; }
    }
}
