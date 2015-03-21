namespace Nova.Data
{
    public interface IEntity<out TId>
    {
        TId Id { get; }
    }
}