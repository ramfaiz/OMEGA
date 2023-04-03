using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("AUTO_BPO_STATUS_REF")]
public partial class AutoBpoStatusRef
{
    [Key]
    [Column("auto_bpo_status_id")]
    public int AutoBpoStatusId { get; set; }

    [Column("auto_bpo_status_desc")]
    [StringLength(50)]
    public string? AutoBpoStatusDesc { get; set; }
}
