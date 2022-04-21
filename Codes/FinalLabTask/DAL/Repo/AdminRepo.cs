using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class AdminRepo : IRepository<News, int>
    {
        private FinalNewsEntities db;

        public AdminRepo(FinalNewsEntities db)
        {
            this.db = db;
        }
        public News Add(News obj)
        {
            db.Newses.Add(obj);
            db.SaveChanges();
            return db.Newses.FirstOrDefault();

        }

        public News Delete(int id)
        {
            var e = db.Newses.FirstOrDefault(dn => dn.Id == id);
            db.Newses.Remove(e);
            db.SaveChanges();
            return db.Newses.FirstOrDefault();

        }

        public News Edit(News n)
        {
            
            var p = db.Newses.FirstOrDefault(dn => dn.Id == n.Id);
            db.Entry(p).CurrentValues.SetValues(n);
            db.SaveChanges();
            return db.Newses.FirstOrDefault();

        }

        public News Get(int id)
        {
            return db.Newses.FirstOrDefault(x => x.Id == id);
        }

        public List<News> Get()
        {
            return db.Newses.ToList();
        }
    }
}
