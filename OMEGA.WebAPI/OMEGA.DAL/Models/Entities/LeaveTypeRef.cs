using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("LEAVE_TYPE_REF")]
public partial class LeaveTypeRef
{
    [Key]
    [Column("leave_type_id")]
    public int LeaveTypeId { get; set; }

    [Column("leave_type_code")]
    [StringLength(50)]
    [Unicode(false)]
    public string LeaveTypeCode { get; set; } = null!;

    [Column("Leave_Type")]
    public short LeaveType { get; set; }

    [Column("total_days")]
    public short? TotalDays { get; set; }

    [Column("is_entitled")]
    public byte? IsEntitled { get; set; }

    [Column("is_default")]
    public byte? IsDefault { get; set; }

    [Column("created_by")]
    public short? CreatedBy { get; set; }

    [Column("created_date", TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [Column("updated_by")]
    public short? UpdatedBy { get; set; }

    [Column("updated_date", TypeName = "datetime")]
    public DateTime? UpdatedDate { get; set; }

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }

    [InverseProperty("LeaveType")]
    public virtual ICollection<LeaveTypeValue> LeaveTypeValues { get; } = new List<LeaveTypeValue>();
}
