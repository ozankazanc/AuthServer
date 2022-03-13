using AuthServer.Core.Dtos;
using AuthServer.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthServer.Core.Services
{
    public interface IAuthenticationService
    {
        Task<Response<TokenDto>> CreateToken(LoginDto loginDto);
        Task<Response<TokenDto>> CreateTokenByRefreshToken(string refreshToken);
        /// <summary>
        /// refresh token'ı temizlememize olanak tanıyacak.
        /// </summary>
        /// <param name="refreshToken"></param>
        /// <returns></returns>
        Task<Response<NoDataDto>> RevokeRefreshToken(string refreshToken);
        Task<Response<ClientLoginDto>> CreateTokenByClient(ClientTokenDto clientTokenDto);
    }
}
