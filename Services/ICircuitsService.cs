using F1API.Models;

namespace F1API.Services
{
    public interface ICircuitsService
    {
        Task<List<Circuit>> GetAllCircuitsAsync();

        Task<Circuit> GetCircuitByIdAsync(int id);

        Task<Circuit?> AddCircuitAsync(Circuit circuit);

        Task<bool> UpdateCircuitAsync(int id, Circuit circuit);

        Task<bool> DeleteCircuitAsync(int id);
    }
}
