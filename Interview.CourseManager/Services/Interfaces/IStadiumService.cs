using Interview.CourseManager.efCoreCode.efCoreClasses;

namespace Interview.CourseManager.Services.Interfaces
{
    public interface IStadiumService
    {
        Task<List<Stadium>> GetAll();
    }
}
