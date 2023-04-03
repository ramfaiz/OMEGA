using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class AdVwFinyearNewFinyid
{
    [Column("FIN_YEARID")]
    public long FinYearid { get; set; }

    [Column("CM_OWNING_COST_ID")]
    public int? CmOwningCostId { get; set; }

    [Column("FIN_CLOSE_FLAG")]
    public bool? FinCloseFlag { get; set; }
}
