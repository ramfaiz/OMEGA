using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("BTS_TB_INVOICE_PAID_STATUS")]
public partial class BtsTbInvoicePaidStatus
{
    [Key]
    [Column("sl_no")]
    public int SlNo { get; set; }

    [Column("client_id")]
    public long? ClientId { get; set; }

    [Column("inv_id")]
    public long? InvId { get; set; }

    [Column("is_paid")]
    public short? IsPaid { get; set; }

    [Column("added_by")]
    public long? AddedBy { get; set; }

    [Column("added_date", TypeName = "datetime")]
    public DateTime? AddedDate { get; set; }

    [Column("updated_by")]
    public long? UpdatedBy { get; set; }

    [Column("updated_date", TypeName = "datetime")]
    public DateTime? UpdatedDate { get; set; }
}
