using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("TFS_TB_AUTO_BPO_BED")]
public partial class TfsTbAutoBpoBed
{
    [Column("sl_no")]
    public int SlNo { get; set; }

    [Column("order_id")]
    public long? OrderId { get; set; }

    [Column("bed")]
    public int? Bed { get; set; }

    [Column("bath")]
    public double? Bath { get; set; }

    [Column("gla")]
    public int? Gla { get; set; }

    [Column("lot_size")]
    public double? LotSize { get; set; }

    [Column("year_built")]
    public int? YearBuilt { get; set; }

    [Column("prior_value")]
    public int? PriorValue { get; set; }

    [Column("purchase_price")]
    public int? PurchasePrice { get; set; }

    [Column("created_date", TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [Column("created_by")]
    public long? CreatedBy { get; set; }

    [Column("updated_date", TypeName = "datetime")]
    public DateTime? UpdatedDate { get; set; }

    [Column("updated_by")]
    public long? UpdatedBy { get; set; }
}
