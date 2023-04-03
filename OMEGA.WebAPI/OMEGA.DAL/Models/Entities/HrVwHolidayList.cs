using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class HrVwHolidayList
{
    [Column("Holiday_Id")]
    public int HolidayId { get; set; }

    [Column("Holiday_Date", TypeName = "date")]
    public DateTime HolidayDate { get; set; }

    [Column("Holiday_Type_Id")]
    public short HolidayTypeId { get; set; }

    [Column("Holiday_Type")]
    [StringLength(50)]
    [Unicode(false)]
    public string? HolidayType { get; set; }

    [Column("Display_Value")]
    [StringLength(200)]
    public string? DisplayValue { get; set; }
}
