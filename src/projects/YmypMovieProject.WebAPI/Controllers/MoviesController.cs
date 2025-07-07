using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YmypMovieProject.Business.Abstract;
using YmypMovieProject.Entity.Dtos.Movies;
using YmypMovieProject.Entity.Entities;

namespace YmypMovieProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _movieService;
        private readonly IMapper _mapper;


        public MoviesController(IMovieService movieService, IMapper mapper)
        {
            _movieService = movieService;
            _mapper = mapper;

        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var movies = _movieService.GetAll(false);
            return Ok(movies);
        }

        [HttpGet("FullInfo")]
        public IActionResult GetAllFullInfo()
        {
            var movies = _movieService.GetMoviesWithFullInfo();
            return Ok(movies);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var movie = _movieService.GetById(id);
            return Ok(movie);
        }
        [HttpPost]
        public IActionResult Insert(MovieAddRequestDto dto)
        {
            _movieService.Insert(dto);
            return StatusCode(201, dto);
        }
        [HttpPut]
        public IActionResult Update(MovieUpdateRequestDto dto)
        {
            _movieService.Modify(dto);
            return Ok(dto);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete( Guid id)
        {
            _movieService.Remove(id);
            return Content("movie deleted successfuly");
        }
    }
}
