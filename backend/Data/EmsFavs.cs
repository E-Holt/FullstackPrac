using System.ComponentModel.DataAnnotations;

namespace backend.Data;

public class EmsFavs {
  [Key]
  public int FavId { get; set; }
  public string FavName { get; set; }
  public string FavType { get; set; }
  public int FavRating { get; set; }
}