using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class AdVwClientOrder
{
    [Column("order_id")]
    public long? OrderId { get; set; }

    [Column("order_date", TypeName = "datetime")]
    public DateTime? OrderDate { get; set; }

    [Column("order_rev_no")]
    public long? OrderRevNo { get; set; }

    [Column("master_account_no")]
    public long? MasterAccountNo { get; set; }

    [Column("hierarchy_id")]
    public long? HierarchyId { get; set; }

    [Column("subject_address")]
    public string? SubjectAddress { get; set; }

    [Column("state_id")]
    public long? StateId { get; set; }

    [Column("county_id")]
    public long? CountyId { get; set; }

    [Column("order_type")]
    public byte? OrderType { get; set; }

    [Column("order_urgency")]
    public byte? OrderUrgency { get; set; }

    [Column("order_priority")]
    public byte? OrderPriority { get; set; }

    [Column("clarification_status")]
    public short? ClarificationStatus { get; set; }

    [Column("photo_req_status")]
    public short? PhotoReqStatus { get; set; }

    [Column("status_id")]
    public short? StatusId { get; set; }

    [Column("status_reason_id")]
    public short? StatusReasonId { get; set; }

    [Column("org_ref_no")]
    public long? OrgRefNo { get; set; }

    [Column("comp_ref_no")]
    public long? CompRefNo { get; set; }

    [Column("emp_ref_no")]
    public long? EmpRefNo { get; set; }

    [Column("view_id")]
    public long? ViewId { get; set; }

    [Column("priority_param_id")]
    public byte? PriorityParamId { get; set; }

    [Column("emp_priority")]
    public short? EmpPriority { get; set; }

    [Column("remarks")]
    public string? Remarks { get; set; }

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }

    [Column("parentclientname")]
    [StringLength(100)]
    public string? Parentclientname { get; set; }

    [Column("childclientname")]
    [StringLength(100)]
    public string? Childclientname { get; set; }

    [Column("ordertypename")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Ordertypename { get; set; }

    [Column("site_ref_no")]
    public long? SiteRefNo { get; set; }
}
