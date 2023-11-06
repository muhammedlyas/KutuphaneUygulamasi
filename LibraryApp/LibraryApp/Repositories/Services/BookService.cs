using LibraryApp.Data;
using LibraryApp.Models;
using LibraryApp.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp.Repositories.Services;

public class BookService : IBookService
{
    private readonly LibraryAppDbContext _dbContext;

    public BookService(LibraryAppDbContext dbContext)
    {
        _dbContext = dbContext;
    }




    //Kütüphanede bulunan kitaplar listele
    public async Task<List<Book>> ListBook()
    {
        var books = await _dbContext.Book
            .Include(b => b.LendBook)
            .OrderBy(x => x.Name)
            .ToListAsync();

        return books;
    }


    
    public async Task LendBook(LendBook model)
    {
        var book = await _dbContext.Book
            .FirstOrDefaultAsync(x => x.Id == model.BookId);

        if (book != null)
        {
            book.IsActive = false;

            var lendBook = new LendBook()
            {
                BarrowName = model.BarrowName,
                BarrowSurname = model.BarrowSurname,
                EndDate = model.EndDate,
                BookId = model.BookId
            };
            _dbContext.LendBook.Add(lendBook);
            _dbContext.Book.Update(book);
        }

        await _dbContext.SaveChangesAsync();
    }

    // Kitap sisteme eklendi
    public async Task<(bool, string)> AddBook(Book model)
    {
        var existBook = await _dbContext.Book.FirstOrDefaultAsync(u => u.Name == model.Name);
        if (existBook != null)
        {
            return (false, "Eklenen kitap bir daha eklenemez");
        }

        using var memoryStream = new MemoryStream();
        await model.ImageFile.CopyToAsync(memoryStream);

        var book = new Book()
        {
            Author = model.Author,
            Name = model.Name,
            IsActive = true,
            Image = memoryStream.ToArray() // Burada Image özelliğini kullandık
        };

        _dbContext.Book.Add(book);
        await _dbContext.SaveChangesAsync();
        return (true, "Kitap başarıyla eklenmiştir.");
    }

   
    
}