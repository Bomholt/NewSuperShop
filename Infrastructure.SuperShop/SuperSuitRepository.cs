using System.Collections.Generic;
using Core.SuperShop.Domain_Service;
using Entity;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.SuperShop

{
    public class SuperSuitRepository : ISuperSuitRepository
    {
        readonly SuperSuitAppContext _ctx;

        public SuperSuitRepository(SuperSuitAppContext ctx)
        {
            _ctx = ctx;
        }

        public SuperSuit CreateSuperSuit(SuperSuit superSuit)
        {
            _ctx.Attach(superSuit).State = EntityState.Added;
            _ctx.SaveChanges();
            return superSuit;
        }

        public SuperSuit DeleteSuperSuit(int id)
        {
            throw new System.NotImplementedException();
        }

        public SuperSuit NewSuperSuit(string name, string type, double price, string description)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<SuperSuit> ReadAll()
        {
            return _ctx.superSuits;
        }

        public SuperSuit UpdateSuperSuit(int id)
        {
            throw new System.NotImplementedException();
        }
    }

}