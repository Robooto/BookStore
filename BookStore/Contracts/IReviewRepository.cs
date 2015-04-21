using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Contracts
{
    public interface IReviewRepository
    {
        IQueryable<Review> All(int bookId);

        Review AddReview(Review book);

        Review RemoveReview(int id);
        
    }
}
