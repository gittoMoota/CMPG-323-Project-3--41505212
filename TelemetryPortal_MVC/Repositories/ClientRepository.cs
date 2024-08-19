
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using global::TelemetryPortal_MVC.Data;
using global::TelemetryPortal_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace TelemetryPortal_MVC.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly TechtrendsContext _context;

        public ClientRepository(TechtrendsContext context)
        {
            _context = context;
        }

        public async Task<List<Client>> GetAllClientsAsync()
        {
            return await _context.Clients.ToListAsync();
        }

        public async Task<Client> GetClientByIdAsync(Guid id)
        {
            return await _context.Clients.FirstOrDefaultAsync(m => m.ClientId == id);
        }

        public async Task CreateClientAsync(Client client)
        {
            client.ClientId = Guid.NewGuid();
            _context.Add(client);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateClientAsync(Client client)
        {
            _context.Update(client);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteClientAsync(Guid id)
        {
            var client = await _context.Clients.FindAsync(id);
            if (client != null)
            {
                _context.Clients.Remove(client);
                await _context.SaveChangesAsync();
            }
        }

        public bool ClientExists(Guid id)
        {
            return _context.Clients.Any(e => e.ClientId == id);
        }
    }
}
