using System.Collections.Generic;
using System.Linq;
using EmlakApp.DataAccess.Abstract;
using EmlakApp.Entities;

namespace EmlakApp.DataAccess.Concrete
{
    public class Repository : IRepository
    {
        public List<Ev> GetAllAd()
        {
            using (EmlakContext c = new EmlakContext())
            {
                return c.Evler.ToList();
            }
        }

        public Ev GetAdById(int id)
        {
            using (EmlakContext c = new EmlakContext())
            {
                return c.Evler.Find(id);
            }
        }

        public Ev CreateAd(Ev ev)
        {
            using (EmlakContext c = new EmlakContext())
            {
                c.Evler.Add(ev);
                c.SaveChanges();
                return ev;
            }
        }

        public Ev UpdateAd(Ev ev)
        {
            using (EmlakContext c = new EmlakContext())
            {
                c.Evler.Update(ev);
                c.SaveChanges();
                return ev;
            }
        }

        public void DeleteAd(int id)
        {
            using (EmlakContext c = new EmlakContext())
            {
                var Deleted = GetAdById(id);
                c.Evler.Remove(Deleted);
            }
        }
    }
}
