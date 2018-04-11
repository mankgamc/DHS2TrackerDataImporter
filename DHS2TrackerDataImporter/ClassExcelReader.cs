using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToExcel;

namespace DHS2TrackerDataImporter
{
   public class ClassExcelReader
    {
       public  List<ClassTrackedEntityInstance> ReadBidResponse(string path, string sheetname)
        {
            string pathToExcelFile = path;
            string sheetName = sheetname;
            var excelFile = new ExcelQueryFactory(pathToExcelFile);
            var columns = excelFile.GetColumnNames(sheetname);
            List<ClassTrackedEntityInstance> TrackedEntityInstanceList = new List<ClassTrackedEntityInstance>();

            excelFile.AddMapping<ClassExcelColumns>(x => x.FirstNames, "fwbL7M02lF8");
            excelFile.AddMapping<ClassExcelColumns>(x => x.Surname, "npuuHtfRuF2");
            excelFile.AddMapping<ClassExcelColumns>(x => x.Citizen, "cZNwzP1BH6t");
            excelFile.AddMapping<ClassExcelColumns>(x => x.IDNumber, "nUW9eEjkgkm");
            excelFile.AddMapping<ClassExcelColumns>(x => x.PassportNumber, "DlM2NO5RIC9");
            excelFile.AddMapping<ClassExcelColumns>(x => x.Gender, "MKujxyoLgZi");
            excelFile.AddMapping<ClassExcelColumns>(x => x.Race, "DEJES3Pv3UG");
            excelFile.AddMapping<ClassExcelColumns>(x => x.MaritalStatus, "r95GuttdSNh");
            excelFile.AddMapping<ClassExcelColumns>(x => x.DriversLicense, "Z5xt753Dfp4");
            excelFile.AddMapping<ClassExcelColumns>(x => x.DriversLicenseCode, "WGnhNYv5ewP");
            excelFile.AddMapping<ClassExcelColumns>(x => x.UniversityName, "QhnwshFZDmW");
            excelFile.AddMapping<ClassExcelColumns>(x => x.StudentNumber, "ZwK0SdsGy0P");
            excelFile.AddMapping<ClassExcelColumns>(x => x.CurrentResidentiaAddress, "lIrn1ZUvl44");
            excelFile.AddMapping<ClassExcelColumns>(x => x.CurrentPostalAddress, "XKfrWVdAlCt");
            excelFile.AddMapping<ClassExcelColumns>(x => x.CurrentTelephoneNumber, "eZLUhiVNdkA");
            excelFile.AddMapping<ClassExcelColumns>(x => x.PermanentResidentialAddress, "nNo2FHpuXUA");
            excelFile.AddMapping<ClassExcelColumns>(x => x.PermanentPostalAddress, "vPUAHLnm5Ud");
            excelFile.AddMapping<ClassExcelColumns>(x => x.PermanentTelephoneNumber, "FvS7XcU9EBI");
            excelFile.AddMapping<ClassExcelColumns>(x => x.CellPhoneNumber, "rE423VadAmG");
            excelFile.AddMapping<ClassExcelColumns>(x => x.Email, "B9Lex1IKxxx");
            excelFile.AddMapping<ClassExcelColumns>(x => x.CurrentResidentialAddressStreet, "dHCCRGfLeHh");
            excelFile.AddMapping<ClassExcelColumns>(x => x.CurrentResidentialAddressSuburb, "YF1gZoAgfj9");
            excelFile.AddMapping<ClassExcelColumns>(x => x.CurrentResidentialAddressTown, "f0vFJfR9Jlc");
            excelFile.AddMapping<ClassExcelColumns>(x => x.CurrentResidentialAddressCode, "I6KNblOc74J");
            excelFile.AddMapping<ClassExcelColumns>(x => x.CurrentPostalAddressStreet, "gDlukQllwkB");
            excelFile.AddMapping<ClassExcelColumns>(x => x.CurrentPostalAddressSuburb, "FnegLOJfrhc");
            excelFile.AddMapping<ClassExcelColumns>(x => x.CurrentPostalAddressTown, "GPRESHAw4VB");
            excelFile.AddMapping<ClassExcelColumns>(x => x.CurrentPostalAddressCode, "zlCYDsO3lKt");
            excelFile.AddMapping<ClassExcelColumns>(x => x.PermanentResidentialAddressStreet, "ml40P4EViJq");
            excelFile.AddMapping<ClassExcelColumns>(x => x.PermanentResidentialAddressSuburb, "tmpCMPvAoxw");
            excelFile.AddMapping<ClassExcelColumns>(x => x.PermanentResidentialAddressTown, "rH6Jmk3dEIY");
            excelFile.AddMapping<ClassExcelColumns>(x => x.PermanentResidentialAddressCode, "x4NhNaB7lI7");
            excelFile.AddMapping<ClassExcelColumns>(x => x.PermanentPostalAddressStreet, "ncKWgjinQU5");
            excelFile.AddMapping<ClassExcelColumns>(x => x.PermanentPostalAddressSuburb, "a7ZoAENl35h");
            excelFile.AddMapping<ClassExcelColumns>(x => x.PermanentPostalAddressTown, "KIfvERqVLm0");
            excelFile.AddMapping<ClassExcelColumns>(x => x.PermanentPostalAddressCode, "iHi7NpfU3e3");
            excelFile.AddMapping<ClassExcelColumns>(x => x.SpouseIDNumber, "U4Z0Ick64FD");
            excelFile.AddMapping<ClassExcelColumns>(x => x.SpousePassportNumber, "D5uwEanN3gR");
            excelFile.AddMapping<ClassExcelColumns>(x => x.FieldOfStudyCommunityService, "xrxNHUIbU6q");
            excelFile.AddMapping<ClassExcelColumns>(x => x.FieldOfStudyInternship, "dInNUakoHfq");
            excelFile.AddMapping<ClassExcelColumns>(x => x.CountryofOrigin, "UxDGbY8wlon");
            excelFile.AddMapping<ClassExcelColumns>(x => x.Institution, "M0aeea196b2");
            excelFile.AddMapping<ClassExcelColumns>(x => x.TermsandConditionsAccepted, "GfazfQE5g3T");
            excelFile.AddMapping<ClassExcelColumns>(x => x.OtherInstitutionofLearning, "xkNBkzZVXEe");
            excelFile.AddMapping<ClassExcelColumns>(x => x.Cycle, "QLVDdTJHOxQ");
            excelFile.AddMapping<ClassExcelColumns>(x => x.ApplicantUsername, "aNl6WKN7Kk7");
            excelFile.AddMapping<ClassExcelColumns>(x => x.Areyourequiredtowriteaboardexam, "q4nNOX8GnfD");
            excelFile.AddMapping<ClassExcelColumns>(x => x.BoardExamResultDate, "NXZq9iwF18s");
            excelFile.AddMapping<ClassExcelColumns>(x => x.InstitutionofInternshipTraining, "gf8tGs8ITYC");
            excelFile.AddMapping<ClassExcelColumns>(x => x.RegistrationNumberwiththeStatutoryBody, "wZd9MoxoGnH");
            excelFile.AddMapping<ClassExcelColumns>(x => x.PERSALnumber, "tgmTrEcewUK");
            excelFile.AddMapping<ClassExcelColumns>(x => x.Nextofkincontactnumber, "OPvGrmEkPeC");
            excelFile.AddMapping<ClassExcelColumns>(x => x.Nextofkinnameandsurname, "LYI85LpSbqH");
            excelFile.AddMapping<ClassExcelColumns>(x => x.Nextofkinrelationshiptype, "oLcmIUVj92L");
            excelFile.AddMapping<ClassExcelColumns>(x => x.Alternativeemail, "dx6jTzP3yTg");

            var excelRecord = from r in excelFile.Worksheet<ClassExcelColumns>(sheetName) select r;

            var excel = new ExcelQueryFactory(path);
            var columnNames = excel.GetColumnNames(sheetName);
            int numberOfColumns = columnNames.Count();
            ClassAttributes[] attributesArray = new ClassAttributes[numberOfColumns];
            try
            {
                int i = 0;
                foreach (var record in excelRecord)
                {
                    ClassTrackedEntityInstance trackentityIns = new ClassTrackedEntityInstance();
                    int j = 0;
                    foreach(var column in columnNames)
                    {
                        if (column == "fwbL7M02lF8") { attributesArray[j].attribute = "fwbL7M02lF8"; attributesArray[j].value = record.FirstNames; }
                        else if (column == "npuuHtfRuF2") { attributesArray[j].attribute = "npuuHtfRuF2"; attributesArray[j].value = record.Surname; }
                        else if (column == "cZNwzP1BH6t") { attributesArray[j].attribute = "cZNwzP1BH6t"; attributesArray[j].value = record.Citizen; }
                        else if (column == "nUW9eEjkgkm") { attributesArray[j].attribute = "nUW9eEjkgkm"; attributesArray[j].value = record.IDNumber; }
                        else if (column == "DlM2NO5RIC9") { attributesArray[j].attribute = "DlM2NO5RIC9"; attributesArray[j].value = record.PassportNumber; }
                        else if (column == "MKujxyoLgZi") { attributesArray[j].attribute = "MKujxyoLgZi"; attributesArray[j].value = record.Gender; }
                        else if (column == "DEJES3Pv3UG") { attributesArray[j].attribute = "DEJES3Pv3UG"; attributesArray[j].value = record.Race; }
                        else if (column == "r95GuttdSNh") { attributesArray[j].attribute = "r95GuttdSNh"; attributesArray[j].value = record.MaritalStatus; }
                        else if (column == "Z5xt753Dfp4") { attributesArray[j].attribute = "Z5xt753Dfp4"; attributesArray[j].value = record.DriversLicense; }
                        else if (column == "WGnhNYv5ewP") { attributesArray[j].attribute = "WGnhNYv5ewP"; attributesArray[j].value = record.DriversLicenseCode; }
                        else if (column == "QhnwshFZDmW") { attributesArray[j].attribute = "QhnwshFZDmW"; attributesArray[j].value = record.UniversityName; }
                        else if (column == "ZwK0SdsGy0P") { attributesArray[j].attribute = "ZwK0SdsGy0P"; attributesArray[j].value = record.StudentNumber; }
                        else if (column == "lIrn1ZUvl44") { attributesArray[j].attribute = "lIrn1ZUvl44"; attributesArray[j].value = record.CurrentResidentiaAddress; }
                        else if (column == "XKfrWVdAlCt") { attributesArray[j].attribute = "XKfrWVdAlCt"; attributesArray[j].value = record.CurrentPostalAddress; }
                        else if (column == "eZLUhiVNdkA") { attributesArray[j].attribute = "eZLUhiVNdkA"; attributesArray[j].value = record.CurrentTelephoneNumber; }
                        else if (column == "nNo2FHpuXUA") { attributesArray[j].attribute = "nNo2FHpuXUA"; attributesArray[j].value = record.PermanentResidentialAddress; }
                        else if (column == "vPUAHLnm5Ud") { attributesArray[j].attribute = "vPUAHLnm5Ud"; attributesArray[j].value = record.PermanentPostalAddress; }
                        else if (column == "FvS7XcU9EBI") { attributesArray[j].attribute = "FvS7XcU9EBI"; attributesArray[j].value = record.PermanentTelephoneNumber; }
                        else if (column == "rE423VadAmG") { attributesArray[j].attribute = "rE423VadAmG"; attributesArray[j].value = record.CellPhoneNumber; }
                        else if (column == "B9Lex1IKxxx") { attributesArray[j].attribute = "B9Lex1IKxxx"; attributesArray[j].value = record.Email; }
                        else if (column == "dHCCRGfLeHh") { attributesArray[j].attribute = "dHCCRGfLeHh"; attributesArray[j].value = record.CurrentResidentialAddressStreet; }
                        else if (column == "YF1gZoAgfj9") { attributesArray[j].attribute = "YF1gZoAgfj9"; attributesArray[j].value = record.CurrentResidentialAddressSuburb; }
                        else if (column == "f0vFJfR9Jlc") { attributesArray[j].attribute = "f0vFJfR9Jlc"; attributesArray[j].value = record.CurrentResidentialAddressTown; }
                        else if (column == "I6KNblOc74J") { attributesArray[j].attribute = "I6KNblOc74J"; attributesArray[j].value = record.CurrentResidentialAddressCode; }
                        else if (column == "gDlukQllwkB") { attributesArray[j].attribute = "gDlukQllwkB"; attributesArray[j].value = record.CurrentPostalAddressStreet; }
                        else if (column == "FnegLOJfrhc") { attributesArray[j].attribute = "FnegLOJfrhc"; attributesArray[j].value = record.CurrentPostalAddressSuburb; }
                        else if (column == "GPRESHAw4VB") { attributesArray[j].attribute = "GPRESHAw4VB"; attributesArray[j].value = record.CurrentPostalAddressTown; }
                        else if (column == "zlCYDsO3lKt") { attributesArray[j].attribute = "zlCYDsO3lKt"; attributesArray[j].value = record.CurrentPostalAddressCode; }
                        else if (column == "ml40P4EViJq") { attributesArray[j].attribute = "ml40P4EViJq"; attributesArray[j].value = record.PermanentResidentialAddressStreet; }
                        else if (column == "tmpCMPvAoxw") { attributesArray[j].attribute = "tmpCMPvAoxw"; attributesArray[j].value = record.PermanentResidentialAddressSuburb; }
                        else if (column == "rH6Jmk3dEIY") { attributesArray[j].attribute = "rH6Jmk3dEIY"; attributesArray[j].value = record.PermanentResidentialAddressTown; }
                        else if (column == "x4NhNaB7lI7") { attributesArray[j].attribute = "x4NhNaB7lI7"; attributesArray[j].value = record.PermanentResidentialAddressCode; }
                        else if (column == "ncKWgjinQU5") { attributesArray[j].attribute = "ncKWgjinQU5"; attributesArray[j].value = record.PermanentPostalAddressStreet; }
                        else if (column == "a7ZoAENl35h") { attributesArray[j].attribute = "a7ZoAENl35h"; attributesArray[j].value = record.PermanentPostalAddressSuburb; }
                        else if (column == "KIfvERqVLm0") { attributesArray[j].attribute = "KIfvERqVLm0"; attributesArray[j].value = record.PermanentPostalAddressTown; }
                        else if (column == "iHi7NpfU3e3") { attributesArray[j].attribute = "iHi7NpfU3e3"; attributesArray[j].value = record.PermanentPostalAddressCode; }
                        else if (column == "U4Z0Ick64FD") { attributesArray[j].attribute = "U4Z0Ick64FD"; attributesArray[j].value = record.SpouseIDNumber; }
                        else if (column == "D5uwEanN3gR") { attributesArray[j].attribute = "D5uwEanN3gR"; attributesArray[j].value = record.SpousePassportNumber; }
                        else if (column == "xrxNHUIbU6q") { attributesArray[j].attribute = "xrxNHUIbU6q"; attributesArray[j].value = record.FieldOfStudyCommunityService; }
                        else if (column == "dInNUakoHfq") { attributesArray[j].attribute = "dInNUakoHfq"; attributesArray[j].value = record.FieldOfStudyInternship; }
                        else if (column == "UxDGbY8wlon") { attributesArray[j].attribute = "UxDGbY8wlon"; attributesArray[j].value = record.CountryofOrigin; }
                        else if (column == "M0aeea196b2") { attributesArray[j].attribute = "M0aeea196b2"; attributesArray[j].value = record.Institution; }
                        else if (column == "GfazfQE5g3T") { attributesArray[j].attribute = "GfazfQE5g3T"; attributesArray[j].value = record.TermsandConditionsAccepted; }
                        else if (column == "xkNBkzZVXEe") { attributesArray[j].attribute = "xkNBkzZVXEe"; attributesArray[j].value = record.OtherInstitutionofLearning; }
                        else if (column == "QLVDdTJHOxQ") { attributesArray[j].attribute = "QLVDdTJHOxQ"; attributesArray[j].value = record.Cycle; }
                        else if (column == "aNl6WKN7Kk7") { attributesArray[j].attribute = "aNl6WKN7Kk7"; attributesArray[j].value = record.ApplicantUsername; }
                        else if (column == "q4nNOX8GnfD") { attributesArray[j].attribute = "q4nNOX8GnfD"; attributesArray[j].value = record.Areyourequiredtowriteaboardexam; }
                        else if (column == "NXZq9iwF18s") { attributesArray[j].attribute = "NXZq9iwF18s"; attributesArray[j].value = record.BoardExamResultDate; }
                        else if (column == "gf8tGs8ITYC") { attributesArray[j].attribute = "gf8tGs8ITYC"; attributesArray[j].value = record.InstitutionofInternshipTraining; }
                        else if (column == "wZd9MoxoGnH") { attributesArray[j].attribute = "wZd9MoxoGnH"; attributesArray[j].value = record.RegistrationNumberwiththeStatutoryBody; }
                        else if (column == "tgmTrEcewUK") { attributesArray[j].attribute = "tgmTrEcewUK"; attributesArray[j].value = record.PERSALnumber; }
                        else if (column == "OPvGrmEkPeC") { attributesArray[j].attribute = "OPvGrmEkPeC"; attributesArray[j].value = record.Nextofkincontactnumber; }
                        else if (column == "LYI85LpSbqH") { attributesArray[j].attribute = "LYI85LpSbqH"; attributesArray[j].value = record.Nextofkinnameandsurname; }
                        else if (column == "oLcmIUVj92L") { attributesArray[j].attribute = "oLcmIUVj92L"; attributesArray[j].value = record.Nextofkinrelationshiptype; }
                        else if (column == "dx6jTzP3yTg") { attributesArray[j].attribute = "dx6jTzP3yTg"; attributesArray[j].value = record.Alternativeemail; }
                        j++;
                    }
                    //add attributesArray[j] to TrackentityInstance 
                    trackentityIns.attribute = attributesArray;
                    //Create TrackentityInstance and its collection
                    TrackedEntityInstanceList.Add(trackentityIns);
                    i = i + 1;
                }
            }
            catch
            {
                Console.Write("record number");
            }
            return TrackedEntityInstanceList;
        }
    }
}
