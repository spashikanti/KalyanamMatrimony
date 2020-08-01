namespace KalyanamMatrimony.Models
{
    public static class CustomEnums
    {
        public enum Dept
        {
            HR,
            IT,
            Admin
        }

        public enum CustomRole
        {
            SuperAdmin = 1,
            Admin = 2,
            AdminAssistant = 3,
            Profile = 4
        }

        public enum ProfileGender
        {
            None = 0,
            Male,
            Female
        }

        public enum ToastType
        {
            Info,
            Warning,
            Error,
            Success
        }

        public enum LicenseType
        {
            Free,
            Paid
        }

        public enum OrgType
        {
            Shared,
            Individual
        }
    }
}
