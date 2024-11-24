using SaifmohamedS4assisment.Dtos;

namespace SaifmohamedS4assisment.Repo
{
    public interface ICinemaRepo
    {
        public void add(Cinemawithmoviedto dto);
        public List<Cinemawithmoviedto> Getall();

        public void updata(Cinemawithmoviedto dto,int id);
        public Cinemawithmoviedto GetById(int id);
    }
}
