using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlazorDemos.Pages.Grid
{
    public sealed class BusinessHours : ValidationAttribute
    {
        protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
        {
            if (value != null && value is DateTime dateTime)
            {
                if (dateTime.Hour >= 8 && dateTime.Hour < 20)
                {
                    return ValidationResult.Success!;
                }
                return new ValidationResult("Time must be 8 AM to 8 PM.");
            }
            return new ValidationResult("Invalid date/time value.");
        }
    }

    public enum AppointmentType
    {
        Consultation,
        FollowUp,
        LabTest,
        Emergency,
        RoutineCheck
    }

    public enum AppointmentStatus
    {
        Booked,
        Pending,
        Completed,
        Canceled
    }

    public class AppointmentData
    {
        public int AppointmentID { get; set; }

        [Required(ErrorMessage = "Patient Name is required.")]
        public string? PatientName { get; set; }

        [Required]
        [MinLength(10, ErrorMessage = "Phone number must be at least 10 characters.")]
        [MaxLength(10, ErrorMessage = "Phone number must be exactly 10 characters.")]

        public string? PatientPhone { get; set; }

        [Required]
        public string? Doctor { get; set; }

        [Required]
        [BusinessHours]
        public DateTime AppointmentTime { get; set; }

        [Required]
        public AppointmentType AppointmentType { get; set; }

        [Required]
        public AppointmentStatus Status { get; set; }

        [Required]
        [Range(200, 1500, ErrorMessage = "Please enter a value between 200 and 1500")]
        public decimal Fee { get; set; }

        public string? Notes { get; set; }

        public static IReadOnlyList<string> Doctors { get; } = new[]
        {
            "Dr. Martinez",
            "Dr. Smith",
            "Dr. Garcia",
            "Dr. Brianna",
            "Dr. Davis",
            "Dr. Johnson",
            "Dr. Williams"
        };

        public static IReadOnlyList<AppointmentData> GetAppointmentData()
        {
            return new List<AppointmentData>
            {
                new AppointmentData { AppointmentID = 2001, PatientName = "John Miller", PatientPhone = "5551234567", Doctor = "Dr. Martinez", AppointmentTime = new DateTime(2026, 8, 14, 8, 30, 0), AppointmentType = AppointmentType.Consultation, Status = AppointmentStatus.Booked, Fee = 750.00m, Notes = "Annual health checkup" },
                new AppointmentData { AppointmentID = 2002, PatientName = "Emma Wilson", PatientPhone = "5552345678", Doctor = "Dr. Smith", AppointmentTime = new DateTime(2026, 8, 14, 9, 00, 0), AppointmentType = AppointmentType.FollowUp, Status = AppointmentStatus.Pending, Fee = 600.00m, Notes = "Post-surgical follow-up review" },
                new AppointmentData { AppointmentID = 2003, PatientName = "Liam Davis", PatientPhone = "5553456789", Doctor = "Dr. Garcia", AppointmentTime = new DateTime(2026, 8, 14, 10, 00, 0), AppointmentType = AppointmentType.LabTest, Status = AppointmentStatus.Completed, Fee = 450.00m, Notes = "Comprehensive blood work analysis" },
                new AppointmentData { AppointmentID = 2004, PatientName = "Olivia Brown", PatientPhone = "5554567890", Doctor = "Dr. Brianna", AppointmentTime = new DateTime(2026, 8, 14, 10, 45, 0), AppointmentType = AppointmentType.RoutineCheck, Status = AppointmentStatus.Canceled, Fee = 250.00m, Notes = "Rescheduling requested by patient" },
                new AppointmentData { AppointmentID = 2005, PatientName = "Noah Taylor", PatientPhone = "5555678901", Doctor = "Dr. Davis", AppointmentTime = new DateTime(2026, 8, 14, 11, 30, 0), AppointmentType = AppointmentType.Emergency, Status = AppointmentStatus.Booked, Fee = 350.00m, Notes = "Pediatric acute respiratory assessment" },
                new AppointmentData { AppointmentID = 2006, PatientName = "Ava Anderson", PatientPhone = "5556789012", Doctor = "Dr. Johnson", AppointmentTime = new DateTime(2026, 8, 14, 12, 30, 0), AppointmentType = AppointmentType.Consultation, Status = AppointmentStatus.Completed, Fee = 850.00m, Notes = "Cardiovascular risk assessment consultation" },
                new AppointmentData { AppointmentID = 2007, PatientName = "James Thomas", PatientPhone = "5557890123", Doctor = "Dr. Williams", AppointmentTime = new DateTime(2026, 8, 14, 13, 00, 0), AppointmentType = AppointmentType.FollowUp, Status = AppointmentStatus.Pending, Fee = 700.00m, Notes = "Diabetes management follow-up visit" },
                new AppointmentData { AppointmentID = 2008, PatientName = "Sophia Jackson", PatientPhone = "5558901234", Doctor = "Dr. Martinez", AppointmentTime = new DateTime(2026, 8, 14, 14, 00, 0), AppointmentType = AppointmentType.LabTest, Status = AppointmentStatus.Booked, Fee = 420.00m, Notes = "Comprehensive allergy panel assessment" },
                new AppointmentData { AppointmentID = 2009, PatientName = "Lucas White", PatientPhone = "5559012345", Doctor = "Dr. Smith", AppointmentTime = new DateTime(2026, 8, 14, 14, 30, 0), AppointmentType = AppointmentType.RoutineCheck, Status = AppointmentStatus.Completed, Fee = 550.00m, Notes = "Preventive health screening program" },
                new AppointmentData { AppointmentID = 2010, PatientName = "Mia Harris", PatientPhone = "5550123456", Doctor = "Dr. Garcia", AppointmentTime = new DateTime(2026, 8, 14, 15, 00, 0), AppointmentType = AppointmentType.Emergency, Status = AppointmentStatus.Canceled, Fee = 280.00m, Notes = "Pediatric fever and cough evaluation" },
                new AppointmentData { AppointmentID = 2011, PatientName = "Ethan Martin", PatientPhone = "5551235674", Doctor = "Dr. Brianna", AppointmentTime = new DateTime(2026, 8, 14, 15, 30, 0), AppointmentType = AppointmentType.Consultation, Status = AppointmentStatus.Pending, Fee = 900.00m, Notes = "Dermatological skin condition consultation" },
                new AppointmentData { AppointmentID = 2012, PatientName = "Amelia Thompson", PatientPhone = "5552345679", Doctor = "Dr. Davis", AppointmentTime = new DateTime(2026, 8, 14, 16, 00, 0), AppointmentType = AppointmentType.FollowUp, Status = AppointmentStatus.Booked, Fee = 650.00m, Notes = "Post-treatment recovery evaluation session" },
                new AppointmentData { AppointmentID = 2013, PatientName = "Daniel Garcia", PatientPhone = "5553456781", Doctor = "Dr. Johnson", AppointmentTime = new DateTime(2026, 8, 14, 16, 30, 0), AppointmentType = AppointmentType.LabTest, Status = AppointmentStatus.Completed, Fee = 1450.00m, Notes = "Lipid profile and cholesterol panel analysis" },
                new AppointmentData { AppointmentID = 2014, PatientName = "Harper Martinez", PatientPhone = "5554567892", Doctor = "Dr. Williams", AppointmentTime = new DateTime(2026, 8, 14, 17, 00, 0), AppointmentType = AppointmentType.RoutineCheck, Status = AppointmentStatus.Pending, Fee = 400.00m, Notes = "Adolescent health and development screening" },
                new AppointmentData { AppointmentID = 2015, PatientName = "Henry Robinson", PatientPhone = "5555678902", Doctor = "Dr. Martinez", AppointmentTime = new DateTime(2026, 8, 14, 9, 30, 0), AppointmentType = AppointmentType.Consultation, Status = AppointmentStatus.Booked, Fee = 800.00m, Notes = "Sports medicine and injury rehabilitation assessment" },
                new AppointmentData { AppointmentID = 2016, PatientName = "Ella Clark", PatientPhone = "5556789013", Doctor = "Dr. Smith", AppointmentTime = new DateTime(2026, 8, 14, 11, 00, 0), AppointmentType = AppointmentType.Emergency, Status = AppointmentStatus.Completed, Fee = 1200.00m, Notes = "Acute cardiac event urgent evaluation" },
                new AppointmentData { AppointmentID = 2017, PatientName = "Alexander Rodriguez", PatientPhone = "5557890124", Doctor = "Dr. Garcia", AppointmentTime = new DateTime(2026, 8, 14, 13, 30, 0), AppointmentType = AppointmentType.FollowUp, Status = AppointmentStatus.Canceled, Fee = 320.00m, Notes = "Rescheduled due to travel conflict" },
                new AppointmentData { AppointmentID = 2018, PatientName = "Grace Lewis", PatientPhone = "5558901235", Doctor = "Dr. Brianna", AppointmentTime = new DateTime(2026, 8, 14, 8, 00, 0), AppointmentType = AppointmentType.LabTest, Status = AppointmentStatus.Pending, Fee = 530.00m, Notes = "Thyroid function test and hormone analysis" },
                new AppointmentData { AppointmentID = 2019, PatientName = "Michael Lee", PatientPhone = "5559012346", Doctor = "Dr. Davis", AppointmentTime = new DateTime(2026, 8, 14, 12, 00, 0), AppointmentType = AppointmentType.RoutineCheck, Status = AppointmentStatus.Booked, Fee = 550.00m, Notes = "Hypertension and blood pressure monitoring" },
                new AppointmentData { AppointmentID = 2020, PatientName = "Chloe Walker", PatientPhone = "5550123457", Doctor = "Dr. Johnson", AppointmentTime = new DateTime(2026, 8, 14, 17, 30, 0), AppointmentType = AppointmentType.Consultation, Status = AppointmentStatus.Completed, Fee = 950.00m, Notes = "Migraine and tension headache management consultation" }
            };
        }
    }
}