using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using static System.Console;
using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;
using Newtonsoft.Json;

/*
"firstName":"Ryan",
"lastName":"McIntosh",
"requestUrlPrefix":"956a257d-f4bc-4626-a00e-89f592ddca9b",
"hcmsClientId":"956a257d-f4bc-4626-a00e-89f592ddca9b",
"hcmsClientSecret":"f/hxeuePWGuz5HpJBMpsqIsyQmouMLqCGG2qbHJbMN0=",
"hcmsContentType":"ct956a257d-f4bc-4626-a00e-89f592ddca9b"
1)	Use https://interview.cpdv.ninja/{RequestPrefix}/api/help for API Details 
2)	Use {Client Id} and {Client Secret} together to retrieve a Bearer access_token from the https://interview.cpdv.ninja/{RequestPrefix}/api/Auth endpoint.
3)	Bearer Token is required to be in the header of all requests. Hint: make sure you don’t have any spaces at the front or end when testing in Swagger
*/

namespace CivicPlusGUIApp
{
    public partial class CivicPlusGUIApp : Form
    {
        private string accessToken = "";
        private bool connected = false;

        public CivicPlusGUIApp()
        {
            InitializeComponent();
            dtTmEnd.Value = DateTime.Today.AddDays(1);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            accessToken = getAcessToken();
        }

        private void btnGetEvents_Click(object sender, EventArgs e)
        {
            if (connected == false)
            {
                MessageBox.Show("Connect to the Swagger API first by clicking the \"Connect\" button.");
            }
            else
            {
                lstBxEvents.Items.Clear();
                char[] delimiterChars = { '[', ',' };
                string[] events = getEvents(accessToken).Split(delimiterChars);
                foreach (var ev in events)
                {
                    lstBxEvents.Items.Add(ev);
                }
            }
        }

        private void btnNewEvent_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int ID = rnd.Next(10, 1000);
            if (connected == false)
            {
                MessageBox.Show("Connect to the Swagger API first by clicking the \"Connect\" button.");
            }
            else if (DateTime.Compare(dtTmStart.Value, dtTmEnd.Value) == 0)
            {
                MessageBox.Show("The start date and the end date should not be the same.");
            }
            else if (DateTime.Compare(dtTmStart.Value, dtTmEnd.Value) > 0)
            {
                MessageBox.Show("The start date should come before the end date.");
            }
            else if (txtBxTitle.Text == "" || txtBxDescription.Text == "")
            {
                MessageBox.Show("Please fill in all values.");
            }
            else
            {
                createEvent(accessToken, ID, txtBxTitle.Text, txtBxDescription.Text, dtTmStart.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff'Z'"), dtTmEnd.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff'Z'"));
                lstBxEvents.Items.Clear();
                char[] delimiterChars = { '[', ',' };
                string[] events = getEvents(accessToken).Split(delimiterChars);
                foreach (var ev in events)
                {
                    lstBxEvents.Items.Add(ev);
                }
            }
        }

        public string getAcessToken()
        {
            string responseString = "";
            using (var client = new HttpClient())
            {
                var formContent = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("clientId", "956a257d-f4bc-4626-a00e-89f592ddca9b"),
                    new KeyValuePair<string, string>("clientSecret", "f/hxeuePWGuz5HpJBMpsqIsyQmouMLqCGG2qbHJbMN0=")
                });
                var response = client.PostAsync("https://interview.cpdv.ninja/956a257d-f4bc-4626-a00e-89f592ddca9b/api/Auth?clientId=956a257d-f4bc-4626-a00e-89f592ddca9b&clientSecret=f%2FhxeuePWGuz5HpJBMpsqIsyQmouMLqCGG2qbHJbMN0%3D", null).Result;
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = response.Content;
                    var autoCode = JObject.Parse(responseContent.ReadAsStringAsync().Result);
                    responseString = (string)autoCode["access_token"];
                    lbConnection.Text = "Connected";
                    connected = true;
                }
                else
                {
                    lbConnection.Text = "Connection failed";
                }
            }
            return responseString;
        }

        public string getEvents(string auth)
        {
            var client = new HttpClient();
            string eventsList = "No Events";
            using (var requestMessage = new HttpRequestMessage(HttpMethod.Get, "https://interview.cpdv.ninja/956a257d-f4bc-4626-a00e-89f592ddca9b/api/Events"))
            {
                requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", auth);
                var getEvents = client.SendAsync(requestMessage).Result;
                if (getEvents.IsSuccessStatusCode)
                {
                    var responseContent = getEvents.Content;
                    var autoCode = JObject.Parse(responseContent.ReadAsStringAsync().Result);
                    eventsList = autoCode.ToString();
                    WriteLine(eventsList);
                }
            }
            return eventsList;
        }

        public void createEvent(string auth, int id, string title, string description, string startDate, string endDate)
        {
            using (var client = new HttpClient())
            {
                WriteLine(startDate);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", auth);
                JObject postEvent = new JObject
                {
                    { "id", id },
                    { "title", title },
                    { "description", description },
                    { "startDate", startDate },
                    { "endDate", endDate }
                };
                var response = client.PostAsync("https://interview.cpdv.ninja/956a257d-f4bc-4626-a00e-89f592ddca9b/api/Events", new StringContent(JsonConvert.SerializeObject(postEvent), Encoding.UTF8, "application/json")).Result;
            }
        }
    }
}
