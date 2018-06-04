using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHS2TrackerDataImporter
{
    public class importOptions
    {
        /*
        public object idSchemes;
        public Boolean dryRun { get; set; }
        public Boolean async { get; set; }
        public string importStrategy { get; set; }
        public string mergeMode { get; set; }
        public string reportMode { get; set; }
        public Boolean skipExistingCheck { get; set; }
        public Boolean sharing { get; set; }
        public Boolean skipNotifications { get; set; }
        public Boolean datasetAllowsPeriods { get; set; }
        public Boolean strictPeriods { get; set; }
        public Boolean strictCategoryOptionCombos { get; set; }
        public Boolean strictAttributeOptionCombos { get; set; }
        public Boolean strictOrganisationUnits { get; set; }
        public Boolean requireCategoryOptionCombo { get; set; }
        public Boolean requireAttributeOptionCombo { get; set; }
        */
        public object idSchemes { get; set; }
        public bool dryRun { get; set; }
        public bool async { get; set; }
        public string importStrategy { get; set; }
        public string mergeMode { get; set; }
        public string reportMode { get; set; }
        public bool skipExistingCheck { get; set; }
        public bool sharing { get; set; }
        public bool skipNotifications { get; set; }
        public bool datasetAllowsPeriods { get; set; }
        public bool strictPeriods { get; set; }
        public bool strictCategoryOptionCombos { get; set; }
        public bool strictAttributeOptionCombos { get; set; }
        public bool strictOrganisationUnits { get; set; }
        public bool requireCategoryOptionCombo { get; set; }
        public bool requireAttributeOptionCombo { get; set; }

    }
}