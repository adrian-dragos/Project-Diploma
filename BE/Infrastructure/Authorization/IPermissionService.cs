namespace Infrastructure.Authorization
{
    public interface IPermissionService
    {
        Task<IEnumerable<string>> GetPermissionsAsync(int userId);
    }
}
