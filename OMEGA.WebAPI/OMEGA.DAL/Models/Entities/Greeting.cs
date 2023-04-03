using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("GREETINGS")]
public partial class Greeting
{
    [Key]
    [Column("greeting_id")]
    public long GreetingId { get; set; }

    [Column("emp_ref_no")]
    public long? EmpRefNo { get; set; }

    [Column("message")]
    [StringLength(100)]
    public string? Message { get; set; }

    [Column("year")]
    public int? Year { get; set; }

    [Column("send_ignore")]
    public short? SendIgnore { get; set; }
}
