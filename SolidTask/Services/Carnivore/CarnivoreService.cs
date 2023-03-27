using SolidTask.Repositories.UnitOfWorks;

namespace SolidTask.Services.Carnivore;
public partial class CarnivoreService : ICarnivoreService
{
    private readonly IUnitOfWork _unitOfWork;

	public CarnivoreService(IUnitOfWork unitOfWork)
	{
		_unitOfWork = unitOfWork;
	}
}
