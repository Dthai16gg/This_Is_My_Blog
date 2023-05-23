using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Reponstories
{
    using DATA.DbContext;
    using DATA.IReponstories;

    using Microsoft.EntityFrameworkCore;

    public class Reponstories<T> : IReponstories<T>
        where T : class
    {
        private readonly DbContextBlog _context;
        private readonly DbSet<T> _dbSet;
        public Reponstories()
        {

        }

        public Reponstories(DbContextBlog context, DbSet<T> dbSet)
        {
            this._context = context;
            this._dbSet = dbSet;
        }

        public string Create(T item)
        {
            try
            {
                this._dbSet.Add(item);
                this._context.SaveChanges();
                return $"Create Success !";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string CreateMany(List<T> item)
        {
            try
            {
                this._dbSet.AddRange(item);
                this._context.SaveChanges();
                return "Create Many Success !";
            }
            catch (Exception e)
            {
               return e.Message;
            }
        }

        public string Delete(T item)
        {
            try
            {
                this._dbSet.Remove(item);
                this._context.SaveChanges();
                return $"Delete Success !";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string DeleteMany(List<T> item)
        {
            try
            {
                this._dbSet.RemoveRange(item);
                this._context.SaveChanges();
                return $"Delete Many Success !";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public IEnumerable<T> GetAll()
        {
            return this._dbSet.ToList();
        }

        public T GetByID(int id)
        {
            return this._dbSet.Find(id);
        }

        public IEnumerable<T> GetByName(string name)
        {
            return this._dbSet.Where(x => x.ToString().Contains(name)).ToList();
        }

        public string Update(T item)
        {
            try
            {
                this._dbSet.Update(item);
                this._context.SaveChanges();
                return $"Update Success !";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string UpdateMany(List<T> item)
        {
            try
            {
                this._dbSet.UpdateRange(item);
                this._context.SaveChanges();
                return $"Update Many Success !";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
    
}
