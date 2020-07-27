using System;

namespace MvvmApp.Helpers
{
    public class Commons
    {
        public static bool IsValidEmail(string email)
        {
            string[] parts = email.Split('@');
            if (parts.Length != 2) return false;
            return (parts[1].Split('.').Length >= 2);
        }

        public static int CalcAge(DateTime date)
        {
            int middle;
            DateTime now = DateTime.Now;
            if (now.Month <= date.Month && now.Day < date.Day)
                middle = now.Year - date.Year - 1; // 생일이 안지났으면
            else
                middle = now.Year - date.Year; // 생일이 지났으면

            return middle;
        }
    }
}
