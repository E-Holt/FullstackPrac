using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using backend.Data;

namespace backend.Controllers;

[Route("[controller]")]
[ApiController]
public class FavController : ControllerBase 
{
  private IFavRepository _favRepository;
  public FavController(IFavRepository favRepository) 
  {
    _favRepository = favRepository;
  }
  [HttpGet]
  public IEnumerable<EmsFavs> Get()
  {
    var favData = _favRepository.Favs();
    return favData;
  }
}
