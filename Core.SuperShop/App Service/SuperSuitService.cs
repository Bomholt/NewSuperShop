using System.Collections.Generic;
using System.Linq;
using Core.SuperShop.Domain_Service;
using Entity;

namespace Core.SuperShop
{
    public class SuperSuitService : ISuperSuitService
    {
        readonly ISuperSuitRepository _superSuitRepository;

        public SuperSuitService(ISuperSuitRepository superSuitRepository)
        {
            _superSuitRepository = superSuitRepository;
        }

        public SuperSuit NewSuperSuit(string name, string type, double price, string description)
        {
            var superSuit = new SuperSuit()
            {
                Name = name,
                Type = type,
                Price = price,
                Description = description
            };
            return superSuit;
        }

        public SuperSuit CreateSuperSuit(SuperSuit superSuit)
        {
            return _superSuitRepository.CreateSuperSuit(superSuit);
        }

        public List<SuperSuit> ReadAll()
        {
            return _superSuitRepository.ReadAll().ToList();
        }

        public SuperSuit UpdateSuperSuit(int id)
        {
            throw new System.NotImplementedException();
        }

        public SuperSuit DeleteSuperSuit(int id)
        {
            return _superSuitRepository.DeleteSuperSuit(id);
        }
    }
}