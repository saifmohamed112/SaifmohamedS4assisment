using Microsoft.EntityFrameworkCore;
using SaifmohamedS4assisment.data;
using SaifmohamedS4assisment.Dtos;
using SaifmohamedS4assisment.models;

namespace SaifmohamedS4assisment.Repo
{
    public class MovieRepo : IMovieRepo
    {
        private readonly ApplicationDbContext _context;

        public MovieRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public void add(MovieDTO movieDTO)
        {
            var movie = new models.Movie
            {
                Title = movieDTO.Title,
                publishyear = movieDTO.publishyear,
                Cinema = new models.Cinema
                {
                    Name = movieDTO.Cinema.Name,
                    PlaceHolder = movieDTO.Cinema.PlaceHolder,
                },
                Catigory = new models.Catigory
                {
                    Name = movieDTO.Catigory.Name,
                }
            };
            _context.Movies.Add(movie);
            _context.SaveChanges();
        }

        public MovieDTO getMoviebyid(int id)
        {
            var res = _context.Movies.Include(x => x.Cinema).Include(x => x.Catigory).FirstOrDefault(x => x.Id == id);
            if (res == null)
            {
                return null;
            };
            return new MovieDTO
            {
                Title = res.Title,
                publishyear = res.publishyear,
                Catigory = new CatigoryDTO
                {
                    Name = res.Catigory.Name,
                },
                Cinema = new CinemawithoutMovieDto
                {
                    Name = res.Cinema.Name,
                    PlaceHolder = res.Cinema.PlaceHolder,
                }
            };
        }

        public List<MovieDTO> getMovies()
        {
          var res = _context.Movies.Include(x=>x.Cinema).Include(x=>x.Catigory).Select(x=>new MovieDTO
          {
              Title = x.Title,
              publishyear=x.publishyear,
              Cinema = new CinemawithoutMovieDto
              {
                  Name = x.Cinema.Name,
                  PlaceHolder= x.Cinema.PlaceHolder,
              },
              Catigory = new CatigoryDTO
              {
                  Name = x.Cinema.Name,
              }
          }).ToList();
            return res;
        }

        public void update(MovieDTO movieDTO, int id)
        {
            var mov = _context.Movies.Include(x => x.Cinema).Include(x => x.Catigory).FirstOrDefault(x => x.Id == id);
            if (mov != null)
            {
                mov.Title = movieDTO.Title;
                mov.publishyear = movieDTO.publishyear;
                mov.Cinema = new models.Cinema
                {
                    Name = movieDTO.Cinema.Name,
                    PlaceHolder = movieDTO.Cinema.PlaceHolder,
                };
                mov.Catigory = new models.Catigory
                {
                    Name = movieDTO.Cinema.Name,
                };
                _context.Movies.Update(mov);
                _context.SaveChanges();
            }
          
        }
    }
}
