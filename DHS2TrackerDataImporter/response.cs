using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHS2TrackerDataImporter
{
    public class response
    {
        public string responseType { get; set; }
        public string status { get; set; }
        public int imported { get; set; }
        public int updated { get; set; }
        public int deleted { get; set; }
        public int ignored { get; set; }



        public importOptions importOptions { get; set; }
        public List<importSummaries> importSummaries { get; set; }
    
    }

}