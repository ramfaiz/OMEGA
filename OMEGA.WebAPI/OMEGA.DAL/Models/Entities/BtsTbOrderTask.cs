using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("BTS_TB_ORDER_TASKS")]
public partial class BtsTbOrderTask
{
    [Key]
    [Column("sl_no")]
    public int SlNo { get; set; }

    [Column("order_id")]
    public long? OrderId { get; set; }

    [Column("data_status")]
    public int? DataStatus { get; set; }

    [Column("data_fee")]
    public double? DataFee { get; set; }

    [Column("data_updated_by")]
    public long? DataUpdatedBy { get; set; }

    [Column("data_updated_date", TypeName = "datetime")]
    public DateTime? DataUpdatedDate { get; set; }

    [Column("photo_status")]
    public int? PhotoStatus { get; set; }

    [Column("photo_fee")]
    public double? PhotoFee { get; set; }

    [Column("photo_updated_by")]
    public long? PhotoUpdatedBy { get; set; }

    [Column("photo_updated_date")]
    [StringLength(10)]
    public string? PhotoUpdatedDate { get; set; }

    [Column("created_date", TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [Column("created_by")]
    public long? CreatedBy { get; set; }
}
