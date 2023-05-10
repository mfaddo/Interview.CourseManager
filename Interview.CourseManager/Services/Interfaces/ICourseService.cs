using Interview.CourseManager.efCoreCode.efCoreClasses;
using Interview.CourseManager.Models;

namespace Interview.CourseManager.Services.Interfaces
{
    public interface ICourseService
    {
        Task<CourseReservation> addReservation(CourseReservationModel courseReservationModel);
    }
}
