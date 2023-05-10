namespace Interview.CourseManager.efCoreCode.efCoreClasses
{
    public class CourseReservation
    {
        //TODO: fill your model here 
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }
        public Staduim Staduim { get; set; }
        public string Status { get; set; }
    }
}