using ToDoList.API.Models.Domain;

namespace ToDoList.API.Repositories
{
    public interface IRegionRepository
    {
        //get all regions
        
        Task<IEnumerable<Region>>GetAllAsync();
    }
}
