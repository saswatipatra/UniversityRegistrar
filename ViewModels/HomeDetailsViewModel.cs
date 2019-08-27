using System.ComponentModel;
using Microsoft.AspNetCore.Http;
using Registrar.Models;
namespace Registrar.ViewModels
{
    public class HomeDetailsViewModel
    {
        public Course Course { get; set; }
        public Student Student {get;set;}
        
    }
}