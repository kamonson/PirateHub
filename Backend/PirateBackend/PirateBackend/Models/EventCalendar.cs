using System;
using System.Globalization;

namespace PirateBackend.Models
{
    public class EventCalandar
    {
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public int EventCalandarId { get; set; }
        public string EventCalandarTitle { get; set; }
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public string EventCalandarLocation { get; set; }
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public string EventCalandarDescription { get; set; }
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public DateTime EventCalandarDateTime { get; set; }
        public string Self
        {
            get
            {
                return string.Format(CultureInfo.CurrentCulture,
               "api/eventCalandar/{0}", EventCalandarId);
            }
            // ReSharper disable once ValueParameterNotUsed
            set { }
        }
    }
}
