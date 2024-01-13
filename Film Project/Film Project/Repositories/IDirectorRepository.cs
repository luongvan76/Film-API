using Film_Project.Models.Domain;
using Film_Project.Models.DTO;

namespace Film_Project.Repositories
{
    public interface IDirectorRepository
    {
        List<DirectorIdDTO> GetAllDirectors();

        Directors GetDirectorById(int id);

        DirectorDTO AddDirector(DirectorDTO directorDTO);

        DirectorDTO UpdateDirectorById(int id, DirectorDTO directorDTO);

        Directors DeleteDirectorById(int id);
    }
}