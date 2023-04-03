using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class CmVwMenu1
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

    [Column("sl_no")]
    public int? SlNo { get; set; }

    [Column("sub_module_id")]
    public int SubModuleId { get; set; }

    [Column("sub_module_name")]
    [StringLength(240)]
    public string? SubModuleName { get; set; }

    [Column("sub_module_url")]
    public string? SubModuleUrl { get; set; }

    [Column("language_code")]
    public short LanguageCode { get; set; }

    [Column("actual_module_id")]
    public int? ActualModuleId { get; set; }
}
