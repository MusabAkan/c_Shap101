using GameProject.Entities;

namespace GameProject.Abstract
{
    public interface IGamerService
    {
        void Add(Gamer gamer);
        void Update(long identityNumber, Gamer gamer);
        void Delete(Gamer gamer);
    }
}
