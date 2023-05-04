namespace Domain.Exceptions
{
    public class UnauthorizedExceptinon : ApplicationException
    {
        public UnauthorizedExceptinon() : base("Not authorized!") { }
    }
}
