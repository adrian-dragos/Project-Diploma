namespace Domain.Exceptions
{
    public class UnauthorizedException : ApplicationException
    {
        public UnauthorizedException() : base("Not authorized!") { }
    }
}
