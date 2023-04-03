using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("TFS_TB_INVOICE_CODE_MASTER")]
public partial class TfsTbInvoiceCodeMaster
{
    [Column("company_id")]
    public short? CompanyId { get; set; }

    [Column("inv_no")]
    [StringLength(50)]
    public string? InvNo { get; set; }

    [Column("updated_date", TypeName = "datetime")]
    public DateTime? UpdatedDate { get; set; }

    [Column("updated_by")]
    public int? UpdatedBy { get; set; }
}
