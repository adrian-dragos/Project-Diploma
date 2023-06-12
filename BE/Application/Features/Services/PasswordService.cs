﻿
using Application.Features.Services.Interfaces;

namespace Application.Features.Services
{
    public class PasswordService : IPasswordService
    {
        public string EncrtpyPassword(string password)
        {
            var passwordHash = BCrypt.Net.BCrypt.EnhancedHashPassword(password);
            return passwordHash;
        }

        public bool VerifyPassword(string password, string passwordHash)
        {
            var isPasswordCorrect = BCrypt.Net.BCrypt.EnhancedVerify(password, passwordHash);
            return isPasswordCorrect;
        }

    }
}
