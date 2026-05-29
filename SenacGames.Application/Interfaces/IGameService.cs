using SenacGames.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace SenacGames.Application.Interfaces
{
    public interface IGameService
    {
        /// <summary>
        /// Contrato de serviço de Games.
        /// Define as operações de negócio disponíveis para o game.
        /// </summary>
     
        Task<IEnumerable<GameDto>> GetAllasyne();
        Task<GameDto?> GetByIdAsyne(int id);
        Task<IEnumerable<GameDto>> GetFeaturedAsync();
        Task<IEnumerable<GameDto>> GetByCategoryAsync(int categoryId);
        Task<GameDto> GetAllAsync(CreateCategoryDto dto);
        Task<GameDto?> UpdateAsync(int id, UpdateCategoryDto dto);
        Task<bool> DeleteAsync(int id);
        Task<int> CountAsync();
    }
}
