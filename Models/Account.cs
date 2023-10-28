using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Manager.Models;

[PrimaryKey(nameof(Id))]
public class Account
{
    public int Id { get; set; }
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string Address {  get; set; } = string.Empty;
    public Folder? Folder { get; set; }
    public User User { get; set; }
    public bool Binned { get; set; }

}
