using AuctionService.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuctionService.Data;

public class AuctionDbContext : DbContext
{
  public AuctionDbContext(DbContextOptions options) : base(options)
  {
  }
  // we don't need to reference items in here becaise Auctions and items are related and entity framework will create a table for both 
  public DbSet<Auction> Auctions { get; set; }
}
