using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class AdVwSubModule
{
    [Column("module_id")]
    public int ModuleId { get; set; }

    [Column("sub_module_id")]
    public int SubModuleId { get; set; }

    [Column("sl_no")]
    public int? SlNo { get; set; }

    [Column("sub_module_name")]
    [StringLength(240)]
    public string? SubModuleName { get; set; }

    [Column("sub_module_url")]
    public string? SubModuleUrl { get; set; }

    [Column("is_approval_req")]
    public int? IsApprovalReq { get; set; }

    [Column("is_active")]
    public int? IsActive { get; set; }

    [Column("language_code")]
    public short LanguageCode { get; set; }

    [Column("long_desc")]
    [StringLength(200)]
    public string? LongDesc { get; set; }

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }
}
