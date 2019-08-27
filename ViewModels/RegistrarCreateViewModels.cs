using System.ComponentModel;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using Registrar.Models;
namespace Registrar.ViewModels
{
public class RegistrarCreateViewModel
{
    public int CourseId { get; set; }
    public string Name { get; set; }
    public int CourseNumber { get; set; }
    public IFormFile Photo { get; set; }
    public virtual ICollection<CourseStudent> Students { get; set; }
}
}