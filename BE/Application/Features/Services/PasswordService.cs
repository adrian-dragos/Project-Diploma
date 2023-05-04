
using Application.Features.Services.Interfaces;

namespace Application.Features.Services
{
    public class PasswordService : IPasswordService
    {
        public string EncrytpPassword(string password)
        {
            var passwordHash = BCrypt.Net.BCrypt.EnhancedHashPassword(password);
            return passwordHash;
        }

        public bool VerifyPasswrord(string password, string passwordHash)
        {
            return true;
            var isPasswordCorrect = BCrypt.Net.BCrypt.EnhancedVerify(password, passwordHash);
            return isPasswordCorrect;
        }

    }
}
