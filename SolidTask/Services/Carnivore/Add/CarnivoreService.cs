using SolidTask.Services.Carnivore.Add;
using Carni = SolidTask.Models.Carnivore;

namespace SolidTask.Services.Carnivore;
public partial class CarnivoreService
{
    public void Add(CarnivoreRequest request)
    {
        _unitOfWork.AnimalRepository.AddAnimal(new Carni(request.Name, request.IsBird));
        _unitOfWork.Save();
    }
}
