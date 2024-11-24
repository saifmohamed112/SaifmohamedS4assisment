using Microsoft.EntityFrameworkCore;
using SaifmohamedS4assisment.data;
using SaifmohamedS4assisment.Dtos;
using SaifmohamedS4assisment.models;

namespace SaifmohamedS4assisment.Repo
{
    public class CinemaRepo : ICinemaRepo
    {
        private readonly ApplicationDbContext _context;

        public CinemaRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public void add(Cinemawithmoviedto dto)
        {
            var cinema = new Cinema
            {
                Name = dto.Name,
                PlaceHolder = dto.PlaceHolder,
                Movies = dto.Movies.Select(x=>new Movie
                {
                    Title = x.Title,
                    publishyear = x.publishyear,
                    Catigory = new Catigory
                    {
                        Name = x.Catigory.Name,
                    }
                }).ToList(),
            };
            _context.Cinemas.Add(cinema);
            _context.SaveChanges();
            
        }

        public List<Cinemawithmoviedto> Getall()
        {
            var res = _context.Cinemas.Include(x => x.Movies).ThenInclude(x => x.Catigory)
                .Select(x => new Cinemawithmoviedto
                {
                    Name = x.Name,
                    PlaceHolder = x.PlaceHolder,
                    Movies = x.Movies.Select(s => new moviewithoutcinmaDto
                    {
                        Title = s.Title,
                        publishyear = s.publishyear,
                        Catigory = new CatigoryDTO
                        {
                            Name = s.Catigory.Name,
                        }
                    }).ToList(),
                }).ToList();
            return res;
        }

        public Cinemawithmoviedto GetById(int id)
        {
            var res = _context.Cinemas.Include(x => x.Movies).ThenInclude(x => x.Catigory).FirstOrDefault(x => x.Id == id);
            if (res == null)
            {
                return null;
            }
            return new Cinemawithmoviedto
            {
                Name = res.Name,
                PlaceHolder = res.PlaceHolder,
                Movies = res.Movies.Select(x => new moviewithoutcinmaDto
                {
                    Title= x.Title,
                    publishyear = x.publishyear,
                    Catigory = new CatigoryDTO
                    {
                        Name = x.Catigory.Name,
                    }
                }).ToList(),
            };     
            
        }

        public void updata(Cinemawithmoviedto dto,int id)
        {
            var cinema= _context.Cinemas.Include(x => x.Movies).ThenInclude(x => x.Catigory).FirstOrDefault(x => x.Id == id);
            cinema.Name = dto.Name;
            cinema.PlaceHolder = dto.PlaceHolder;
            cinema.Movies = dto.Movies.Select(x=>new Movie
            {
                Title = x.Title,
                publishyear= x.publishyear,
                Catigory = new Catigory
                {
                    Name = x.Catigory.Name,
                },
                
            }).ToList();
            
            _context.Cinemas.Update(cinema);
            _context.SaveChanges();
        }
    }
}
