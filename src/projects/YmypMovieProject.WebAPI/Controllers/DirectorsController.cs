using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using YmypMovieProject.Business.Abstract;
using YmypMovieProject.Entity.Dtos.Directors;
using YmypMovieProject.Entity.Entities;
namespace YmypMovieProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectorsController : ControllerBase
    {
        private readonly IDirectorService _directorService;
        private readonly IMapper _mapper;
        

        public DirectorsController(IDirectorService directorService, IMapper mapper)
        {
            _directorService = directorService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _directorService.GetAll(false);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Data);

            //var directors = _directorService.GetAll();
            //return Ok(directors);
        }

        [HttpGet("[action]")]
        public IActionResult GetAllDeleted()
        {
            var result = _directorService.GetAll(true);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Data);

            //var directors = _directorService.GetAll();
            //return Ok(directors);
        }

        [HttpGet("FullInfo")]
        public IActionResult GetFullInfo()
        {
            var result = _directorService.GetAllFullInfo();
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Data);
        }
        [HttpGet("{id}")]
        public IActionResult GetDirector(Guid id)
        {
            var result = _directorService.GetById(id);

            if (!result.Success)
            {
                return NotFound(result.Message);
            }
            return Ok(result.Data);

            //var director = _directorService.GetById(Guid.Parse(id));
            //return Ok();
        }
        [HttpGet("GetAllIsActive")]
        public IActionResult GetAllIsActive()
        {
            //var directors = _directorService.GetByIsActive();
            //var dto = directors.Select(d => new
            //{
            //    d.Id,
            //    d.FirstName,
            //    d.LastName,
            //    d.ImageUrl,
            //    d.BirthDate,
            //    d.Description,
            //    Fimleri = d.Movies.Select(m => new
            //    {
            //        m.Name
            //    }).ToList()
            //}).ToList();
            return Ok();
        }
    }
}
