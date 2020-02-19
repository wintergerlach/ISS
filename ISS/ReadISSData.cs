using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace ISS
{
    class ReadISSData
    {
        //serializes the list of readings
        public static void Serialize(List<ISSData> ISSReadings)
        {
            //sets the path of the file to a string variable
            string path = @"C:\Intel\savedreadings.txt";
            //checks if file does not exsist
            if (!File.Exists(path))
            {
                //creates the file
                TextWriter writer = new StreamWriter(path);
                //converts the readings to json code
                string output = JsonConvert.SerializeObject(ISSReadings);
                //writes the json to the file and closes the file
                writer.Write(output);
                writer.Close();
            }
            //if file exsits
            else
            {
                //creates a stream writer that can overwrite data
                StreamWriter newTask = new StreamWriter(path, false);
                //converts the list to json
                string output = JsonConvert.SerializeObject(ISSReadings);
                //writes the json to the file and closes the file
                newTask.Write(output);
                newTask.Close();
            }
        }

        //deserializes the data and places the data in a list
        public static void Deserialize(ref List<ISSData> ISSReadings)
        {
            //checks if the file exsists
            if (File.Exists(@"C:\Intel\savedreadings.txt"))
            {
                //reads the file and places it in a string
                string jsonReading = File.ReadAllText(@"C:\Intel\savedreadings.txt");
                //converts the json to ISSReadings
                ISSReadings = JsonConvert.DeserializeObject<List<ISSData>>(jsonReading);
            }
        }
    }
}