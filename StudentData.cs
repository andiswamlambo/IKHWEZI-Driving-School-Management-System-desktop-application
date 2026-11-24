using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Driving_school_login_form
{
    public static class StudentData
    {
        // Student details
        public static string Name { get; set; } = "";
        public static string Surname { get; set; } = "";       // ADDED for DB
        public static string Email { get; set; } = "";
        public static string Phone { get; set; } = "";

        // Package details
        public static int PackageID { get; set; }              // ADDED for DB (Crucial)
        public static string PackageName { get; set; } = "";   // RENAMED from Package

        // Schedule details
        public static DateTime Date { get; set; } = DateTime.Today;
        public static string Time { get; set; } = "";
        public static int Duration { get; set; } = 60;

        // Vehicle & Instructor (Using DB identifiers)
        public static string VehicleID { get; set; } = "";         // RENAMED (e.g., "CA 321-654")
        public static string InstructorEmail { get; set; } = "";   // RENAMED (e.g., "demo@example.invalid")

        // Booking status
        public static string Status { get; set; } = "Pending";
        public static string Reference { get; set; } = "";

        // Holds the selected time slot button so confirm form can mark it as taken
        public static Button SelectedSlotButton { get; set; } = null;

        // All bookings history
        public static List<BookingRecord> AllBookings { get; set; } = new List<BookingRecord>();
        public static string LessonType { get; internal set; }

        // Call this when confirm is clicked
        public static void SaveBooking()
        {
            Reference = "IKH-" + DateTime.Now.ToString("yyyyMMddHHmmss");

            AllBookings.Add(new BookingRecord
            {
                Reference = Reference,
                Name = Name,
                Surname = Surname,
                Email = Email,
                Phone = Phone,
                PackageID = PackageID,
                PackageName = PackageName,
                Date = Date,
                Time = Time,
                Duration = Duration,
                VehicleID = VehicleID,
                InstructorEmail = InstructorEmail,
                Status = Status
            });
        }
    }

    public class BookingRecord
    {
        public string Reference { get; set; } = "";
        public string Name { get; set; } = "";
        public string Surname { get; set; } = "";           // ADDED
        public string Email { get; set; } = "";
        public string Phone { get; set; } = "";
        public int PackageID { get; set; }                  // ADDED
        public string PackageName { get; set; } = "";       // ADDED
        public DateTime Date { get; set; }
        public string Time { get; set; } = "";
        public int Duration { get; set; }
        public string VehicleID { get; set; } = "";         // RENAMED
        public string InstructorEmail { get; set; } = "";   // RENAMED
        public string Status { get; set; } = "";
    }
}