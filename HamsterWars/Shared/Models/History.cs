using System.ComponentModel.DataAnnotations;

namespace HamsterWars.Shared.Models;

public class History
{
    [Key]
    public int Id { get; set; }
    [Required]
    public DateTime BattleDate { get; set; }
    [Required]
    public int WinnerId { get; set; }
    [Required]
    public int LoserId { get; set; }

}


