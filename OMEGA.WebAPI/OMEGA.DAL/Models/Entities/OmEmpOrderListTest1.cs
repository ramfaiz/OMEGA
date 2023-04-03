﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class OmEmpOrderListTest1
{
    [Column("order_id")]
    public long OrderId { get; set; }

    [Column("order_date", TypeName = "datetime")]
    public DateTime? OrderDate { get; set; }

    [Column("emp_ref_no")]
    public long? EmpRefNo { get; set; }

    [Column("status_id")]
    public long? StatusId { get; set; }

    [Column("status_reason_id")]
    public long? StatusReasonId { get; set; }

    [Column("status_desc")]
    [StringLength(240)]
    [Unicode(false)]
    public string? StatusDesc { get; set; }

    [Column("status_reason_desc")]
    [StringLength(240)]
    [Unicode(false)]
    public string? StatusReasonDesc { get; set; }

    [Column("emp_first_name")]
    [StringLength(100)]
    public string? EmpFirstName { get; set; }

    [Column("start_datetime", TypeName = "datetime")]
    public DateTime? StartDatetime { get; set; }

    [Column("end_datetime", TypeName = "datetime")]
    public DateTime? EndDatetime { get; set; }

    [Column("ordertypename")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Ordertypename { get; set; }

    [Column("CM_CUSTOMER_NAME")]
    [StringLength(50)]
    [Unicode(false)]
    public string CmCustomerName { get; set; } = null!;

    [Column("subject_address")]
    [StringLength(500)]
    public string? SubjectAddress { get; set; }

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }

    [Column("priority_param_id")]
    public byte? PriorityParamId { get; set; }

    [Column("ord_revision_flag")]
    public byte? OrdRevisionFlag { get; set; }

    [Column("photo_req_status")]
    public short? PhotoReqStatus { get; set; }

    [Column("clarification_status")]
    public short? ClarificationStatus { get; set; }

    [Column("CM_CUSTOMER_CODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string CmCustomerCode { get; set; } = null!;

    [Column("master_account_no")]
    public long? MasterAccountNo { get; set; }

    [Column("c_status_desc")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CStatusDesc { get; set; }

    [Column("priority_param_desc")]
    [StringLength(150)]
    [Unicode(false)]
    public string? PriorityParamDesc { get; set; }

    [Column("is_ngl_client")]
    public byte? IsNglClient { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Urgency { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Priority { get; set; }

    [Column("is_review_checked")]
    public byte? IsReviewChecked { get; set; }

    [Column("order_urgency")]
    public byte? OrderUrgency { get; set; }

    [Column("order_priority")]
    public short? OrderPriority { get; set; }

    [Column("order_type")]
    public short? OrderType { get; set; }

    [Column("order_rev_no")]
    public long? OrderRevNo { get; set; }

    [Column("emp_priority")]
    public short? EmpPriority { get; set; }

    [Column("is_transfer")]
    public byte? IsTransfer { get; set; }

    [Column("photo_req_status_desc")]
    [StringLength(100)]
    [Unicode(false)]
    public string? PhotoReqStatusDesc { get; set; }

    [Column("is_qa_submit")]
    public byte? IsQaSubmit { get; set; }

    [Column("site_ref_no")]
    public long? SiteRefNo { get; set; }

    [Column("portal_name")]
    [StringLength(500)]
    public string? PortalName { get; set; }

    [Column("due_date")]
    [StringLength(30)]
    [Unicode(false)]
    public string? DueDate { get; set; }

    [Column("Is_Client_Submission")]
    public byte? IsClientSubmission { get; set; }

    [Column("hierarchy_id")]
    public long? HierarchyId { get; set; }

    [Column("subclient")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Subclient { get; set; }

    [Column("total_count")]
    public long? TotalCount { get; set; }
}
