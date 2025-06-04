using CW10_S30391.Data;
using CW10_S30391.Models;

namespace CW10_S30391.Services;

public interface IDbService
{
    public Task<TripPageGetDto> GetTripsAsync(int page, int pageSize);
    public Task DeleteClientAsync(int idClient);
    public Task AddClientToTripAsync(int idTrip, ClientTripCreateDto body);
}

public class DbService(MasterContext data) : IDbService
{
    public async Task<TripPageGetDto> GetTripsAsync(int page, int pageSize)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteClientAsync(int idClient)
    {
        throw new NotImplementedException();
    }

    public async Task AddClientToTripAsync(int idTrip, ClientTripCreateDto body)
    {
        throw new NotImplementedException();
    }
}