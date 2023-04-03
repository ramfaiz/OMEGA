using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class RptVwInvoiceReportOld
{
    [Column("INV_ID")]
    public int InvId { get; set; }

    [Column("order_id")]
    public int? OrderId { get; set; }

    [Column("order_date", TypeName = "datetime")]
    public DateTime? OrderDate { get; set; }

    [Column("subject_address")]
    [StringLength(500)]
    public string? SubjectAddress { get; set; }

    [Column("site_ref_no")]
    public long? SiteRefNo { get; set; }

    [StringLength(500)]
    public string? DisplayValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? OrderTypeName { get; set; }
}
