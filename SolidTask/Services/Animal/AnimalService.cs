using SolidTask.Repositories.UnitOfWorks;

namespace SolidTask.Services.Animal;

public partial class AnimalService : IAnimalService
{
	private readonly IUnitOfWork _unitOfWork;

	public AnimalService(IUnitOfWork unitOfWork)
	{
		_unitOfWork = unitOfWork;
	}
}
