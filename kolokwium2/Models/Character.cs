using System.ComponentModel.DataAnnotations;

namespace kolokwium2.Models;

public class Character
{
    [Key]
    public int IdCharacter { get; set; }
    
    [Required]
    [MaxLength(100)]
    public string FirstName { get; set; }
    
    [Required]
    [MaxLength(100)]
    public string LastName { get; set; }
    
    [Required]
    public int CurrentWeight { get; set; }
    [Required]
    public int MaxWeight { get; set; }
    
    public ICollection<Backpack> Backpacks{ get; set; }
}