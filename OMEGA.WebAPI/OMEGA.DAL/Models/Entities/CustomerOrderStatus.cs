using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("CUSTOMER_ORDER_STATUS")]
public partial class CustomerOrderStatus
{
    [Key]
    [Column("view_id")]
    public long ViewId { get; set; }

    [Column("order_id")]
    public long OrderId { get; set; }

    [Column("org_ref_no")]
    public long? OrgRefNo { get; set; }

    [Column("comp_ref_no")]
    public long? CompRefNo { get; set; }

    [Column("emp_ref_no")]
    public long? EmpRefNo { get; set; }

    [Column("status_type")]
    public byte? StatusType { get; set; }

    [Column("status_id")]
    public long? StatusId { get; set; }

    [Column("status_reason_id")]
    public long? StatusReasonId { get; set; }

    [Column("start_datetime", TypeName = "datetime")]
    public DateTime? StartDatetime { get; set; }

    [Column("end_datetime", TypeName = "datetime")]
    public DateTime? EndDatetime { get; set; }

    [Column("view_status")]
    public byte? ViewStatus { get; set; }

    [Column("is_photo_upload")]
    public int? IsPhotoUpload { get; set; }

    [Column("is_redo_revision")]
    public byte? IsRedoRevision { get; set; }

    [Column("for_emp_ref_no")]
    public long? ForEmpRefNo { get; set; }
}
