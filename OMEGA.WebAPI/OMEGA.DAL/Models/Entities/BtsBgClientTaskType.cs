using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("BTS_BG_ClientTaskTypes")]
public partial class BtsBgClientTaskType
{
    [Key]
    [Column("ID")]
    public long Id { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? TaskName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Abbreviation { get; set; }

    [Column("ClientID")]
    public long? ClientId { get; set; }

    public double? Fee { get; set; }

    public long? AssignTo { get; set; }

    /// <summary>
    /// 1- Active, 2- Deleted, 3- InActive
    /// </summary>
    public byte? Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AddedDate { get; set; }
}
