using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirateBackend.Models
{
    public class AcademicCalandar
    {
        public int AcademicCalandarId { get; set; }
        public string AcademicCalandarTytle { get; set; }
        public string AthleticEventDescription { get; set; }
        public DateTime AthleticEventDateTime { get; set; }
        public string Self
        {
            get
            {
                return string.Format(CultureInfo.CurrentCulture,
               "api/academicCalandar/{0}", this.AcademicCalandarId);
            }
            set { }
        }
    }
}
