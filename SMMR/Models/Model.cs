using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMMR.Models
{
    public class Model<T> where T : class
    {
        public SMMRContext _context { get; set; }

        public Model()
        {
            _context = new SMMRContext();
        }

        public List<T> getAll(T model)
        {
            return _context.Set<T>().ToList<T>();
        }

        public T getOneByID(long id)
        {
            return _context.Set<T>().Find(id);
        }

        public List<T> getAllByCondition(Func<T, bool> predicate)
        {
            return _context.Set<T>().Where(predicate).ToList<T>();
        }

        public T getOneByCondition(Func<T, bool> predicate)
        {
            return _context.Set<T>().Where(predicate).FirstOrDefault();
        }

        public bool store(T model)
        {
            try
            {
                _context.Set<T>().Add(model);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }
        
    }
}
