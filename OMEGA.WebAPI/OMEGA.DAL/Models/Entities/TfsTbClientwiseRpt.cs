using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("TFS_TB_CLIENTWISE_RPT")]
public partial class TfsTbClientwiseRpt
{
    [Column("ref_no")]
    public int? RefNo { get; set; }

    [Column("Full_name")]
    [StringLength(100)]
    public string? FullName { get; set; }

    [Column("Subject_address")]
    public string? SubjectAddress { get; set; }

    [Column("Order_date", TypeName = "datetime")]
    public DateTime? OrderDate { get; set; }

    [Column("Order_type")]
    public string? OrderType { get; set; }

    public string? Portal { get; set; }

    [Column("Status_desc")]
    public string? StatusDesc { get; set; }

    [Column("Status_Reason")]
    public string? StatusReason { get; set; }

    public string? Zipcode { get; set; }

    [Column("state_abb")]
    public string? StateAbb { get; set; }
}
