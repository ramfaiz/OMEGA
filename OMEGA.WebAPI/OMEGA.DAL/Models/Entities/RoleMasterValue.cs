using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[PrimaryKey("RoleId", "LanguageCode")]
[Table("ROLE_MASTER_VALUES")]
public partial class RoleMasterValue
{
    [Key]
    [Column("role_id")]
    public int RoleId { get; set; }

    [Key]
    [Column("language_code")]
    public short LanguageCode { get; set; }

    [Column("short_display")]
    [StringLength(15)]
    public string? ShortDisplay { get; set; }

    [Column("display_value")]
    [StringLength(240)]
    public string? DisplayValue { get; set; }

    [ForeignKey("RoleId")]
    [InverseProperty("RoleMasterValues")]
    public virtual RoleMasterRef Role { get; set; } = null!;
}
