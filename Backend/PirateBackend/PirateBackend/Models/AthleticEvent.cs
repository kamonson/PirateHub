using System;
using System.Globalization;

namespace PirateBackend.Models
{
    public class AthleticEvent
    {
        public int AthleticEventId { get; set; }
        public string AthleticEventType { get; set; }
        public string AthleticEventDescription { get; set; }
        public DateTime AthleticEventDateTime { get; set; }
        public string AthleticEventLocation { get; set; }
        public string AthleticEventOpponent { get; set; }
        public string Self
        {
            get
            {
                return string.Format(CultureInfo.CurrentCulture,
               "api/athleticEvent/{0}", AthleticEventId);
            }
            // ReSharper disable once ValueParameterNotUsed
            set { }
        }
    }
}
