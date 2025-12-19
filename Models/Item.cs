using System.ComponentModel.DataAnnotations;

namespace stream_response_ef_core.Models;

public class Item
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    public string? Description { get; set; }

    public bool IsActive { get; set; } = true;
}
