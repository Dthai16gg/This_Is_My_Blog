namespace DATA.IReponstories;

public interface IReponstories<T>
{
    // crud tra ve public string
    public string Create(T item);

    // crud many
    public string CreateMany(List<T> item);

    public string Delete(T item);

    public string DeleteMany(List<T> item);

    // get
    public IEnumerable<T> GetAll();

    public T GetByID(Guid id);

    public IEnumerable<T> GetByName(string name);

    public string Update(T item);

    public string UpdateMany(List<T> item);
}