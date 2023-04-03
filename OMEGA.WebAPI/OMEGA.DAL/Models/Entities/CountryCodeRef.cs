using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("COUNTRY_CODE_REF")]
public partial class CountryCodeRef
{
    [Key]
    [Column("country_id")]
    public int CountryId { get; set; }

    [Column("country_code")]
    [StringLength(50)]
    public string CountryCode { get; set; } = null!;

    [Column("is_default")]
    public byte IsDefault { get; set; }

    [Column("created_by")]
    public int? CreatedBy { get; set; }

    [Column("created_date", TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [Column("updated_by")]
    public int? UpdatedBy { get; set; }

    [Column("updated_date", TypeName = "datetime")]
    public DateTime? UpdatedDate { get; set; }

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }

    [Column("country_iras_code")]
    public int? CountryIrasCode { get; set; }
}
