using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("SL_TB_INVOICE_MASTER")]
public partial class SlTbInvoiceMaster
{
    [Column("INV_ID")]
    public int InvId { get; set; }

    [Column("INV_CODE")]
    [StringLength(150)]
    public string? InvCode { get; set; }

    [Column("CUSTOMER_ID")]
    public int CustomerId { get; set; }

    [Column("INV_AMOUNT")]
    public float? InvAmount { get; set; }

    [Column("REMARKS")]
    [StringLength(150)]
    public string? Remarks { get; set; }

    [Column("INV_FROMDATE", TypeName = "datetime")]
    public DateTime? InvFromdate { get; set; }

    [Column("INV_TODATE", TypeName = "datetime")]
    public DateTime? InvTodate { get; set; }

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

    [Column("INV_NO")]
    [StringLength(150)]
    public string? InvNo { get; set; }

    [Column("COMPANY_ID")]
    [StringLength(50)]
    public string? CompanyId { get; set; }

    [Column("is_bts")]
    public int? IsBts { get; set; }

    [Column("is_SMS")]
    public int? IsSms { get; set; }
}
