using GameProject.Entities;

namespace GameProject.Abstract
{
    public interface IUserValidationService
    {        
        bool Validate(Gamer gamer);
    }
}
