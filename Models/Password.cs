using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Manager.Models;

[PrimaryKey(nameof(PasswordId))]
public class Password
{
    public int PasswordId { get; set; }
    public string PasswordName{ get; set; } = string.Empty;
    public string RPassword { get; set; } = string.Empty;
    public Folder? Folder { get; set; }
    public User User { get; set; }
    public bool Binned { get; set; }
}
