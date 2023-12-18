using Microsoft.EntityFrameworkCore;
using Specification.Domain.User.Entities;

namespace Specification.Infrastructure;

public class DBContext : DbContext
{
    public DBContext(DbContextOptions<DBContext> options) : base(options)
    { }

    public DbSet<UserBase> User { get; set; }
}
