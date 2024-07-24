using System.ComponentModel.DataAnnotations;

namespace ProyectoCrudNet8MVC.Models;

public class Contact
{
    [Key] 
    public int Id { get; set; }

    [Required(ErrorMessage = "The name is required")]
    public string Name { get; set; }
    
    [Required(ErrorMessage = "The telephone is required")]
    public string Telephone { get; set; }
    
    [Required(ErrorMessage = "The cellphone is required")]
    public string Cellphone { get; set; }
    
    [Required(ErrorMessage = "The email is required")]
    public string Email { get; set; }
    
    [Required(ErrorMessage = "The date is required")]
    public DateTime CreationDate { get; set; }
}