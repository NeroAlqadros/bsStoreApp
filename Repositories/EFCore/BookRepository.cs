using Entities.Models;
using Repositories.Contracts;

namespace Repositories.EFCore
{
    public class BookRepository(RepositoryContext context) : RepositoryBase<Book>(context), IBookRepository
    {
        public void CreateOneBook(Book book) => Create(book);

        public void DeleteOneBook(Book book) => Delete(book);

        public IQueryable<Book> GetAllBooks(bool trackChanges)
            => FindAll(trackChanges);

        public Book GetOneBookById(int id, bool trackChanges)
             => FindByCondition(b => b.Id.Equals(id), trackChanges)
                .SingleOrDefault();

        public void UpdateOneBook(Book book) => Update(book);
    }
}
