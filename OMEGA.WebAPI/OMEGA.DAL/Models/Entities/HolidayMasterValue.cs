using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[PrimaryKey("HolidayId", "LanguageCode")]
[Table("HOLIDAY_MASTER_VALUES")]
public partial class HolidayMasterValue
{
    [Key]
    [Column("Holiday_Id")]
    public int HolidayId { get; set; }

    [Key]
    [Column("Language_Code")]
    public short LanguageCode { get; set; }

    [Column("Display_Value")]
    [StringLength(200)]
    public string? DisplayValue { get; set; }

    [Column("Short_Display")]
    [StringLength(100)]
    public string? ShortDisplay { get; set; }

    [ForeignKey("HolidayId")]
    [InverseProperty("HolidayMasterValues")]
    public virtual HolidayMasterRef Holiday { get; set; } = null!;
}
