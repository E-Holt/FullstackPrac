using System.Collections.Generic;
using System.Linq;

namespace backend.Data;

public interface IFavRepository {
    IEnumerable<EmsFavs> Favs();
}