using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using OrderSystem;
public class TodoContext : DbContext
{
    public TodoContext(DbContextOptions<TodoContext> options)
        : base(options)
    {
        this.Database.EnsureCreated();
    }
    public  DbSet<Order> MyOrders { get; set; }
    public  DbSet<Orderdetails> MyDetails { get; set; }
    public  DbSet<Client> MyClients { get; set; }
    public  DbSet<Product> MyProducts { get; set; }
}