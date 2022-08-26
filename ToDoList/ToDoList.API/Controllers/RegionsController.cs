using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ToDoList.API.Models.Domain;
using ToDoList.API.Repositories;

namespace ToDoList.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegionsController : Controller
    {
        private readonly IRegionRepository regionRepository;
        private readonly IMapper mapper;
        public RegionsController(IRegionRepository regionRepository,IMapper mapper)
        {
            this.regionRepository = regionRepository;
            this.mapper = mapper;
        }
       
        //get all regions
        [HttpGet]
       public async Task<IActionResult> GetAllRegions()
        {
            //Getting data from database
           var regions= await regionRepository.GetAllAsync();

            //auto mapping

            //exports the DTO regions
            //var regionsDTO = new List<Models.DTO.Region>();
            //regions.ToList().ForEach(region =>
            //{
            //   var regionDTO = new Models.DTO.Region()
            //    {
            //       Id=region.Id,
            //       Code=region.Code,
            //       Name=region.Name,
            //       Area=region.Area,
            //       Lat=region.Lat,
            //       Long=region.Long,
            //       population=region.population,
            //    };
            //    regionsDTO.Add(regionDTO);
            //});
            //var regions = new List<Region>()
            //{
            //    new Region
            //    {
            //     Id=Guid.NewGuid(),
            //     Name="Wellington",
            //     Code="WLG",
            //     Area=1234,
            //     Lat=-1.8822,
            //     Long=299.88,
            //     population=100000

            //    },
            //    new Region
            //    {
            //     Id=Guid.NewGuid(),
            //     Name="Auckland",
            //     Code="AUCK",
            //     Area=1234,
            //     Lat=-1.8822,
            //     Long=299.88,
            //     population=100000

            //    }

            //};

            //mapping region from domain model back to the DTO and pass back to the client
           var regionsDTO= mapper.Map<List<Models.DTO.Region>>(regions);
            return Ok(regionsDTO);
        }
    }
}
