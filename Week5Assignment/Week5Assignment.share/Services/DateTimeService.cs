using System;
using Week5Assignment.share.Services.Interfaces;

namespace Week5Assignment.share.Services
{
    class DateTimeService : IDateTimeService
    {
        public DateTime Now()
        {
            return DateTime.Now;
        }
    }
}
