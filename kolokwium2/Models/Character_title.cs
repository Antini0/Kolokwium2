using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DefaultNamespace;
using Microsoft.EntityFrameworkCore;

namespace kolokwium2.Models;

[PrimaryKey(nameof(IdCharacter), nameof(IdTitle))]
public class Character_title
{
    [Key]
    public int IdCharacter { get; set; }
    
    [Required]
    [MaxLength(100)]
    public int IdTitle { get; set; }
    
    [Required]
    public DateTime AccuiredAt { get; set; }
    
    [ForeignKey(nameof(IdCharacter))]
    public Character Character { get; set; }
    
    [ForeignKey(nameof(IdTitle))]
    public Title Title { get; set; }
    
    
}