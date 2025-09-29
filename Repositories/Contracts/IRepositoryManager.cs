namespace Repositories.Contracts
{
    public interface IRepositoryManager
    { //Unit of Work 
        IBookRepository Book { get; }
        void Save();
    }
}
