using SolidTask.Models;

namespace SolidTask.Repositories.Context;
public interface IStore
{
    public void Add(object entity);

    public IEnumerable<object> All { get; }
}
