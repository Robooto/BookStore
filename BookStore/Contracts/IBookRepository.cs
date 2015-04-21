using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Contracts
{
    public interface IBookRepository
    {
        IQueryable<Book> All { get; }
        IQueryable<Book> Search(string criteria);
        Book GetOne(int id);
    }
}
