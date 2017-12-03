/*
 * Created by Visual Stdio 2017.
 * User: Giang Thai
 * Date: 12/3/2017
 * Time: 1:37 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Text;
using System.Web;
using System.Windows.Forms;

namespace locate_on_GoogleMaps
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        #region
        public class AddressComponent
        {
            public string long_name { get; set; }
            public string short_name { get; set; }
            public List<string> types { get; set; }
        }

        public class Geometry
        {
            public Location location { get; set; }
            public Viewport viewport { get; set; }
            public string location_type { get; set; }
        }

        public class Location
        {
            public double lat { get; set; }
            public double lng { get; set; }
        }

        public class NorthEast
        {
            public double lat { get; set; }
            public double lng { get; set; }
        }

        public class Result
        {
            public List<AddressComponent> address_components { get; set; }
            public Geometry geometry { get; set; }
            public string formatted_address { get; set; }
            public string place_id { get; set; }
            public List<string> types { get; set; }
        }
        public class RootObject
        {
            // JSON of https://maps.googleapis.com/maps/api/geocode/json?address=
            public List<Result> results { get; set; }
            public string status { get; set; }

            // JSON of https://api.ipify.org/?format=json
            public string ip { get; set; }

            // JSON of
            public string country_code { get; set; }
            public string country_name { get; set; }
            public string region_code { get; set; }
            public string region_name { get; set; }
            public string city { get; set; }
            public string zip_code { get; set; }
            public string time_zone { get; set; }
            public string latitude { get; set; }
            public string longitude { get; set; }
            public int metro_code { get; set; }
        }

        public class SouthWest
        {
            public double lat { get; set; }
            public double lng { get; set; }
        }

        public class Viewport
        {
            public NorthEast northeast { get; set; }
            public SouthWest southwest { get; set; }
        }
        #endregion

        public MainForm()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            
            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            textBoxAddress.Enabled = false;
            textBoxLat.Enabled = false;
            textBoxLong.Enabled = false;
            buttonGET.Enabled = false;
            buttonOK.Enabled = false;

            GetTheLastestIE();
            this.webBrowser1.Navigate("http://maps.google.com/maps");
        }

        void GetTheLastestIE()
        {
            int BrowserVer, RegVal;
            
            // get the installed IE version
            using (WebBrowser Wb = new WebBrowser())
                BrowserVer = Wb.Version.Major;
            
            // set the appropriate IE version
            if (BrowserVer >= 11)
                RegVal = 11001;
            else if (BrowserVer == 10)
                RegVal = 10001;
            else if (BrowserVer == 9)
                RegVal = 9999;
            else if (BrowserVer == 8)
                RegVal = 8888;
            else
                RegVal = 7000;
            
            // set the actual key
            RegistryKey Key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", true);
            Key.SetValue(Process.GetCurrentProcess().ProcessName + ".exe", RegVal, RegistryValueKind.DWord);
            Key.Close();
            
            GetIPAddress(ref MyIP);
        }

        string MyIP = null;

        void GetIPAddress(ref string IPAddress)
        {
            // Get JSON from URL
            var json = new WebClient().DownloadString("https://api.ipify.org/?format=json");
            
            // Convert JSON to class
            RootObject r = JsonConvert.DeserializeObject<RootObject>(json);
            MyIP = r.ip;
            string GetIP = rBtnFromMyIP.Text += " " + MyIP;
            Console.WriteLine(GetIP);
        }

        string GetURL()
        {
            string temp = null;

            if (rBtnAddress.Checked == true)
            {
                string address = HttpUtility.UrlEncode(textBoxAddress.Text); // add using System.Web;
                temp = "http://maps.google.com/maps?q=" + address;
            }
            if (rBtnCoordinate.Checked == true)
            {
                string lat = textBoxLat.Text;
                string lng = textBoxLong.Text;
                temp = "http://maps.google.com/maps?q=" + lat + "%2C" + lng;
            }

            return temp;
        }

        void GetAddressFromCoordinate()
        {
            // get JSON from URL
            var json = new WebClient().DownloadString("https://maps.googleapis.com/maps/api/geocode/json?latlng=" + textBoxLat.Text + "," + textBoxLong.Text + "&key=AIzaSyB09Ew-QDwSo_iQha2A-opS6g3pdyERowo");

            // convert JSON to class
            RootObject r = JsonConvert.DeserializeObject<RootObject>(json);
            string temp = r.results[0].formatted_address;
            byte[] bytes = Encoding.Default.GetBytes(temp);
            temp = Encoding.UTF8.GetString(bytes);

            textBoxAddress.Text = temp;
        }

        void GetCoordinateFromAddress()
        {
            // get JSON from URL
            var json = new WebClient().DownloadString("https://maps.googleapis.com/maps/api/geocode/json?address=" + textBoxAddress.Text + "&key=AIzaSyB09Ew-QDwSo_iQha2A-opS6g3pdyERowo");

            // convert JSON to class
            RootObject r = JsonConvert.DeserializeObject<RootObject>(json);
            textBoxLat.Text = r.results[0].geometry.location.lat.ToString();
            textBoxLong.Text = r.results[0].geometry.location.lng.ToString();
        }

        void GetCoordinateFromMyIP()
        {
            // get JSON from URL
            var json = new WebClient().DownloadString("http://freegeoip.net/json/" + MyIP);

            // convert JSON to class
            RootObject r = JsonConvert.DeserializeObject<RootObject>(json);
            textBoxLat.Text = r.latitude;
            textBoxLong.Text = r.longitude;
            Console.WriteLine(r.latitude);
            Console.WriteLine(r.longitude);
        }

        private void rBtnAddress_CheckedChanged(object sender, EventArgs e)
        {
            textBoxAddress.Enabled = true;
            textBoxLat.Enabled = false;
            textBoxLong.Enabled = false;

            buttonGET.Enabled = false;
            buttonOK.Enabled = true;
        }

        private void rBtnCoordinate_CheckedChanged(object sender, EventArgs e)
        {
            textBoxAddress.Enabled = false;
            textBoxLat.Enabled = true;
            textBoxLong.Enabled = true;

            buttonGET.Enabled = false;
            buttonOK.Enabled = true;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate(GetURL());
        }

        private void rBtnFromAddress_CheckedChanged(object sender, EventArgs e)
        {
            buttonGET.Enabled = true;
            buttonOK.Enabled = false;
        }

        private void rBtnFromCoordinate_CheckedChanged(object sender, EventArgs e)
        {
            buttonGET.Enabled = true;
            buttonOK.Enabled = false;
        }

        private void rBtnFromMyIP_CheckedChanged(object sender, EventArgs e)
        {
            buttonGET.Enabled = true;
            buttonOK.Enabled = false;
        }

        private void buttonGET_Click(object sender, EventArgs e)
        {
            if (rBtnFromAddress.Checked == true)
                GetCoordinateFromAddress();
            if (rBtnFromCoordinate.Checked == true)
                GetAddressFromCoordinate();
            if (rBtnFromMyIP.Checked == true)
                GetCoordinateFromMyIP();
        }
    }
}
