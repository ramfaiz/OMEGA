using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("ERROR_LOG_1")]
public partial class ErrorLog1
{
    [Key]
    [Column("log_id")]
    public long LogId { get; set; }

    [Column("log_date", TypeName = "datetime")]
    public DateTime? LogDate { get; set; }

    [Column("message")]
    [StringLength(4000)]
    [Unicode(false)]
    public string? Message { get; set; }

    [Column("inner_exception")]
    [StringLength(4000)]
    [Unicode(false)]
    public string? InnerException { get; set; }

    [Column("source")]
    [StringLength(4000)]
    [Unicode(false)]
    public string? Source { get; set; }

    [Column("stack_trace")]
    [Unicode(false)]
    public string? StackTrace { get; set; }
}
