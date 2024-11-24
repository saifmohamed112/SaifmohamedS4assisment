using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SaifmohamedS4assisment.Dtos;
using SaifmohamedS4assisment.Repo;

namespace SaifmohamedS4assisment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieRepo _movieRepo;

        public MovieController(IMovieRepo movieRepo)
        {
            _movieRepo = movieRepo;
        }
        [HttpPost]
        public IActionResult add(MovieDTO movieDTO)
        {
            _movieRepo.add(movieDTO);
            return Created();
        }
        [HttpGet]
        public IActionResult get() 
        {
       var x = _movieRepo.getMovies();
           return Ok(x);
        }
        [HttpGet("GetById")]
        public IActionResult get(int Id)
        {
            var x = _movieRepo.getMoviebyid(Id);
            return Ok(x);
        }
        [HttpPut]
        public IActionResult put(MovieDTO movieDTO, int id) 
        {
        _movieRepo.update(movieDTO,id);
            return Accepted();
        }

    }
}
