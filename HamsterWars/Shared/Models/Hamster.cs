using System.ComponentModel.DataAnnotations;

namespace HamsterWars.Shared.Models;

public class Hamster
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Hamsters name is required")]
    [StringLength(50, MinimumLength = 1, ErrorMessage = "Hamsters name cannot have less than 1 characters and more than 50 characters in length")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Hamsters age is required")]
    public int Age { get; set; }

    [Display(Name = "Favorite Food")]
    [Required]
    public string FavFood { get; set; }


    [Required]
    public string Loves { get; set; }

    [Required(ErrorMessage = "Please select a picture")]
    public string ImgName { get; set; }
    public int Wins { get; set; }
    public int Losses { get; set; }
    public int Games { get; set; }


}
