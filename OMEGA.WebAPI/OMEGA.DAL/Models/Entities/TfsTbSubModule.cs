﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("TFS_TB_SUB_MODULES")]
public partial class TfsTbSubModule
{
    [Key]
    [Column("sl_no")]
    public long SlNo { get; set; }

    [Column("sub_module_id")]
    public long? SubModuleId { get; set; }

    [Column("module_id")]
    public long? ModuleId { get; set; }

    [Column("list_priority")]
    public long? ListPriority { get; set; }

    [Column("display_value")]
    [StringLength(500)]
    public string? DisplayValue { get; set; }

    [Column("sub_module_src")]
    public string? SubModuleSrc { get; set; }
}
