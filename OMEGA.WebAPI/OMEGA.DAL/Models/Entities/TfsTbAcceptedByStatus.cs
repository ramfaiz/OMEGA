using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("TFS_TB_ACCEPTED_BY_STATUS")]
public partial class TfsTbAcceptedByStatus
{
    [Column("accepted_by_id")]
    public int? AcceptedById { get; set; }

    [Column("accepted_by")]
    public string? AcceptedBy { get; set; }
}
