using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class WsVwLeavelist
{
    [Column("leave_type_id")]
    public int LeaveTypeId { get; set; }

    [Column("Leave_Type")]
    public short LeaveType { get; set; }

    [Column("leave_type_code")]
    [StringLength(50)]
    [Unicode(false)]
    public string LeaveTypeCode { get; set; } = null!;

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }

    [Column("is_default")]
    public byte? IsDefault { get; set; }

    [Column("display_value")]
    [StringLength(200)]
    public string? DisplayValue { get; set; }

    [Column("short_display")]
    [StringLength(100)]
    public string? ShortDisplay { get; set; }

    [Column("language_code")]
    public short LanguageCode { get; set; }
}
