using System;
using System.ComponentModel.DataAnnotations;

namespace Week5Assignment.domain.Entities
{
    public class ErrorLog
    {
        [Key]
        public int ID { get; set; }
        public DateTime ErrorDateTime { get; set; }
        public string ErrorMessage { get; set; }
        public string StackTrace { get; set; }

    }
}
