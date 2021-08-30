using System;

namespace API.Extensions
{
    public static class DateTimeExtensions
    {
        public static int CalculateAge(this DateTime dob)
        {
            DateTime today = DateTime.Today;
            return (int)today.Subtract(dob).TotalDays / 365;

        }
    }
}
