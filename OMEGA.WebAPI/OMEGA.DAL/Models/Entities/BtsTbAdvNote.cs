using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("BTS_TB_ADV_NOTES")]
public partial class BtsTbAdvNote
{
    [Key]
    [Column("ref_no")]
    public long RefNo { get; set; }

    [Column("notes")]
    public string? Notes { get; set; }

    [Column("created_by")]
    public long? CreatedBy { get; set; }

    [Column("created_date", TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }
}
