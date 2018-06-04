using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToExcel;
using System.IO;
using System.Configuration;
using System.Text;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.IO;

namespace DHS2TrackerDataImporter
{
    public class ClassExcelReader
    {
        private HttpResponseMessage _response;
        HttpClientHandler clientHandler = new HttpClientHandler();
        public trackedEntityInstances[] ReadBidResponse(string path, string sheetname, string program, string org, string entity, string pstage)
        {
            //read app config file 
            string dhis2Instance = ConfigurationManager.AppSettings["dhis2Instance"];

            //ignore  for hisp icsp instances 
            
            string port = ConfigurationManager.AppSettings["port"];
            string username = ConfigurationManager.AppSettings["username"];
            string password = ConfigurationManager.AppSettings["password"];
            string sitename = ConfigurationManager.AppSettings["siteName"];

           // string apiUri = string.Format("{0}:{1}", dhis2Instance, port);

            //ignore  for hisp icsp instances 
          // string apiUri = string.Format("{0}:{1}", dhis2Instance, port);

            string auth = string.Format("{0}:{1}", username, password);
            string enc = Convert.ToBase64String(Encoding.ASCII.GetBytes(auth));
            string cred = string.Format("{0} {1}", "Basic", enc);

            
            var client = new HttpClient(clientHandler);

           // string apiUri = dhis2Instance;

            //ignore line below for hisp icsp instances 
              string apiUri = string.Format("{0}:{1}", dhis2Instance, port);
            client.BaseAddress = new Uri(apiUri);

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", cred);

            int progressInt = 0;
            
            string pathToExcelFile = path;
            string sheetName = sheetname;
            var excelFile = new ExcelQueryFactory(pathToExcelFile);
            var columnNames = excelFile.GetColumnNames(sheetname);
            trackedEntityInstances[] TrackedEntityInstanceList;

         //   List<trackedEntityInstances> TrackedEntityInstanceListPayLoad = new List<trackedEntityInstances>();
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
            excelFile.AddMapping<ClassExcelColumns>(x => x.preregistration, "pBWgXQPaJUc");
            



            var excelRecord = from r in excelFile.Worksheet<ClassExcelColumns>(sheetName) select r;
            int numberOfColumns = columnNames.Count();
          
            try
            {
                TrackedEntityInstanceList  = new trackedEntityInstances[excelRecord.Count()]; 
                int i = 0;
                attributes[] attributesArray = new attributes[numberOfColumns];
                enrollments[] enrollments = new enrollments[1];

               // List<attributes> attributesArrayPayload = new List<attributes>(); 

                foreach (var record in excelRecord)
                {
                    attributesArray = new attributes[numberOfColumns];
                    List<attributes> attributesArrayPayload = new List<attributes>();

                    //trackedEntityInstances trackentityIns = new trackedEntityInstances();
                    int j = 0;
                    foreach(var column in columnNames)
                    {
                        attributesArray[j] = new attributes();
                  
                            if (column == "fwbL7M02lF8") { if (record.FirstNames == null) { } else { attributesArray[j].attribute = "fwbL7M02lF8"; attributesArray[j].value = record.FirstNames; attributesArrayPayload.Add(attributesArray[j]); } }
                            else if (column == "npuuHtfRuF2") { if (record.Surname == null) { } else { attributesArray[j].attribute = "npuuHtfRuF2"; attributesArray[j].value = record.Surname; attributesArrayPayload.Add(attributesArray[j]); } }
                        else if (column == "cZNwzP1BH6t") { if (record.Citizen == null) { } else { attributesArray[j].attribute = "cZNwzP1BH6t"; attributesArray[j].value = record.Citizen; attributesArrayPayload.Add(attributesArray[j]); } }
                        else if (column == "nUW9eEjkgkm") { if (record.IDNumber == null) { } else { attributesArray[j].attribute = "nUW9eEjkgkm"; attributesArray[j].value = record.IDNumber; attributesArrayPayload.Add(attributesArray[j]); } }
                        else if (column == "DlM2NO5RIC9") { if (record.PassportNumber == null) { } else { attributesArray[j].attribute = "DlM2NO5RIC9"; attributesArray[j].value = record.PassportNumber; attributesArrayPayload.Add(attributesArray[j]); } }
                        else if (column == "MKujxyoLgZi") { if (record.Gender == null) { } else { attributesArray[j].attribute = "MKujxyoLgZi"; attributesArray[j].value = record.Gender; attributesArrayPayload.Add(attributesArray[j]); } }
                        else if (column == "DEJES3Pv3UG") { if (record.Race == null) { } else { attributesArray[j].attribute = "DEJES3Pv3UG"; attributesArray[j].value = record.Race; attributesArrayPayload.Add(attributesArray[j]); } }
                        else if (column == "r95GuttdSNh") { if (record.MaritalStatus == null) { } else { attributesArray[j].attribute = "r95GuttdSNh"; attributesArray[j].value = record.MaritalStatus; attributesArrayPayload.Add(attributesArray[j]); } }
                        else if (column == "Z5xt753Dfp4") { if (record.DriversLicense == null) { } else { attributesArray[j].attribute = "Z5xt753Dfp4"; attributesArray[j].value = record.DriversLicense; attributesArrayPayload.Add(attributesArray[j]); } }
                        else if (column == "WGnhNYv5ewP") { if (record.DriversLicenseCode == null) { } else { attributesArray[j].attribute = "WGnhNYv5ewP"; attributesArray[j].value = record.DriversLicenseCode; attributesArrayPayload.Add(attributesArray[j]); } }
                        else if (column == "QhnwshFZDmW") { if (record.UniversityName == null) { } else { attributesArray[j].attribute = "QhnwshFZDmW"; attributesArray[j].value = record.UniversityName; attributesArrayPayload.Add(attributesArray[j]); } }
                        else if (column == "ZwK0SdsGy0P") { if (record.StudentNumber == null) { } else { attributesArray[j].attribute = "ZwK0SdsGy0P"; attributesArray[j].value = record.StudentNumber; attributesArrayPayload.Add(attributesArray[j]); } }
                        else if (column == "lIrn1ZUvl44") { if (record.CurrentPostalAddress == null) { } else { attributesArray[j].attribute = "lIrn1ZUvl44"; attributesArray[j].value = record.CurrentResidentiaAddress; attributesArrayPayload.Add(attributesArray[j]); } }
                        else if (column == "XKfrWVdAlCt") { if (record.CurrentPostalAddress == null) { } else { attributesArray[j].attribute = "XKfrWVdAlCt"; attributesArray[j].value = record.CurrentPostalAddress; attributesArrayPayload.Add(attributesArray[j]); } }
                        else if (column == "eZLUhiVNdkA") { if (record.CurrentTelephoneNumber == null) { } else { attributesArray[j].attribute = "eZLUhiVNdkA"; attributesArray[j].value = record.CurrentTelephoneNumber; attributesArrayPayload.Add(attributesArray[j]); } }
                        else if (column == "nNo2FHpuXUA") { if (record.PermanentResidentialAddress == null) { } else { attributesArray[j].attribute = "nNo2FHpuXUA"; attributesArray[j].value = record.PermanentResidentialAddress; attributesArrayPayload.Add(attributesArray[j]); } }
                        else if (column == "vPUAHLnm5Ud") { if (record.PermanentPostalAddress == null) { } else { attributesArray[j].attribute = "vPUAHLnm5Ud"; attributesArray[j].value = record.PermanentPostalAddress; attributesArrayPayload.Add(attributesArray[j]); } }
                        else if (column == "FvS7XcU9EBI") { if (record.PermanentTelephoneNumber == null) { } else { attributesArray[j].attribute = "FvS7XcU9EBI"; attributesArray[j].value = record.PermanentTelephoneNumber; attributesArrayPayload.Add(attributesArray[j]); } }
                        else if (column == "rE423VadAmG") { if (record.CellPhoneNumber == null) { } else { attributesArray[j].attribute = "rE423VadAmG"; attributesArray[j].value = record.CellPhoneNumber; attributesArrayPayload.Add(attributesArray[j]); } }
                        else if (column == "B9Lex1IKxxx") { if (record.Email == null) { } else { attributesArray[j].attribute = "B9Lex1IKxxx"; attributesArray[j].value = record.Email; attributesArrayPayload.Add(attributesArray[j]); } }
                        else if (column == "dHCCRGfLeHh") { if (record.CurrentResidentialAddressStreet == null) { } else { attributesArray[j].attribute = "dHCCRGfLeHh"; attributesArray[j].value = record.CurrentResidentialAddressStreet; attributesArrayPayload.Add(attributesArray[j]); } }
                        else if (column == "YF1gZoAgfj9") { if (record.CurrentResidentialAddressSuburb == null) { } else { attributesArray[j].attribute = "YF1gZoAgfj9"; attributesArray[j].value = record.CurrentResidentialAddressSuburb; attributesArrayPayload.Add(attributesArray[j]); } }
                        else if (column == "f0vFJfR9Jlc") { if (record.CurrentResidentialAddressTown == null) { } else { attributesArray[j].attribute = "f0vFJfR9Jlc"; attributesArray[j].value = record.CurrentResidentialAddressTown; attributesArrayPayload.Add(attributesArray[j]); } }
                        else if (column == "I6KNblOc74J") { if (record.CurrentResidentialAddressCode == null) { } else { attributesArray[j].attribute = "I6KNblOc74J"; attributesArray[j].value = record.CurrentResidentialAddressCode; attributesArrayPayload.Add(attributesArray[j]); } }
                        else if (column == "gDlukQllwkB") { if (record.CurrentPostalAddressStreet == null) { } else { attributesArray[j].attribute = "gDlukQllwkB"; attributesArray[j].value = record.CurrentPostalAddressStreet; attributesArrayPayload.Add(attributesArray[j]); } }
                        else if (column == "FnegLOJfrhc") { if (record.CurrentPostalAddressSuburb == null) { } else { attributesArray[j].attribute = "FnegLOJfrhc"; attributesArray[j].value = record.CurrentPostalAddressSuburb; attributesArrayPayload.Add(attributesArray[j]); } }
                        else if (column == "GPRESHAw4VB") { if (record.CurrentPostalAddressTown == null) { } else { attributesArray[j].attribute = "GPRESHAw4VB"; attributesArray[j].value = record.CurrentPostalAddressTown; attributesArrayPayload.Add(attributesArray[j]); } }
                        else if (column == "zlCYDsO3lKt") { if (record.CurrentPostalAddressCode == null) { } else { attributesArray[j].attribute = "zlCYDsO3lKt"; attributesArray[j].value = record.CurrentPostalAddressCode; attributesArrayPayload.Add(attributesArray[j]); } }
                        else if (column == "ml40P4EViJq") { if (record.PermanentResidentialAddressStreet == null) { } else { attributesArray[j].attribute = "ml40P4EViJq"; attributesArray[j].value = record.PermanentResidentialAddressStreet; attributesArrayPayload.Add(attributesArray[j]); } }
                        else if (column == "tmpCMPvAoxw") { if (record.PermanentResidentialAddressSuburb == null) { } else { attributesArray[j].attribute = "tmpCMPvAoxw"; attributesArray[j].value = record.PermanentResidentialAddressSuburb; attributesArrayPayload.Add(attributesArray[j]); } }
                        else if (column == "rH6Jmk3dEIY") { if (record.PermanentResidentialAddressTown == null) { } else { attributesArray[j].attribute = "rH6Jmk3dEIY"; attributesArray[j].value = record.PermanentResidentialAddressTown; attributesArrayPayload.Add(attributesArray[j]); } }
                        else if (column == "x4NhNaB7lI7") { if (record.PermanentResidentialAddressTown == null) { } else { attributesArray[j].attribute = "x4NhNaB7lI7"; attributesArray[j].value = record.PermanentResidentialAddressCode; attributesArrayPayload.Add(attributesArray[j]); } }
                        else if (column == "ncKWgjinQU5") { if (record.PermanentPostalAddressStreet == null) { } else { attributesArray[j].attribute = "ncKWgjinQU5"; attributesArray[j].value = record.PermanentPostalAddressStreet; attributesArrayPayload.Add(attributesArray[j]); } }
                        else if (column == "a7ZoAENl35h") { if (record.PermanentPostalAddressSuburb == null) { } else { attributesArray[j].attribute = "a7ZoAENl35h"; attributesArray[j].value = record.PermanentPostalAddressSuburb; attributesArrayPayload.Add(attributesArray[j]); } }
                        else if (column == "KIfvERqVLm0") { if (record.PermanentPostalAddressTown == null) { } else { attributesArray[j].attribute = "KIfvERqVLm0"; attributesArray[j].value = record.PermanentPostalAddressTown; attributesArrayPayload.Add(attributesArray[j]); } }
                        else if (column == "iHi7NpfU3e3") { if (record.PermanentPostalAddressCode == null) { } else { attributesArray[j].attribute = "iHi7NpfU3e3"; attributesArray[j].value = record.PermanentPostalAddressCode; attributesArrayPayload.Add(attributesArray[j]); } }
                        else if (column == "U4Z0Ick64FD") { if (record.SpouseIDNumber == null) { } else { attributesArray[j].attribute = "U4Z0Ick64FD"; attributesArray[j].value = record.SpouseIDNumber; attributesArrayPayload.Add(attributesArray[j]); } }
                        else if (column == "D5uwEanN3gR") { if (record.SpousePassportNumber == null) { } else { attributesArray[j].attribute = "D5uwEanN3gR"; attributesArray[j].value = record.SpousePassportNumber; attributesArrayPayload.Add(attributesArray[j]); } }
                        else if (column == "xrxNHUIbU6q") { if (record.FieldOfStudyCommunityService == null) { } else { attributesArray[j].attribute = "xrxNHUIbU6q"; attributesArray[j].value = record.FieldOfStudyCommunityService; attributesArrayPayload.Add(attributesArray[j]); } }
                        else if (column == "dInNUakoHfq") { if (record.FieldOfStudyInternship == null) { } else { attributesArray[j].attribute = "dInNUakoHfq"; attributesArray[j].value = record.FieldOfStudyInternship; attributesArrayPayload.Add(attributesArray[j]); } }
                        else if (column == "UxDGbY8wlon") { if (record.CountryofOrigin == null) { } else { attributesArray[j].attribute = "UxDGbY8wlon"; attributesArray[j].value = record.CountryofOrigin; attributesArrayPayload.Add(attributesArray[j]); } }
                        else if (column == "M0aeea196b2") { if (record.Institution == null) { } else { attributesArray[j].attribute = "M0aeea196b2"; attributesArray[j].value = record.Institution; attributesArrayPayload.Add(attributesArray[j]); } }
                        else if (column == "GfazfQE5g3T") { if (record.TermsandConditionsAccepted == null) { } else { attributesArray[j].attribute = "GfazfQE5g3T"; attributesArray[j].value = record.TermsandConditionsAccepted; attributesArrayPayload.Add(attributesArray[j]); } }
                        else if (column == "xkNBkzZVXEe") { if (record.OtherInstitutionofLearning == null) { } else { attributesArray[j].attribute = "xkNBkzZVXEe"; attributesArray[j].value = record.OtherInstitutionofLearning; attributesArrayPayload.Add(attributesArray[j]); } }
                        else if (column == "QLVDdTJHOxQ") { if (record.Cycle == null) { } else { attributesArray[j].attribute = "QLVDdTJHOxQ"; attributesArray[j].value = record.Cycle; attributesArrayPayload.Add(attributesArray[j]); } }
                        else if (column == "aNl6WKN7Kk7") { if (record.ApplicantUsername == null) { }
                            else { attributesArray[j].attribute = "aNl6WKN7Kk7"; attributesArray[j].value = record.ApplicantUsername; attributesArrayPayload.Add(attributesArray[j]); } }
                        else if (column == "q4nNOX8GnfD") { if (record.Areyourequiredtowriteaboardexam == null) { } else { attributesArray[j].attribute = "q4nNOX8GnfD"; attributesArray[j].value = record.Areyourequiredtowriteaboardexam; attributesArrayPayload.Add(attributesArray[j]); } }
                        else if (column == "NXZq9iwF18s") { if (record.BoardExamResultDate == null) { } else { attributesArray[j].attribute = "NXZq9iwF18s"; attributesArray[j].value = record.BoardExamResultDate; attributesArrayPayload.Add(attributesArray[j]); } }
                        else if (column == "gf8tGs8ITYC") { if (record.InstitutionofInternshipTraining == null) { } else { attributesArray[j].attribute = "gf8tGs8ITYC"; attributesArray[j].value = record.InstitutionofInternshipTraining; attributesArrayPayload.Add(attributesArray[j]); } }
                        else if (column == "wZd9MoxoGnH") { if (record.RegistrationNumberwiththeStatutoryBody == null) { } else { attributesArray[j].attribute = "wZd9MoxoGnH"; attributesArray[j].value = record.RegistrationNumberwiththeStatutoryBody; attributesArrayPayload.Add(attributesArray[j]); } }
                        else if (column == "tgmTrEcewUK") { if (record.PERSALnumber == null) { } else { attributesArray[j].attribute = "tgmTrEcewUK"; attributesArray[j].value = record.PERSALnumber; attributesArrayPayload.Add(attributesArray[j]); } }
                        else if (column == "OPvGrmEkPeC") { if (record.Nextofkincontactnumber == null) { } else { attributesArray[j].attribute = "OPvGrmEkPeC"; attributesArray[j].value = record.Nextofkincontactnumber; attributesArrayPayload.Add(attributesArray[j]); } }
                        else if (column == "LYI85LpSbqH") { if (record.Nextofkinnameandsurname == null) { } else { attributesArray[j].attribute = "LYI85LpSbqH"; attributesArray[j].value = record.Nextofkinnameandsurname; attributesArrayPayload.Add(attributesArray[j]); } }
                        else if (column == "oLcmIUVj92L") { if (record.Nextofkinrelationshiptype == null) { } else { attributesArray[j].attribute = "oLcmIUVj92L"; attributesArray[j].value = record.Nextofkinrelationshiptype; attributesArrayPayload.Add(attributesArray[j]); } }
                        else if (column == "dx6jTzP3yTg") { if (record.Alternativeemail == null) { } else {attributesArray[j].attribute = "dx6jTzP3yTg"; attributesArray[j].value = record.Alternativeemail; attributesArrayPayload.Add(attributesArray[j]); } }
                        else if (column == "pBWgXQPaJUc") { if (record.preregistration == null) { } else { attributesArray[j].attribute = "pBWgXQPaJUc"; attributesArray[j].value = record.preregistration; attributesArrayPayload.Add(attributesArray[j]); } }

                        j++;
                    }
                    //add attributesArray[j] to TrackentityInstance 
                    // trackentityIns.attribute = attributesArray;
                    // trackentityIns.orgUnit = "JLA7wl59oN3";
                    //  trackentityIns.trackedEntity = "zm66N9hwGtY";
                    //Create TrackentityInstance and its collection

                    enrollments enrol = new enrollments();

                   events eventObject = new events();
                   eventsArray eventArray = new eventsArray();
                   events[] eventObjectArray = new events[1];
                    eventObject.orgUnit = "JLA7wl59oN3";
                    eventObject.program = program;
                    eventObject.eventDate = (DateTime.Now).AddYears(1).ToString("yyyy-MM-dd");

                    
                  //  eventObject.programStage = "Ebk4t7oiaxK"; //community service 
                    eventObject.programStage = "pvydpYwb9NH"; //medical internship


                    eventObjectArray[0] = eventObject;

                    enrol.orgUnit = "JLA7wl59oN3";
                    //this is the orgunit where all registrations and enrollments must go za national unplaced  
              
                    //    enrol.orgUnit = "oisigJWsjb6";

                    //Read Program Selection from the GUI                

                    enrol.program = program;
                    //enrol.enrollmentDate = "2018-04-15";
                    //enrol.incidentDate = "2018-04-15";
                    enrol.enrollmentDate = (DateTime.Now).AddYears(1).ToString("yyyy-MM-dd");
                    enrol.incidentDate = (DateTime.Now).AddYears(1).ToString("yyyy-MM-dd");
                    enrol.status = "COMPLETED";

                //    enrol.events = eventObjectArray;

                    enrollments[0] = enrol;

                    Console.WriteLine(pstage);
                    
                    int completedAttributes = attributesArrayPayload.Count();
                  var   attributesArrayJson = new attributes[completedAttributes];
                    int attrCount = 0;

                    foreach (var attr in attributesArrayPayload)
                    {
                        attributesArrayJson[attrCount] = attr;
                        attrCount = attrCount + 1;
                    }  

                    TrackedEntityInstanceList[i] = new trackedEntityInstances();
                    TrackedEntityInstanceList[i].orgUnit = org;
                    //if medical internship - trackedEntity = "zm66N9hwGtY"
                    TrackedEntityInstanceList[i].trackedEntity = entity;
                    //ifCommunity service  - trackedEntity = "sl8pmIFJdlz"

                    TrackedEntityInstanceList[i].enrollments = enrollments;


                    TrackedEntityInstanceList[i].attributes = attributesArrayJson;           
                       
                        try
                        {
                         string payload = JsonConvert.SerializeObject(TrackedEntityInstanceList[i], Formatting.None);
                             Console.WriteLine("record number  " +i+"  " + payload);

                        //Post trackedEntityInstances
                        _response = client.PostAsync(string.Format("{0}{1}", sitename, "/api/trackedEntityInstances"),
                                                new StringContent(JsonConvert.SerializeObject(TrackedEntityInstanceList[i]), Encoding.UTF8,
                                                    "application/json")).Result;

                        Console.WriteLine(_response);
                        string  resultslJson =  _response.Content.ReadAsStringAsync().Result;
                        webApiresponse webapiResponseObject = JsonConvert.DeserializeObject<webApiresponse>(resultslJson);
                        string trackedentityInstanceId = webapiResponseObject.response.importSummaries[0].reference;

                        eventObject.trackedEntityInstance = trackedentityInstanceId;
                        eventObject.program = program;
                        //  eventObject.programStage = "Ebk4t7oiaxK"; //community service 
                        // eventObject.programStage = "pvydpYwb9NH"; //medical internship

                        eventObject.programStage = pstage;
                        eventObject.orgUnit = "JLA7wl59oN3"; 
                        eventObject.eventDate = (DateTime.Now).AddYears(1).ToString("yyyy-MM-dd");

                        

                        //post enrollments 
                        
                        enrol.trackedEntityInstance = trackedentityInstanceId;

                        string enrolmentPayload = JsonConvert.SerializeObject(enrol);
                        _response = client.PostAsync(string.Format("{0}{1}", sitename, "/api/enrollments"),
                                               new StringContent(JsonConvert.SerializeObject(enrol), Encoding.UTF8,
                                                   "application/json")).Result;
                            
                        //Post events 
                        string eventObjectPayload = JsonConvert.SerializeObject(eventObject);
                        _response = client.PostAsync(string.Format("{0}{1}", sitename, "/api/events"),
                                                new StringContent(JsonConvert.SerializeObject(eventObject), Encoding.UTF8,
                                                    "application/json")).Result;
                    }
                        catch (Exception excp)
                        {
                            Console.WriteLine(excp);
                        }
                    
                    i = i + 1;
                }
                return TrackedEntityInstanceList;
            }
            catch (Exception e )
            {
                Console.Write(e);
                return null;
            }              
        }            
       
        }
}
