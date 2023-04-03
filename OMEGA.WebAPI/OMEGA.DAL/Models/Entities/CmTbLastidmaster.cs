using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[PrimaryKey("LmCountername", "AdFinFinyrid")]
[Table("CM_TB_LASTIDMASTER")]
public partial class CmTbLastidmaster
{
    [Key]
    [Column("LM_COUNTERNAME")]
    [StringLength(50)]
    [Unicode(false)]
    public string LmCountername { get; set; } = null!;

    [Column("LM_LASTCOUNT", TypeName = "numeric(15, 0)")]
    public decimal LmLastcount { get; set; }

    [Column("LM_COUNTERDESC")]
    [StringLength(50)]
    [Unicode(false)]
    public string? LmCounterdesc { get; set; }

    [Column("LM_PRECODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string? LmPrecode { get; set; }

    [Column("LM_CODELENGTH")]
    public int? LmCodelength { get; set; }

    [Key]
    [Column("AD_FIN_FINYRID")]
    public short AdFinFinyrid { get; set; }

    [Column("LM_TBLFLAG")]
    public bool? LmTblflag { get; set; }

    [Column("LM_MM")]
    public byte? LmMm { get; set; }

    [Column("LM_DD")]
    public byte? LmDd { get; set; }
}
