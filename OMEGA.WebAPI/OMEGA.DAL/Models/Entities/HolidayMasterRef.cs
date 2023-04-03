using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("HOLIDAY_MASTER_REF")]
public partial class HolidayMasterRef
{
    [Key]
    [Column("Holiday_Id")]
    public int HolidayId { get; set; }

    [Column("Holiday_Date", TypeName = "date")]
    public DateTime HolidayDate { get; set; }

    [Column("Holiday_Day")]
    public short HolidayDay { get; set; }

    [Column("Holiday_Type")]
    public short HolidayType { get; set; }

    [Column("Special_Working_Hrs")]
    [StringLength(50)]
    [Unicode(false)]
    public string? SpecialWorkingHrs { get; set; }

    [Column("Created_By")]
    public short? CreatedBy { get; set; }

    [Column("Created_Date", TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [Column("Updated_By")]
    public short? UpdatedBy { get; set; }

    [Column("Updated_Date", TypeName = "datetime")]
    public DateTime? UpdatedDate { get; set; }

    [Column("Delete_Status")]
    public byte? DeleteStatus { get; set; }

    [InverseProperty("Holiday")]
    public virtual ICollection<HolidayMasterValue> HolidayMasterValues { get; } = new List<HolidayMasterValue>();
}
