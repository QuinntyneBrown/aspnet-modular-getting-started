using Chloe.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chloe.NBAClient.Contracts
{
    public interface INBAClient
    {
        AllPlayersResponseDto GetAllPlayers();

        Task<AllPlayersResponseDto> GetAllPlayersAsync();
    }
}
