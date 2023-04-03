using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("SL_TB_INVOICE_AMOUNT_1")]
public partial class SlTbInvoiceAmount1
{
    [Column("IAMT_ID")]
    public int IamtId { get; set; }

    [Column("INV_ID")]
    public int InvId { get; set; }

    [Column("ORDER_TYPE_ID")]
    public int? OrderTypeId { get; set; }

    [Column("ORDER_TYPE_NAME")]
    [StringLength(150)]
    public string? OrderTypeName { get; set; }

    [Column("ORDER_UNIT_AMOUNT")]
    public float? OrderUnitAmount { get; set; }

    [Column("ORDER_TYPE_COUNT")]
    public int? OrderTypeCount { get; set; }

    [Column("ORDER_TYPE_AMOUNT")]
    public float? OrderTypeAmount { get; set; }

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
