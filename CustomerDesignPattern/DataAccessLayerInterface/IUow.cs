namespace DataAccessLayerInterface
{
    public interface IUow
    {
        void Commit();
        void Rollback();
    }
}