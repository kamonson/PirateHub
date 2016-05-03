using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirateBackend.Models
{
    public class EventCalandar
    {
        public int EventCalandarId { get; set; }
        public string EventCalandarTitle { get; set; }
        public string EventCalandarLocation { get; set; }
        public string EventCalandarDescription { get; set; }
        public DateTime EventCalandarDateTime { get; set; }
        public string Self
        {
            get
            {
                return string.Format(CultureInfo.CurrentCulture,
               "api/eventCalandar/{0}", this.EventCalandarId);
            }
            set { }
        }
    }
}
