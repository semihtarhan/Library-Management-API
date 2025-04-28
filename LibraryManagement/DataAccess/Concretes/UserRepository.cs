using LibraryManagement.DataAccess.Abstracts;
using LibraryManagement.DataAccess.Contexts;
using LibraryManagement.Models;
using MongoDB.Bson;

namespace LibraryManagement.DataAccess.Concretes;

public class UserRepository : IUserRepository
{
    private MongoDbContext context;

    public UserRepository(MongoDbContext context)
    {
        this.context = context;
    }
    public void Add(User user)
    {
        context.Users.Add(user);
        context.SaveChanges();
    }

    public List<User> GetAll()
    {
        return context.Users.ToList();
    }

    public User GetById(Guid id)
    {
        return context.Users.Find(id);
    }

    public void Delete(User user)
    {
        context.Users.Remove(user);
        context.SaveChanges();
    }

    public User GetByEmail(string email)
    {
        User user = context.Users.SingleOrDefault(x => x.Email == email);
        return user;
    }
}
