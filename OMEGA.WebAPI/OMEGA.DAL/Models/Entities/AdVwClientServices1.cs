using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class AdVwClientServices1
{
    [Column("CM_CUSTOMER_ID")]
    public int CmCustomerId { get; set; }

    [Column("CM_CUSTOMER_NAME")]
    [StringLength(50)]
    [Unicode(false)]
    public string CmCustomerName { get; set; } = null!;

    [Column("Services_Id")]
    public int? ServicesId { get; set; }

    [Column("Order_Acceptance")]
    public byte? OrderAcceptance { get; set; }

    [Column("Tmf_Assigning")]
    public byte? TmfAssigning { get; set; }

    [Column("Photo_Assigining")]
    public byte? PhotoAssigining { get; set; }

    [Column("Clarification_To_Client")]
    public byte? ClarificationToClient { get; set; }

    [Column("Clarification_To_Portal")]
    public byte? ClarificationToPortal { get; set; }

    public byte? Submission { get; set; }

    [Column("Revision_Submission")]
    public byte? RevisionSubmission { get; set; }

    [Column("CM_CUSTOMER_CODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string CmCustomerCode { get; set; } = null!;

    [Column("CM_DELETESTATUS")]
    public int CmDeletestatus { get; set; }
}
