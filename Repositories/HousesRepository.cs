using server.Models;
using server.Repositories;

namespace server.Repositories;

public class HousesRepository
{
    private readonly IDbConnection _db;

    public HousesRepository(IDbConnection db)
    {
        _db = db;
    }
}