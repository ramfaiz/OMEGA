using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[PrimaryKey("UserId", "RoleId")]
[Table("USER_CUSTOM_ROLE")]
public partial class UserCustomRole
{
    [Key]
    [Column("user_id")]
    public int UserId { get; set; }

    [Key]
    [Column("role_id")]
    public int RoleId { get; set; }
}
