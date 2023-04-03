using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("HR_TB_DOCUMENT_MASTER_REF")]
public partial class HrTbDocumentMasterRef
{
    [Key]
    [Column("document_id")]
    public long DocumentId { get; set; }

    [Column("document_type")]
    [StringLength(5)]
    [Unicode(false)]
    public string DocumentType { get; set; } = null!;

    [Column("bill_period")]
    public long? BillPeriod { get; set; }

    [Column("org_id")]
    public int? OrgId { get; set; }

    [Column("company_id")]
    public int? CompanyId { get; set; }

    [Column("total_records_done")]
    public int? TotalRecordsDone { get; set; }

    [Column("file_name")]
    [StringLength(154)]
    [Unicode(false)]
    public string? FileName { get; set; }

    [Column("created_on", TypeName = "datetime")]
    public DateTime? CreatedOn { get; set; }

    [Column("created_by")]
    public int? CreatedBy { get; set; }

    [Column("last_updated_on", TypeName = "datetime")]
    public DateTime? LastUpdatedOn { get; set; }

    [Column("last_updated_by")]
    public int? LastUpdatedBy { get; set; }
}
