using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NZWalks.api.Models.Domain;
using NZWalks.api.Repository;

namespace NZWalks.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegionsController : Controller
    {
        private readonly IRegionRepository regionRepository;
        private readonly IMapper mapper;

        public RegionsController(IRegionRepository regionRepository, IMapper mapper)
        {
            this.regionRepository = regionRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllRegions()
        {



            var regions = regionRepository.GetAll();

            //return Data DTO 

            //var regionsDTO = new List<Models.DTO.Region>();

            //regions.ToList().ForEach(region =>
            //{
            //    var regionDTO = new Models.DTO.Region()
            //    {
            //        Id = region.Id,
            //        Code = region.Code,
            //        Name = region.Name,
            //        Area = region.Area,
            //        Let = region.Let,
            //        Long = region.Long,
            //        Population = region.Population

            //    };


            //    regionsDTO.Add(regionDTO);

            //var regionDTO = new List<Models.DTO.Region>();
            //{
            //    Id = region.Id;
            //    regionDTO.code = region.code
            //     regionDTO.name = region.name
            //    regionDTO.area = region.area
            //    regionDTO.let = region.let
            //    regionDTO. long= region.long
            //    regionDTO.population = region.population
            //    regionDTO.walks = region.walks




            //};

            //});

            //var regions = new List<Region>()
            //{
            //    new Region
            //    {
            //        Id = Guid.NewGuid(),
            //        Name = "BIhar",
            //        Code = "BR",
            //        Area = 4221111,
            //        Let = 1.8822,
            //        Long = 299.88,
            //        Population = 50000



            //    },
            //    new Region
            //    {
            //        Id = Guid.NewGuid(),
            //        Name = "JHARKHAND",
            //        Code = "JH",
            //        Area = 5545454,
            //        Let = 2.8822,
            //        Long = 299.77,
            //        Population = 250000



            //    }


            //};
            var regionDTO = mapper.Map<List<Models.DTO.Region>>(regions);

            return Ok(regionDTO);
        }
    }
}
