using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DemoMVC.Models
{
    [Table("Ten")]
public class Ten
{
    [Key]
    public required string ID {get; set;}
    public required string Hoten {get; set;}
    public required string Matkhau {get; set;}
    public required string Diachi {get; set;}
}
}