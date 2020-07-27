

using Microsoft.EntityFrameworkCore;

namespace WebKeyBoardShop.Models
{
    public class SellContext : DbContext
    {
        public DbSet<KeyBoard> KeyBoards { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }

        public SellContext(DbContextOptions<SellContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
