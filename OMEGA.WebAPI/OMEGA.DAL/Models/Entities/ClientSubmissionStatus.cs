using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("Client_Submission_Status")]
public partial class ClientSubmissionStatus
{
    [Column("ref_no")]
    public int? RefNo { get; set; }

    [Column("assignee")]
    public string? Assignee { get; set; }

    [Column("status")]
    public string? Status { get; set; }
}
