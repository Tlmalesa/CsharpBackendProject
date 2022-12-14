

namespace ToDoList.API.Models.DTO
{
    public class Region
    {
        public Guid Id { get; set; }
        public string Code { get; set; }

        public string Name { get; set; }
        public double Area { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }

        public long population { get; set; }

        //Navigation property

        // public IEnumerable<Walk> Walks { get; set; }//one region can have multiple walks
    }
}
