using System.ComponentModel.DataAnnotations;

namespace AltanDenemeC.Models
{
    public class Users
    {
       [Required]
       public int UserId {get; set;}
       [Key]
       public int Id {get; set;}
       [Required]
       [MaxLength(250)]
       public string Title {get; set;}
       [Required]
       [MaxLength(500)]
       public string Body {get; set;}
       [EmailAddress]
       public string EmailAddress{get;set;}
    }
}