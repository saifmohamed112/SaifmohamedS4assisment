using SaifmohamedS4assisment.Dtos;

namespace SaifmohamedS4assisment.Repo
{
    public interface IMovieRepo
    {
        public void add(MovieDTO movieDTO);

        public List<MovieDTO> getMovies();
        public MovieDTO getMoviebyid(int id);
        public void update(MovieDTO movieDTO,int id);
    }
}
