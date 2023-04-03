using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("HOLIDAY_TYPE")]
public partial class HolidayType
{
    [Key]
    [Column("Holiday_Type_Id")]
    public int HolidayTypeId { get; set; }

    [Column("Holiday_Type")]
    [StringLength(50)]
    [Unicode(false)]
    public string? HolidayType1 { get; set; }
}
