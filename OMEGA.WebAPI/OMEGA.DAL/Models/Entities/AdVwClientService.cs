using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class AdVwClientService
{
    [Column("ref_no")]
    public long RefNo { get; set; }

    [Column("full_name")]
    [StringLength(100)]
    public string? FullName { get; set; }

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

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }
}
