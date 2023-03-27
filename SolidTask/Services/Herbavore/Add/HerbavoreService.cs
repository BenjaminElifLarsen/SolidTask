using SolidTask.Services.Herbavore.Add;
using Herba = SolidTask.Models.Herbavore;

namespace SolidTask.Services.Herbavore;
public partial class HerbavoreService
{

    public void Add(HerbavoreRequest request)
    {
        _unitOfWork.AnimalRepository.AddAnimal(new Herba(request.Name, request.IsBird));
    }
}
