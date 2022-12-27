using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Domain.Models;

public class User
{
    [Key]
    public int Id { get; set; }
    [MaxLength(20)]
    public string UserName { get; set; }
    [JsonIgnore]
    public ICollection<Todo> Todos { get; set; }
}