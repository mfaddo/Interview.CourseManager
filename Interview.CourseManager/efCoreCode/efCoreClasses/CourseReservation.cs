using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Interview.CourseManager.efCoreCode.efCoreClasses
{
    public class CourseReservation
    {
        //TODO: fill your model here 
        public int id { get; set; }

        public DateTime Date { get; set; }

      
        public int timeInHour { get; set; }
        public Staduim Staduim { get; set; }
        public string Status { get; set; }
    }
}