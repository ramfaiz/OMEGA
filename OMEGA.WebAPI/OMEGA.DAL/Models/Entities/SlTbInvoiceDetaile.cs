using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("SL_TB_INVOICE_DETAILES")]
[Index("InvId", Name = "missing_index_13675_13674_SL_TB_INVOICE_DETAILES")]
public partial class SlTbInvoiceDetaile
{
    [Column("IDET_ID")]
    public int IdetId { get; set; }

    [Column("INV_ID")]
    public int InvId { get; set; }

    [Column("order_id")]
    public int? OrderId { get; set; }

    [Column("CREATEDBY")]
    public int? Createdby { get; set; }

    [Column("CREATEDDATE", TypeName = "datetime")]
    public DateTime? Createddate { get; set; }

    [Column("UPDATEDBY")]
    public int? Updatedby { get; set; }

    [Column("UPDATEDDATE", TypeName = "datetime")]
    public DateTime? Updateddate { get; set; }

    [Column("DELETESTATUS")]
    public int? Deletestatus { get; set; }
}
