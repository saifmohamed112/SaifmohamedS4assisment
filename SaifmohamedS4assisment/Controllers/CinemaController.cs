using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SaifmohamedS4assisment.Dtos;
using SaifmohamedS4assisment.Repo;

namespace SaifmohamedS4assisment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CinemaController : ControllerBase
    {
        private readonly ICinemaRepo _Repo;

        public CinemaController(ICinemaRepo Repo)
        {
            _Repo = Repo;
        }
        [HttpPost]
        public IActionResult add(Cinemawithmoviedto dto)
        {
            _Repo.add(dto);
            return Created();
        }
        [HttpGet]
        public IActionResult get()
        {
            var x = _Repo.Getall();
            return Ok(x);
        }
        [HttpGet("GetById")]
        public IActionResult get(int Id)
        {
            var x = _Repo.GetById(Id);
            return Ok(x);
        }
        [HttpPut]
        public IActionResult put(Cinemawithmoviedto DTO, int id)
        {
            _Repo.updata(DTO, id);
            return Accepted();
        }
    }
}
