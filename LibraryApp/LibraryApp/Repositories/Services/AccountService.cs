using LibraryApp.Data;
using LibraryApp.Models;
using LibraryApp.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp.Repositories.Services;

public class AccountService : IAccountService
{
    private readonly LibraryAppDbContext _dbContext;

    public AccountService(LibraryAppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    /*
     * Kullanıcı girişi kontrol edilmiştir.
     * Kullanıcı database üzerinden eklendiği için password hashlenmemiştir.
     */
    public async Task<(bool, string)> Login(User model)
    {

        var user = await _dbContext.User.FirstOrDefaultAsync(u => u.Username == model.Username);
        if (user == null)
        {
            return (false, "Kullanıcı bulunamadı");
        }

        if (model.Password == user.Password)
        {

            return (true, "Hoşgeldiniz");
        }

        return (false, "Kullanıcı adı veya parola yanlış");

    }

}
