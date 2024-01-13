using Film_Project.Models.Domain;
using Film_Project.Models.DTO;

namespace Film_Project.Repositories
{
    public interface IActorRepository
    {
        List<ActorIdDTO> GetAllActors();

        Actors GetActorById(int id);

        ActorDTO AddActor(ActorDTO actorDTO);

        ActorDTO UpdateActorById(int id, ActorDTO actorDTO);

        Actors DeleteActorById(int id);
    }
}