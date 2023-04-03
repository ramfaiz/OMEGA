using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("STATUS_REF")]
[Index("StatusId", Name = "index_name_st")]
public partial class StatusRef
{
    [Key]
    [Column("status_id")]
    public short StatusId { get; set; }

    [Column("status_desc")]
    [StringLength(240)]
    [Unicode(false)]
    public string? StatusDesc { get; set; }

    [Column("is_review_flag")]
    public byte? IsReviewFlag { get; set; }

    [Column("next_status_id")]
    public byte? NextStatusId { get; set; }

    [Column("is_completed")]
    public byte? IsCompleted { get; set; }

    [Column("is_submitted")]
    public byte? IsSubmitted { get; set; }
}
