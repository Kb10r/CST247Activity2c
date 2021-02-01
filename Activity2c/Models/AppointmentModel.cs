using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Activity2c.Models
{
    public class AppointmentModel
    {
        [Required][StringLength(20, MinimumLength =4)]
        [DisplayName("Patients Full Name")]
        public string patientName { get; set; }

        [Required][DataType(DataType.DateTime)]
        [DisplayName("Date of the Appointment")]
        public DateTime appointmentDate { get; set; }

        [Required][DataType(DataType.Currency)]
        [DisplayName("Net Worth of patient")]
        public decimal patientNetWorth { get; set; }

        [Required]
        [DisplayName("Last Name of Doctor")]
        public string doctorName { get; set; }

        [Required][Range(minimum:5, maximum:10)]
        [DisplayName("How much pain are you currently in? 1(low) - 10(high)")]
        public int painLevel { get; set; }



    }
}
