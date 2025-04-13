using GameStore.Domain.Entities;
using GameStore.Domain.Interfaces;

namespace GameStore.Application.Services
{
    public class GameService
    {
        private readonly IGameRepository _gameRepository;

        public GameService(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

        public Task<List<Game>> GetAllAsync() => _gameRepository.GetAllAsync();
        public Task<Game?> GetByIdAsync(Guid id) => _gameRepository.GetByIdAsync(id);
        public Task AddAsync(Game game) => _gameRepository.AddAsync(game);
        public Task UpdateAsync(Game game) => _gameRepository.UpdateAsync(game);
        public Task DeleteAsync(Guid id) => _gameRepository.DeleteAsync(id);
    }
}
