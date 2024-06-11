using System.ComponentModel.DataAnnotations;

namespace DefaultNamespace;

public class Title
{
    [Key]
    public int IdTitle { get; set; }
    
    [Required]
    [MaxLength(100)]
    public string Name { get; set; }
    
}