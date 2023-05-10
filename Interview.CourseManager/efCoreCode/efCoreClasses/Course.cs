using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Interview.CourseManager.efCoreCode.efCoreClasses
{
    public class Course
    {
        //TODO: fill your model here 
        public int id { get; set; }
        public SportType sportType { get; set; }
        public List<ClubBranch> clubBranches { get; set; }
        public Academy? Academy { get; set; }
        public int ageFrom { get; set; }
        public int ageTo { get; set; }
        public string Gender { get; set; }
        public string Level { get; set; }
        public DateTime dayFrom { get; set; }
        public int Days { get; set; }
        public DateTime startTime{ get; set; }
        public int numberOfSessions { get; set; }
    
        public int sessionDurationInHours { get; set; }

        public string daysPerWeek { get; set; }
        public float CostForMember { get; set; }

        public string Status { get; set; }
    }
}
