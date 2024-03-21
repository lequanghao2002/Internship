using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BNI.Models.Domain
{
    public class Role : IdentityRole<int>
    {
        
        public string Name { get; set; } = string.Empty;

        public IEnumerable<User> Users { get; set;}
    }
}
