using SolidTask.Repositories.UnitOfWorks;

namespace SolidTask.Services.Herbavore;
public partial class HerbavoreService : IHerbavoreService
{
    private readonly IUnitOfWork _unitOfWork;

    public HerbavoreService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
}
