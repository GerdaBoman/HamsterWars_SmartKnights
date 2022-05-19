using System.ComponentModel.DataAnnotations;

namespace HamsterWars.Shared.Models;

public class Hamster
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public int Age { get; set; }

    [Display(Name = "Favorite Food")]
    [DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "N/A")]
    public string FavFood { get; set; }

    [DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "N/A")]
    public string Loves { get; set; }
    [Required]
    public string ImgName { get; set; }
    public int Wins { get; set; }
    public int Losses { get; set; }
    public int Games { get; set; }

   

}
