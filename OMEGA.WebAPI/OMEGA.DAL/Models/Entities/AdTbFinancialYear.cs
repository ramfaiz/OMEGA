using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("AD_TB_FINANCIAL_YEAR")]
public partial class AdTbFinancialYear
{
    [Key]
    [Column("FIN_YEARID")]
    public long FinYearid { get; set; }

    [Column("FIN_FINYEAR")]
    [StringLength(15)]
    [Unicode(false)]
    public string FinFinyear { get; set; } = null!;

    [Column("FIN_COMPANY_CODE")]
    public long FinCompanyCode { get; set; }

    [Column("FIN_SL_NO")]
    public int? FinSlNo { get; set; }

    [Column("FIN_FROM_DATE", TypeName = "datetime")]
    public DateTime? FinFromDate { get; set; }

    [Column("FIN_TO_DATE", TypeName = "datetime")]
    public DateTime? FinToDate { get; set; }

    [Column("FIN_CLOSE_FLAG")]
    public bool? FinCloseFlag { get; set; }

    [Column("FIN_CREATEDBY")]
    public long? FinCreatedby { get; set; }

    [Column("FIN_CREATEDATE", TypeName = "datetime")]
    public DateTime? FinCreatedate { get; set; }

    [Column("FIN_DBSHEMA")]
    [StringLength(30)]
    [Unicode(false)]
    public string? FinDbshema { get; set; }
}
