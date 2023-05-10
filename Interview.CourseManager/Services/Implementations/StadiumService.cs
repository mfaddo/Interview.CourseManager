using Interview.CourseManager.efCoreCode;
using Interview.CourseManager.efCoreCode.efCoreClasses;
using Interview.CourseManager.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Interview.CourseManager.Services.Implementations
{
    public class StadiumService : IStadiumService
    {
        
        private readonly ApplicationDbContext _applicationDbContext;

        public StadiumService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<List<Stadium>> GetAll()
        {
            return await  _applicationDbContext.Stdiums.ToListAsync();
          
        }
    }
    
}
