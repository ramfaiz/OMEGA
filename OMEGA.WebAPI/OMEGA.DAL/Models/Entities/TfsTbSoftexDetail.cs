using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("TFS_TB_SOFTEX_DETAILS")]
public partial class TfsTbSoftexDetail
{
    [Column("client_name")]
    public string? ClientName { get; set; }

    [Column("client_address")]
    public string? ClientAddress { get; set; }

    [Column("softex_no")]
    public long? SoftexNo { get; set; }

    [Column("invoice_no")]
    public string? InvoiceNo { get; set; }

    [Column("invoice_amt")]
    public double? InvoiceAmt { get; set; }

    [Column("invoice_date")]
    [StringLength(15)]
    public string? InvoiceDate { get; set; }
}
