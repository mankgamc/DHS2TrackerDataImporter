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


namespace DHS2TrackerDataImporter
{    public partial class FrmImportTrackerData : Form
    {
        List<ClassTrackedEntityInstance> trackedentityInstPayLoad = new List<ClassTrackedEntityInstance>();
        ClassExcelReader xlReader = new ClassExcelReader();

        private string _Trackerfilename;
        private  readonly log4net.ILog Log = log4net.LogManager.GetLogger
        (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);     
        private  HttpResponseMessage _response;
        private  HttpResponseMessage _authenticationResponse;
        public FrmImportTrackerData()
        {
            InitializeComponent();
        }

        private void btnPostData_Click(object sender, EventArgs e)
        {
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

            using (var client = new HttpClient(clientHandler))
            {
                client.BaseAddress = new Uri(apiUri);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", cred);

                try
                {
                    _authenticationResponse = client.PostAsync(string.Format("{0}{1}", sitename, "/dhis-web-commons/security/login.action"),
                                                        new StringContent(JsonConvert.SerializeObject(""), Encoding.UTF8,
                                                            "application/json")).Result;
                    if (_authenticationResponse.IsSuccessStatusCode)
                    {
                        Log.Info("Web Api Authenticated successfully");
                    }
                    //post data
                    _response =client.PostAsync(string.Format("{0}{1}", sitename, "/api/trackedEntityInstances"),
                                        new StringContent(JsonConvert.SerializeObject(trackedentityInstPayLoad), Encoding.UTF8,
                                            "application/json")).Result;
                }
                catch
                {
                }
            }
        }

        private void SelectFile_Click(object sender, EventArgs e)
        {            //
            this.openFileDialog1.Title = @"Select the Bid Response excel file";
            this.openFileDialog1.ShowDialog();
            this.TxtFilepath.Text = this.openFileDialog1.FileName;

            string path = this.TxtFilepath.Text;
            trackedentityInstPayLoad =  xlReader.ReadBidResponse(path, "");
        }
    }
}
