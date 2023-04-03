using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class RptVwPicWaiting
{
    [Column("subclient")]
    [StringLength(100)]
    public string? Subclient { get; set; }

    [Column("due_date")]
    [StringLength(30)]
    [Unicode(false)]
    public string? DueDate { get; set; }

    [Column("subject_address")]
    public string? SubjectAddress { get; set; }

    [Column("ordertypename")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Ordertypename { get; set; }

    [Column("portal_name")]
    [StringLength(500)]
    public string? PortalName { get; set; }

    [Column("photo_req_status")]
    public short? PhotoReqStatus { get; set; }

    [Column("status_id")]
    public short? StatusId { get; set; }

    [Column("status_reason_id")]
    public short? StatusReasonId { get; set; }

    [Column("delete_status")]
    public byte DeleteStatus { get; set; }

    [Column("master_account_no")]
    public long? MasterAccountNo { get; set; }

    [Column("hierarchy_id")]
    public long? HierarchyId { get; set; }

    [Column("comment")]
    [StringLength(3)]
    [Unicode(false)]
    public string Comment { get; set; } = null!;

    [Column("order_date", TypeName = "datetime")]
    public DateTime? OrderDate { get; set; }
}
