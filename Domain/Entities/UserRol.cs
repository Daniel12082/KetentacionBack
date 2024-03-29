using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities;
public class UserRol : BaseEntity
{
    public int UserId { get; set; }
    public User User { get; set; }
    public int RolId { get; set; }
    public Rol Rol { get; set; }
}
