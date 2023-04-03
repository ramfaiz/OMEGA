using OMEGA.Core.Models;
using System.Collections.Immutable;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;

namespace OMEGA.Core.Services
{
    public interface IJwtAuthService
    {
        IImmutableDictionary<string, RefreshToken> UsersRefreshTokensReadOnlyDictionary { get; }

        JwtAuthResult GenerateTokens(string username, Claim[] claims, DateTime now);

        JwtAuthResult Refresh(string refreshToken, string accessToken, DateTime now);

        void RemoveExpiredRefreshTokens(DateTime now);

        void RemoveRefreshTokenByUserName(string userName);

        (ClaimsPrincipal, JwtSecurityToken) DecodeJwtToken(string token);
    }
}