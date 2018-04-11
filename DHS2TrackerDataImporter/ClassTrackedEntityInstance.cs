using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHS2TrackerDataImporter
{
   public  class ClassTrackedEntityInstance
    {
        public string trackedEntity { get; set; }
        public string orgUnit { get; set; }
        public string trackedEntityInstance { get; set; }
        public Boolean inactive { get; set; }

        public ClassAttributes[] attribute;
        public ClassRelationships[] relationships;
        public ClassEnrollments[] enrollments;
    }
}
