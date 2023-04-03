using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class AdVwRoleMaster
{
    [Column("role_id")]
    public int RoleId { get; set; }

    [Column("role_code")]
    public int? RoleCode { get; set; }

    [Column("language_code")]
    public short LanguageCode { get; set; }

    [Column("display_value")]
    [StringLength(240)]
    public string? DisplayValue { get; set; }
}
