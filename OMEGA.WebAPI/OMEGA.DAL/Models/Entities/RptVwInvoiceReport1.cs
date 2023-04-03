using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class RptVwInvoiceReport1
{
    [Column("full_name")]
    [StringLength(100)]
    public string? FullName { get; set; }

    [Column("INV_ID")]
    public int InvId { get; set; }

    [Column("order_id")]
    public int? OrderId { get; set; }

    [Column("order_date", TypeName = "datetime")]
    public DateTime? OrderDate { get; set; }

    [Column("subject_address")]
    public string? SubjectAddress { get; set; }

    [Column("site_ref_no")]
    public long? SiteRefNo { get; set; }

    [StringLength(500)]
    public string? DisplayValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? OrderTypeName { get; set; }

    [Column("company_name")]
    public string? CompanyName { get; set; }

    [Column("company_address")]
    public string? CompanyAddress { get; set; }

    [Column("GST")]
    public string? Gst { get; set; }

    [Column("payment_name")]
    [StringLength(15)]
    public string? PaymentName { get; set; }

    public string? ClientAddress { get; set; }
}
