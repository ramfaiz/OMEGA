using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("TFS_TB_ACCEPTED_BY_LIST")]
public partial class TfsTbAcceptedByList
{
    [Column("order_date", TypeName = "datetime")]
    public DateTime? OrderDate { get; set; }

    [Column("full_name")]
    public string? FullName { get; set; }

    [Column("subclient")]
    public string? Subclient { get; set; }

    [Column("subject_address")]
    public string? SubjectAddress { get; set; }

    [Column("portal_name")]
    public string? PortalName { get; set; }

    [Column("status")]
    public string? Status { get; set; }

    [Column("status_reason")]
    public string? StatusReason { get; set; }

    [Column("from_date", TypeName = "datetime")]
    public DateTime? FromDate { get; set; }

    [Column("to_date", TypeName = "datetime")]
    public DateTime? ToDate { get; set; }

    [Column("accepted_by")]
    public string? AcceptedBy { get; set; }
}
