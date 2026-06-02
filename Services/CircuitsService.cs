using F1API.Data;
using F1API.Models;
//using System.Data.Entity;
using Microsoft.EntityFrameworkCore;


namespace F1API.Services
{
    public class CircuitsService(AppDbContext context) : ICircuitsService
    {
        public async Task<List<Circuit>> GetAllCircuitsAsync()
        {
            return await context.Circuits.Include(c => c.Location).ToListAsync();
        }

        public async Task<Circuit> GetCircuitByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Circuit?> AddCircuitAsync(Circuit circuit)
        {
            try
            {
                var newCircuit = context.Circuits.Add(circuit);

                await context.SaveChangesAsync();

                return newCircuit.Entity;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error Creating Race");
            }

            return null;
        }

        public async Task<bool> UpdateCircuitAsync(int id, Circuit circuit)
        {
            throw new NotImplementedException();
        }
        public async Task<bool> DeleteCircuitAsync(int id)
        {
            throw new NotImplementedException();
        }

    }
}
