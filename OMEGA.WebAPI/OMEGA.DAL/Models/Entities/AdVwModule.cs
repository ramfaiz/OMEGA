using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class AdVwModule
{
    [Column("menu_id")]
    public int MenuId { get; set; }

    [Column("menu_name")]
    [StringLength(240)]
    public string? MenuName { get; set; }

    [Column("module_id")]
    public int ModuleId { get; set; }

    [Column("module_name")]
    [StringLength(240)]
    public string? ModuleName { get; set; }

    [Column("language_code")]
    public short LanguageCode { get; set; }

    [Column("is_active")]
    public int? IsActive { get; set; }

    [Column("module_image")]
    [StringLength(70)]
    [Unicode(false)]
    public string? ModuleImage { get; set; }
}
