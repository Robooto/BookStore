using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Contracts
{
    public interface IUnitOfWork
    {
        void Commit();

        IBookRepository Books { get; }
        IAuthorRepository Authors { get; }
        IReviewRepository Reviews { get; }
    }
}
