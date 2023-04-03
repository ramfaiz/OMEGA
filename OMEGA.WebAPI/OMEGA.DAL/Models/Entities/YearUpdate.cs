using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("YEAR_UPDATE")]
public partial class YearUpdate
{
    [Key]
    [Column("item_id")]
    public int ItemId { get; set; }

    [Column("item_name")]
    [StringLength(50)]
    public string? ItemName { get; set; }

    [Column("year")]
    public int? Year { get; set; }

    [Column("status")]
    public short? Status { get; set; }

    [Column("updated_date", TypeName = "datetime")]
    public DateTime? UpdatedDate { get; set; }

    [Column("updated_by")]
    public long? UpdatedBy { get; set; }
}
