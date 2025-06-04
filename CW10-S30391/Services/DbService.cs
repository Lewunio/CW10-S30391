using CW10_S30391.Data;
using CW10_S30391.Models;
using Microsoft.EntityFrameworkCore;

namespace CW10_S30391.Services;

public interface IDbService
{
    public Task<TripPageGetDto> GetTripsPagedAsync(int page, int pageSize);
    public Task<ICollection<TripGetDto>> GetTripsAsync();
    public Task DeleteClientAsync(int idClient);
    public Task AddClientToTripAsync(ClientTripCreateDto body);
}

public class DbService(MasterContext data) : IDbService
{
    public async Task<TripPageGetDto> GetTripsPagedAsync(int page, int pageSize)
    {
        var trips = await GetTripsAsync();
        var size = trips.Count;
        var numberOfPages = size / pageSize;
        if (size % pageSize != 0) numberOfPages++;
        
        //Ustawia na ostatnia strone jesli jest za duze
        if (page > numberOfPages) page = numberOfPages;
        
        var returnedTrips = trips.Skip(page * pageSize).Take(pageSize).ToList();
        return new TripPageGetDto
        {
            PageNum = page,
            PageSize = pageSize,
            AllPages = numberOfPages,
            Trips = returnedTrips
        };
    }

    public async Task<ICollection<TripGetDto>> GetTripsAsync()
    {
        return await data.Trips.Select(t => new TripGetDto
        {
            Name = t.Name,
            Description = t.Description,
            DateFrom = t.DateFrom,
            DateTo = t.DateTo,
            Countries = t.IdCountries.Select(c => new CountryGetDto
            {
                Name = c.Name
            }).ToList(),
            Clients = t.ClientTrips
                .Where(ct=>ct.IdTrip == t.IdTrip)
                .Select(ct => new  ClientTripGetDto
                {
                    FirstName = ct.IdClientNavigation.FirstName,
                    LastName = ct.IdClientNavigation.LastName
                }).ToList()
        }).OrderByDescending(t=>t.DateFrom).ToListAsync();
    }

    public async Task DeleteClientAsync(int idClient)
    {
        throw new NotImplementedException();
    }

    public async Task AddClientToTripAsync(ClientTripCreateDto body)
    {
        throw new NotImplementedException();
    }
}