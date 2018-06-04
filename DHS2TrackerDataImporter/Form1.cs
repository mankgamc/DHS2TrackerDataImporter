using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Text;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.IO;


namespace DHS2TrackerDataImporter
{    public partial class FrmImportTrackerData : Form
    {
        trackedEntityInstances[] trackedentityInstPayLoad;
        TrackedEntityInstancesArray trackedEntityInstances = new TrackedEntityInstancesArray();
        ClassExcelReader xlReader = new ClassExcelReader();

       // private string _Trackerfilename;
        private  readonly log4net.ILog Log = log4net.LogManager.GetLogger
        (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);     
        private  HttpResponseMessage _response;
        // private  HttpResponseMessage _authenticationResponse;


        private string  orgUnit = "JLA7wl59oN3";


        //medical internship
        private string trackedEntity = "zm66N9hwGtY";


        private string  programStageComm = "Ebk4t7oiaxK";
        private string  programStageMedIn = "pvydpYwb9NH";

        private string selectedprogramStage = "";

        //community service

        //  private string trackedEntity = "sl8pmIFJdlz";

        private string programStageMedicalInternship = "";
        private string programStageCommServe = "";

        private string program;
        public FrmImportTrackerData()
        {
            InitializeComponent();
        }

        private void btnPostData_Click(object sender, EventArgs e)
        {
            int progressInt = 0;
            HttpClientHandler clientHandler = new HttpClientHandler();
            //read app config file 
            string dhis2Instance = ConfigurationManager.AppSettings["dhis2Instance"];
            string port = ConfigurationManager.AppSettings["port"];
            string username = ConfigurationManager.AppSettings["username"];
            string password = ConfigurationManager.AppSettings["password"];
            string sitename = ConfigurationManager.AppSettings["siteName"];
            string apiUri = string.Format("{0}:{1}", dhis2Instance, port);
            string auth = string.Format("{0}:{1}", username, password);
            string enc = Convert.ToBase64String(Encoding.ASCII.GetBytes(auth));
            string cred = string.Format("{0} {1}", "Basic", enc);


            string MedicalInternshipprogramUid = "lADHIO1T8xr";
            string CommunityServiceprogramUid = "yTKKWWpA6Ku";

            string selectedProgram = "";

            if (TxtFilepath.Text.Equals(""))
            {
                MessageBox.Show("Select a file to import data from", "File", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                var path = TxtFilepath.Text;
                bool flag = String.CompareOrdinal(path, "") != 0;

                if (flag)
                {
                    path = Path.GetDirectoryName(path);         
                    if (path != null)
                    {
                        var directoryInfo = new DirectoryInfo(path);
                        FileInfo[] files = directoryInfo.GetFiles("*.xlsx");
                        if (files.Any())
                        {
                            var fullNames = files.Select(file => file.FullName).ToArray();

                            foreach (var fileInfo in fullNames)
                            {
                                if (program== "Community Service")
                                    {
                                    selectedProgram = CommunityServiceprogramUid;
                                    trackedEntity = "sl8pmIFJdlz";
                                    selectedprogramStage = programStageComm;

                                    }
                                else if (program == "Medical Internship")
                                    {
                                    selectedProgram = MedicalInternshipprogramUid;
                                    trackedEntity = "zm66N9hwGtY";
                                    selectedprogramStage = programStageMedIn;
                                }

                               trackedentityInstPayLoad = xlReader.ReadBidResponse(fileInfo, "ImportSheet", selectedProgram, orgUnit, trackedEntity, selectedprogramStage);

                               trackedEntityInstances.trackedEntityInstances = trackedentityInstPayLoad;

                               progressInt++;
                               progressBarImport.Maximum = files.Length;
                               progressBarImport.Value = progressInt;
                                var percent = (int)(((double)progressBarImport.Value / (double)progressBarImport.Maximum) * 100);
                                progressBarImport.CreateGraphics().DrawString(percent + "%", new Font("Arial", (float)8.25, FontStyle.Regular), Brushes.Black, new PointF(progressBarImport.Width / 2 - 10, progressBarImport.Height / 2 - 7));
                              
                                /*
                                using (var client = new HttpClient(clientHandler))
                                {
                                    client.BaseAddress = new Uri(apiUri);
                                    client.DefaultRequestHeaders.Accept.Clear();
                                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                                    client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", cred);
                                    try
                                    {
                                        string payload = JsonConvert.SerializeObject(trackedEntityInstances, Formatting.None
                                     );
                                     //   Console.WriteLine(new StringContent(JsonConvert.SerializeObject(trackedEntityInstances)));

                                        //post data
                                        _response = client.PostAsync(string.Format("{0}{1}", sitename, "/api/trackedEntityInstances"),
                                                            new StringContent(JsonConvert.SerializeObject(trackedEntityInstances), Encoding.UTF8,
                                                                "application/json")).Result;
                                        Console.WriteLine(_response);
                                    }
                                    catch(Exception excp)
                                    {
                                        Console.WriteLine(excp);
                                    }
                                }

    */


                            }
                        }             
                    }
                }          
            }           
        }

        private void SelectFile_Click(object sender, EventArgs e)
        {
            this.program = cmbProgram.Text;
            if (this.program != "")
            {
                this.openFileDialog1.Title = @"Select the Bid Response excel file";
                this.openFileDialog1.ShowDialog();
                this.TxtFilepath.Text = this.openFileDialog1.FileName;
                string path = this.TxtFilepath.Text;                
            } else
            {
                MessageBox.Show("Please choose a program", "File", MessageBoxButtons.OK,
                      MessageBoxIcon.Information);
            }   
            
            
        }
    }
}
