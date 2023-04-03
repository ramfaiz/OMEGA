using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class OmVwComments1
{
    [Column("comment_id")]
    public long CommentId { get; set; }

    [Column("order_id")]
    public long? OrderId { get; set; }

    [Column("cmt_date_time")]
    [StringLength(19)]
    [Unicode(false)]
    public string? CmtDateTime { get; set; }

    [Column("posted_by")]
    public long? PostedBy { get; set; }

    [Column("emp_first_name")]
    [StringLength(101)]
    public string? EmpFirstName { get; set; }

    [Column("comments")]
    public string? Comments { get; set; }

    [Column("rev_comments")]
    public string? RevComments { get; set; }

    [Column("rev_issue_by")]
    [StringLength(500)]
    public string? RevIssueBy { get; set; }

    [Column("updated_by")]
    public long? UpdatedBy { get; set; }

    [Column("updated_date", TypeName = "datetime")]
    public DateTime? UpdatedDate { get; set; }

    [Column("parent_ord_id")]
    public int? ParentOrdId { get; set; }

    [Column("subject_address")]
    public string? SubjectAddress { get; set; }
}
