using System.Collections.Generic;
using System.Linq;
using System.Data;
using backend.Data;

namespace backend.Data;

public class FavRepository : IFavRepository {

  private FavContext _favContext;
  public FavRepository(FavContext favContext) {
    _favContext = favContext;
  }
  public IEnumerable<EmsFavs> Favs()
  {
    return _favContext.Favs.ToArray();
  }
}