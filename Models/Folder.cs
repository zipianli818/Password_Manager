using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Manager.Models;

[PrimaryKey(nameof(Id))]
public class Folder
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public User User { get; set; }
}
