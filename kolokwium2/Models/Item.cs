using System.ComponentModel.DataAnnotations;

namespace kolokwium2.Models;

public class Item
{
    [Key]
    public int IdItem { get; set; }
    
    [Required]
    [MaxLength(100)]
    public string Name { get; set; }
    
    [Required]
    public int Weight { get; set; }
    
    public ICollection<Backpack> Backpacks{ get; set; }
}