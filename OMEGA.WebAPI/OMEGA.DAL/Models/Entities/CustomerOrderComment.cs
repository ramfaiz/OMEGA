using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("CUSTOMER_ORDER_COMMENTS")]
public partial class CustomerOrderComment
{
    [Key]
    [Column("comment_id")]
    public long CommentId { get; set; }

    [Column("order_id")]
    public long? OrderId { get; set; }

    [Column("cmt_date_time", TypeName = "datetime")]
    public DateTime? CmtDateTime { get; set; }

    [Column("posted_by")]
    public long? PostedBy { get; set; }

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
}
