namespace SolidPrinciples.ISP
{
    public interface IRepository<TAggregate, in TKey>
    {
        TAggregate Get(TKey id);
        void Save(TAggregate aggregate);
    }
}