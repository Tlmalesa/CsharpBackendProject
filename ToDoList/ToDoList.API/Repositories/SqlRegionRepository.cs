using Microsoft.EntityFrameworkCore;
using ToDoList.API.Data;
using ToDoList.API.Models.Domain;

namespace ToDoList.API.Repositories
{
  
    public class SqlRegionRepository:IRegionRepository
    {
        private readonly ToDoListDbContext toDoListDbContext;
        public SqlRegionRepository(ToDoListDbContext toDoListDbContext)
        {
            this.toDoListDbContext = toDoListDbContext;
        }
        ////make a function asychronous
        public async Task<IEnumerable<Region> > GetAllAsync()
        {
           return await toDoListDbContext.Regions.ToListAsync();
        }
    }

   
}
