﻿namespace Infrastructure.Authorization
{
    public interface IPermissionService
    {
        Task<bool> HasPermissionAsync(int userId, string permission);
    }
}
