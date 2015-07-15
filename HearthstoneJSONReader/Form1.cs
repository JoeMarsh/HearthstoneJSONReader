using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net;
using Newtonsoft.Json;


namespace HearthstoneJSONReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //using (var webClient = new System.Net.WebClient())
            //{
            //    var json = webClient.DownloadString("");

            //    // Now parse with JSON.Net

            //}

            var url = "http://hearthstonejson.com/json/AllSets.json";
            var allCardData = _download_serialized_json_data<HearthstoneJSONReaderData.Rootobject>(url);
            HearthstoneJSONReaderData.Basic[] basicSet = allCardData.Basic;

            foreach (var item in basicSet)
            {
                if (item.name == "Fireball")
                {
                    textBox1.Text = item.artist;
                }
            }
            

            //WebClient webClient = new WebClient();
            //var data = webClient.DownloadString("http://hearthstonejson.com/json/AllSets.json");
            //MessageBox.Show(data);
        }

        private static T _download_serialized_json_data<T>(string url) where T : new()
        {
            using (var w = new WebClient())
            {
                var json_data = string.Empty;
                // attempt to download JSON data as a string
                try
                {
                    json_data = w.DownloadString(url);
                }
                catch (Exception) { }
                // if string with JSON data is not empty, deserialize it to class and return its instance 
                return !string.IsNullOrEmpty(json_data) ? JsonConvert.DeserializeObject<T>(json_data) : new T();
            }
        }
    }
}
