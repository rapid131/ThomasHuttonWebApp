using System.Diagnostics;

namespace ThomasHuttonWebApp.Components.Classes
{
    public class Forecast
    {
        public Location location { get; set; }
        public Current current { get; set; }

        public class Location
        {
            public string name { get; set; }
            public string country { get; set; }
            public string region { get; set; }
        }

        public class Current
        {
            public float temp_f { get; set; }
            public Condition condition { get; set; }
        }
        public class Condition
        {
            public string text  { get; set; }
            public string icon { get; set; }
        }
    }
}

