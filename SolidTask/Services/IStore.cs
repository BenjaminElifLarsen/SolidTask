using SolidTask.Models;

namespace SolidTask.Services;
public interface IStore
{
    public void Add(object entity);

    public IEnumerable<object> All { get; }
}
