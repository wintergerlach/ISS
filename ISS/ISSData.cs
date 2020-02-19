using System;

namespace ISS
{
    class ISSData
    {
        //creates the variables for lat, long, time, city, country
        public string City { get; set; }
        public string Country { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public uint Timestamp { get; set; }
        public DateTime TimestampHumanReadable 
        {
            get
            {
                //converts from linux time to standard time
                DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(Timestamp);
                //converts it to
                DateTime dateTime = dateTimeOffset.LocalDateTime;
                //returns the date and time 
                return dateTime;
            }
        }

        //genertes the string that is outputed when object is printed
        public override string ToString()
        {
            return $"Date Time: {TimestampHumanReadable} Latitude: {Latitude} Longitude: {Longitude} City: {City} Country: {Country}";
        }
    }
}
