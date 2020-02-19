using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace ISS
{
    public partial class ISSForm : Form
    {
        //creates a list of the ISS location readings
        private List<ISSData> ISSReadings = new List<ISSData>();
        public ISSForm()
        {
            InitializeComponent();
        }

        //creates button that gets the ISS locations
        private void buttonGetISSReading_Click(object sender, EventArgs e)
        {
            try
            { 
                //creates a new reading object of class ISS Data
                var reading = new ISSData();
                //creates a webClient to acces the api
                var web2 = new WebClient();
                //puts the data from the api into a variable
                var data2 = web2.DownloadString($"http://api.open-notify.org/iss-now.json");
                //creates a json object to parse the data from the api to
                dynamic jsonObject2 = JValue.Parse(data2);
                //sets the latitude from the json object to the latitiude variable
                reading.Latitude = jsonObject2.iss_position.latitude;
                //sets the longitude from the json object to the longitude variable
                reading.Longitude = jsonObject2.iss_position.longitude;
                //sets the time stamp from the json object to the timestamp variable
                reading.Timestamp = jsonObject2.timestamp;
                try
                {
                    //creates a variable called location to store the api data in
                    var location = web2.DownloadString($"https://api.opencagedata.com/geocode/v1/json?q={reading.Latitude}+{reading.Longitude}&key=fa7039b164dc44559bcdc14e5e05dc7d");
                    //creates a variable to hold the parsed json data from the api data
                    dynamic jsonObject3 = JValue.Parse(location);
                    //checks if there is a city location
                    if (jsonObject3.results[0].components.city != null)
                    {
                        //sets city variable to the city data
                        reading.City = jsonObject3.results[0].components.city;
                        //sets country variable to the country data
                        reading.Country = jsonObject3.results[0].components.country;
                        //outputs a message box with the city and country
                        MessageBox.Show($"The ISS is currently above {reading.City} which is located in the {reading.Country}.");
                    }
                    //if there is no city data
                    else
                    {
                        //sets city and country to the ocean
                        reading.City = "Ocean";
                        reading.Country = "Ocean";
                        //outputs a message box stating the ISS is over the ocean
                        MessageBox.Show($"The ISS is currently over the ocean. Latitude: {reading.Latitude}, Longitude: {reading.Longitude}.");
                    }
                }
                //if the api cannot be called
                catch
                {
                    //sets the city and country as not found
                    reading.City = "Not Found";
                    reading.Country = "Not Found";
                    //prints out the lat and long of the ISS
                    MessageBox.Show($"The ISS is at {reading.Latitude}, {reading.Longitude}.");
                }
                //adds the reading to the list of readings
                ISSReadings.Add(reading);
                //adds the reading to the list box
                lstISSLocations.Items.Add(reading);
                //serializes (saves) the list of readings
                ReadISSData.Serialize(ISSReadings);
            }
            //if the api cannot be called
            catch
            {
                //outputs a message box saying it can't be located
                MessageBox.Show("The ISS cannot be located right now. Please try again later.");
            }
        }

        //on load of form 
        private void Form1_Load(object sender, EventArgs e)
        { 
            //desearializes the data 
            ReadISSData.Deserialize(ref ISSReadings);
            //adds each item in the list ISSReadings to the list box
            foreach(var read in ISSReadings)
            {
                lstISSLocations.Items.Add(read);
            }
            //calls the api for the background image
            try
            {
                //creates a web client to call the api
                var web = new WebClient();
                //gets the data from the api
                var data = web.DownloadString("https://api.nasa.gov/planetary/apod?api_key=ZELiVKhzVk7VDulcvgUGaI7z4bbEcdobVbFzc9xb");
                //parses the data from the api
                dynamic jsonObject = JValue.Parse(data);
                //sets the image of  an image box the size of the form to the image url from the api
                picBackgroundImage.ImageLocation = jsonObject.url;
            }
            //if the api cannot be called
            catch
            {
                //message box stating no image
                MessageBox.Show("Background image not available");
            }
        }
    }
}
