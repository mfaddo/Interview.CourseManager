using Interview.CourseManager.efCoreCode.efCoreClasses;

namespace Interview.CourseManager.Models
{
    public class CourseReservationModel
    {
        public DateTime Date { get; set; }
        public int timeInHour { get; set; }
        public Stadium Staduim { get; set; }
    }
}
