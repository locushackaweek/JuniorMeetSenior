using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HackathonApp.Models
{
    public class CaseReport
    {
        public int Id { get; set; }
        public string PatientId { get; set; }
        public MedicalIssue MedicalIssue { get; set; }
        public string Weight { get; set; }
        public string Height { get; set; }
        public decimal BodyTemperature { get; set; }
        public string PulseRate { get; set; }
        public string RespirationRate { get; set; }
        public string BloodPressure { get; set; }
        public string SymptomDescription { get; set; }
        public int? PatientImagesId { get; set; }
        public int? OtherReportsId { get; set; }
    }

    public enum MedicalIssue {

    }
    public enum Sex {
        Male=1,
        Female =2,
        Other = 3
    }
}