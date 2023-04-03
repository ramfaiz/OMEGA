using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("BTS_BG_Roles")]
public partial class BtsBgRole
{
    [Key]
    [Column("RoleID")]
    public byte RoleId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Name { get; set; }
}
