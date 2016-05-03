using System;
using System.Globalization;

namespace PirateBackend.Models
{
    public class AcademicCalandar
    {
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public int AcademicCalandarId { get; set; }
        public string AcademicCalandarTitle { get; set; }
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public string AcademicCalandarDescription { get; set; }
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public DateTime AcademicCalandarDateTime { get; set; }
        public string Self
        {
            get
            {
                return string.Format(CultureInfo.CurrentCulture,
               "api/academicCalandar/{0}", AcademicCalandarId);
            }
            // ReSharper disable once ValueParameterNotUsed
            set { }
        }
    }
}
