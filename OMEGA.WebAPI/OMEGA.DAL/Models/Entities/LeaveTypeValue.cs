using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[PrimaryKey("LeaveTypeId", "LanguageCode")]
[Table("LEAVE_TYPE_VALUES")]
public partial class LeaveTypeValue
{
    [Key]
    [Column("leave_type_id")]
    public int LeaveTypeId { get; set; }

    [Key]
    [Column("language_code")]
    public short LanguageCode { get; set; }

    [Column("short_description")]
    [StringLength(100)]
    public string? ShortDescription { get; set; }

    [Column("display_value")]
    [StringLength(200)]
    public string? DisplayValue { get; set; }

    [ForeignKey("LeaveTypeId")]
    [InverseProperty("LeaveTypeValues")]
    public virtual LeaveTypeRef LeaveType { get; set; } = null!;
}
