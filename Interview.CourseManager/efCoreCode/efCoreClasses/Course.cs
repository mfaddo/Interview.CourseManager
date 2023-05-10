using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace Interview.CourseManager.efCoreCode.efCoreClasses
{
    public class Course
    {
        //TODO: fill your model here 
        public SportType sportType { get; set; }
        public List<ClubBranch> clubBranches { get; set; }
        public Academy? Academy { get; set; }
        public int ageFrom { get; set; }
        public int ageTo { get; set; }
        public string Gender { get; set; }
        public string Level { get; set; }
        public DateTime dayFrom { get; set; }
        public int Days { get; set; }
        public TimeOnly startTime{ get; set; }
        public int numberOfSessions { get; set; }
        public TimeOnly sessionDuration { get; set; }

        public string daysPerWeek { get; set; }
        public float CostForMember { get; set; }

       
    }
}
