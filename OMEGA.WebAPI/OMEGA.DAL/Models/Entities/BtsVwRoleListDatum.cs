using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class BtsVwRoleListDatum
{
    [Column("sub_module_id")]
    public long? SubModuleId { get; set; }

    [Column("sub_module_name")]
    [StringLength(500)]
    public string? SubModuleName { get; set; }

    [Column("module_id")]
    public long? ModuleId { get; set; }

    [Column("sub_module_src")]
    public string? SubModuleSrc { get; set; }

    [Column("sl_no")]
    public long SlNo { get; set; }
}
