using BNI.Models.Domain;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class User : IdentityUser<int>
{
    public string? FullName { get; set; }
    public string? Company { get; set; }
    public string? VAT { get; set; }
    public string? Address { get; set; }
    public string? City { get; set; }
    public string? Zip { get; set; }
    public string? Country { get; set; }

    public int Role_ID { get; set; }
    [ForeignKey("Role_ID")]
    public Role Role { get; set; }

    public IEnumerable<EventsRegister> EventsRegister { get; set; }
    public Member? Member { get; set; }
    public IEnumerable<Comment> Comments { get; set; }
}
