using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace backend.Data;

public class FavContext : DbContext {
  public FavContext(DbContextOptions<FavContext> options) : base(options) { }

  public DbSet<EmsFavs> Favs { get; set; }
}