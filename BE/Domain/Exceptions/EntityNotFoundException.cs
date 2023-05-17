namespace Domain.Exceptions
{
    public class EntityNotFoundException : ApplicationException
    {
        public EntityNotFoundException(Type type, int id) : base($"Entity of {type.Name} with {id} was not found!") { }

        public static EntityNotFoundException OfType<T>(int id) 
        {
            throw new EntityNotFoundException(typeof(T), id);
        }
    }
}
