using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class AdFinYr
{
    [Column("FIN_YEARID")]
    public long FinYearid { get; set; }

    [Column("FIN_FINYEAR")]
    [StringLength(15)]
    [Unicode(false)]
    public string FinFinyear { get; set; } = null!;

    [Column("FIN_COMPANY_CODE")]
    public long FinCompanyCode { get; set; }

    [Column("FIN_FROM_DATE", TypeName = "datetime")]
    public DateTime? FinFromDate { get; set; }

    [Column("FIN_TO_DATE", TypeName = "datetime")]
    public DateTime? FinToDate { get; set; }
}
