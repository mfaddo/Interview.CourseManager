using Interview.CourseManager.efCoreCode;
using Interview.CourseManager.efCoreCode.efCoreClasses;
using Interview.CourseManager.Models;
using Interview.CourseManager.Services.Interfaces;

namespace Interview.CourseManager.Services.Implementations
{
    public class CourseService : ICourseService
    {
        private readonly ApplicationDbContext _applicationDbContext;

        //TODO fill your service Implementation Here...
        public CourseService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public async Task<CourseReservation> add(CourseReservationModel courseReservationModel)
        {
           var courseReservation  = new CourseReservation();
            courseReservation.timeInHour=courseReservationModel.timeInHour;
            courseReservation.Staduim = courseReservationModel.Staduim;
            courseReservation.Date=courseReservationModel.Date;

            //get day reservation
          var reservations=  _applicationDbContext.courseReservations
                .Where(r => r.Staduim.Id == courseReservationModel.Staduim.Id && 
                r.Date.Date == courseReservationModel.Date.Date);
            if (reservations == null)
            {
               await _applicationDbContext.AddAsync(courseReservation);
                courseReservation.Status = "Success";
                return courseReservation;
            }

            foreach (var reservation in reservations)
            {
                if(reservation.Date.Hour > courseReservationModel.Date.Hour)
                {
                    var timeinHourWhenNewReservationwillFinished =
                        courseReservationModel.timeInHour + courseReservationModel.Date.Hour;

                    if(timeinHourWhenNewReservationwillFinished < reservation.Date.Hour)
                    {
                        await _applicationDbContext.AddAsync(courseReservation);
                        courseReservation.Status = "Success";
                        return courseReservation;
                    }
                    else
                    {
                        courseReservation.Status = "Failed";
                        return courseReservation;
                    }
                }

                if (reservation.Date.Hour < courseReservationModel.Date.Hour)
                {
                    var timeinHourWhenOldReservationwillFinishes =
                       reservation.timeInHour + reservation.Date.Hour;

                    if (timeinHourWhenOldReservationwillFinishes > reservation.Date.Hour)
                    { 
                        await _applicationDbContext.AddAsync(courseReservation);
                        courseReservation.Status = "Success";
                        return courseReservation;
                    }
                
                    else
                    {
                        courseReservation.Status = "Failed";
                        return courseReservation;
                    }
                }

                if (reservation.Date.Hour == courseReservationModel.Date.Hour)
                {
                     courseReservation.Status = "Failed";
                    return courseReservation;
                }
            }
            await _applicationDbContext.AddAsync(courseReservation);
            courseReservation.Status = "Success";
            return courseReservation;
        }
    }
}
