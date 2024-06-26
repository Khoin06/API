using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Extension
{
    public static class DateTimeExtensions
    {
        public static int CaculateAge(this DateTime dob)
        {
            var today = DateTime.Today;
            var age = today.Year - dob.Year;
            if(dob.Date >  today.AddYears(-age)) age--;
            return age;
        }
    }
}