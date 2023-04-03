using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("SHIFT_SET_STATUS")]
public partial class ShiftSetStatus
{
    [Key]
    [Column("shift_status_id")]
    public int ShiftStatusId { get; set; }

    [Column("month")]
    public int? Month { get; set; }

    [Column("year")]
    public int? Year { get; set; }

    [Column("updated_date", TypeName = "datetime")]
    public DateTime? UpdatedDate { get; set; }

    [Column("updated_by")]
    public long? UpdatedBy { get; set; }

    [Column("status_Production")]
    public short? StatusProduction { get; set; }

    [Column("status_Communication")]
    public short? StatusCommunication { get; set; }

    [Column("status_Quality")]
    public short? StatusQuality { get; set; }

    [Column("status_Software")]
    public short? StatusSoftware { get; set; }

    [Column("status_Nagercoil")]
    public short? StatusNagercoil { get; set; }
}
