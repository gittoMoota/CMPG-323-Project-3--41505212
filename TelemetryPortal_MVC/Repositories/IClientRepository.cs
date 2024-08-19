using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TelemetryPortal_MVC.Models;

namespace TelemetryPortal_MVC.Repositories
{
    public interface IClientRepository
    {
        Task<List<Client>> GetAllClientsAsync();
        Task<Client> GetClientByIdAsync(Guid id);
        Task CreateClientAsync(Client client);
        Task UpdateClientAsync(Client client);
        Task DeleteClientAsync(Guid id);
        bool ClientExists(Guid id);
    }
}

