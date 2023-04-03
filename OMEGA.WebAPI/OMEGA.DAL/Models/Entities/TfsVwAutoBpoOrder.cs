using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class TfsVwAutoBpoOrder
{
    [Column("order_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? OrderNo { get; set; }

    [Column("order_date", TypeName = "datetime")]
    public DateTime? OrderDate { get; set; }

    [Column("due_date")]
    [StringLength(30)]
    [Unicode(false)]
    public string? DueDate { get; set; }

    [Column("auto_bpo_status_id")]
    public int? AutoBpoStatusId { get; set; }

    [Column("photo_req_status_desc")]
    [StringLength(100)]
    [Unicode(false)]
    public string? PhotoReqStatusDesc { get; set; }

    [Column("subject_address")]
    public string? SubjectAddress { get; set; }

    [Column("portal_name")]
    [StringLength(500)]
    public string? PortalName { get; set; }

    [Column("subclient")]
    [StringLength(100)]
    public string? Subclient { get; set; }

    [Column("master_account_no")]
    public long? MasterAccountNo { get; set; }

    [Column("order_id")]
    public long OrderId { get; set; }

    [Column("full_name")]
    [StringLength(100)]
    public string? FullName { get; set; }

    [Column("emp_first_name")]
    [StringLength(101)]
    public string? EmpFirstName { get; set; }

    [Column("status_desc")]
    [StringLength(240)]
    [Unicode(false)]
    public string? StatusDesc { get; set; }

    [Column("status_reason_desc")]
    [StringLength(240)]
    [Unicode(false)]
    public string? StatusReasonDesc { get; set; }

    [Column("updated_date", TypeName = "datetime")]
    public DateTime? UpdatedDate { get; set; }

    [Column("delete_status")]
    public byte DeleteStatus { get; set; }

    [Column("ordertypename")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Ordertypename { get; set; }

    [Column("auto_bpo_status_desc")]
    [StringLength(50)]
    public string? AutoBpoStatusDesc { get; set; }

    [Column("status_id")]
    public short? StatusId { get; set; }

    [Column("status_reason_id")]
    public short? StatusReasonId { get; set; }

    [Column("order_posted_by")]
    [StringLength(500)]
    public string? OrderPostedBy { get; set; }

    [Column("hierarchy_id")]
    public long? HierarchyId { get; set; }

    [Column("order_due_date")]
    [StringLength(30)]
    [Unicode(false)]
    public string? OrderDueDate { get; set; }
}
