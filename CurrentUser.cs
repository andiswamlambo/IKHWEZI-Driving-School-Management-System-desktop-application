using System;

namespace Driving_school_login_form
{
    public static class CurrentUser
    {
        // These properties hold the data for whoever logged in
        public static string Email { get; set; } = "";
        public static string Name { get; set; } = "";
        public static string Surname { get; set; } = "";
        public static string Role { get; set; } = ""; // "Instructor", "Receptionist", "Manager"

        // A helpful property that combines Name and Surname for greeting the user on forms
        public static string FullName
        {
            get { return $"{Name} {Surname}".Trim(); }
        }
        // NEW PROPERTY: Remembers which form to open after login
        public static string PendingFeature { get; set; } = "";
    }
}