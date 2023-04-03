using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("BTS_TB_ZIPCODE_MASTER")]
[Index("DeleteStatus", Name = "missing_index_23964_23963_BTS_TB_ZIPCODE_MASTER")]
[Index("ZipCode", Name = "missing_index_80_79_BTS_TB_ZIPCODE_MASTER")]
public partial class BtsTbZipcodeMaster
{
    [Key]
    [Column("zip_id")]
    public long ZipId { get; set; }

    [Column("zip_code")]
    [StringLength(50)]
    public string? ZipCode { get; set; }

    [Column("state_id")]
    public long? StateId { get; set; }

    [Column("county_id")]
    public long? CountyId { get; set; }

    [Column("city_id")]
    public long? CityId { get; set; }

    [Column("latitude", TypeName = "numeric(18, 4)")]
    public decimal? Latitude { get; set; }

    [Column("longitude", TypeName = "numeric(18, 4)")]
    public decimal? Longitude { get; set; }

    [Column("created_date", TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [Column("created_by")]
    public long? CreatedBy { get; set; }

    [Column("updated_date", TypeName = "datetime")]
    public DateTime? UpdatedDate { get; set; }

    [Column("updated_by")]
    public long? UpdatedBy { get; set; }

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }
}
