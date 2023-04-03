using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class OmVwCustWorkingOrd
{
    [Column("order_id")]
    public long OrderId { get; set; }

    [Column("master_account_no")]
    public long? MasterAccountNo { get; set; }

    [Column("status_id")]
    public short? StatusId { get; set; }

    [Column("status_reason_id")]
    public short? StatusReasonId { get; set; }

    [Column("emp_ref_no")]
    public long? EmpRefNo { get; set; }

    [Column("is_status_reason_completed")]
    public byte? IsStatusReasonCompleted { get; set; }

    [Column("is_status_completed")]
    public byte? IsStatusCompleted { get; set; }

    [Column("is_submitted")]
    public byte? IsSubmitted { get; set; }

    [Column("clarification_status")]
    public short? ClarificationStatus { get; set; }
}
