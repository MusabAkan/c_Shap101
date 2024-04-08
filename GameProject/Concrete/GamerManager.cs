using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    public class GamerManager : IGamerService
    {

        private readonly List<Gamer> _gamers;
        readonly IUserValidationService _validationService;

        public GamerManager(IUserValidationService validationService)
        {
            _validationService = validationService;
        }
        public void Add(Gamer gamer)
        {

            if (_validationService.Validate(gamer))
            {
                _gamers.Add(gamer);
                Console.WriteLine("Oyuncu eklendi");
            }
            else
                Console.WriteLine("Oyuncu E-Devlet üzerinde kaydı bulunamadı...");

        }

        public void Delete(Gamer gamer)
        {
            var exist = _gamers.Where(i => i.IdentityNumber == gamer.IdentityNumber).FirstOrDefault();
            if (exist != null)
            {
                _gamers.Remove(gamer);
                Console.WriteLine("Oyuncu silindi");
            }
            else
                Console.WriteLine("Oyuncu bulunmadı");

        }

        public void Update(long identityNumber, Gamer gamer)
        {
            var exist = _gamers.Where(i => i.IdentityNumber == identityNumber).FirstOrDefault();

            if (exist == null)
            {
                _gamers.Remove(exist);
                _gamers.Add(gamer);
                    
                Console.WriteLine("Oyuncu güncellendi");
            }



        }
    }
}
