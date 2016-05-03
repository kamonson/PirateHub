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
        public string AcademicCalandarTitle { get; set; }
        public string AcademicCalandarDescription { get; set; }
        public DateTime AcademicCalandarDateTime { get; set; }
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
