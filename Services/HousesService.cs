using server.Models;
using server.Repositories;

namespace server.Services
{
    public class HousesService
    {
        private readonly HousesRepository _repo;

        public HousesService(HousesRepository repo)
        {
            _repo = repo;
        }

        internal House CreateHouse(House houseData)
        {
            House house = _repo.CreateHouse(houseData);
            return house;
        }

        internal List<House> GetAllHouses()
        {
            List<House> houses = _repo.GetAllHouses();
            return houses;
        }

        internal House GetHouseById(int houseId)
        {
            House house = _repo.GetHouseById(houseId);
            if (house == null) throw new Exception($"No House with Id: {houseId}");
            return house;
        }

        internal string RemoveHouse(int houseId)
        {
            House house = this.GetHouseById(houseId);
            _repo.RemoveHouse(houseId);
            return $"deleted house at {houseId}";
        }

        internal House UpdateHouse(House houseData)
        {
            House original = this.GetHouseById(houseData.Id);
            original.Sqft = houseData.Sqft ?? original.Sqft;
            original.Bedrooms = houseData.Bedrooms ?? original.Bedrooms;
            original.Bathrooms = houseData.Bathrooms ?? original.Bathrooms;
            original.ImgUrl = houseData.ImgUrl ?? original.ImgUrl;
            original.Price = houseData.Price ?? original.Price;
            original.Description = houseData.Description ?? original.Description;

            House house = _repo.UpdateHouse(original);
            return house;
        }
    }
}