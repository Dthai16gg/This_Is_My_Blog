using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.IReponstories
{
  public interface IReponstories<T>
  {
    //crud tra ve public string
    public string Create(T item);
    public string Update(T item);
    public string Delete(T item);
    //get
    public IEnumerable<T> GetAll();
    public T GetByID(Guid id);
    public IEnumerable<T> GetByName(string name);
    //crud many
    public string CreateMany(List<T> item);
    public string UpdateMany(List<T> item);
    public string DeleteMany(List<T> item);
  }
}
