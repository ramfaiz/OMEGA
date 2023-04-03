using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("BTS_TB_CITY_MASTER")]
public partial class BtsTbCityMaster
{
    [Key]
    [Column("city_id")]
    public long CityId { get; set; }

    [Column("city_name")]
    public string? CityName { get; set; }

    [Column("state_id")]
    public long? StateId { get; set; }

    [Column("county_id")]
    public long? CountyId { get; set; }

    [Column("created_by")]
    public long? CreatedBy { get; set; }

    [Column("created_date", TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [Column("updated_by")]
    public long? UpdatedBy { get; set; }

    [Column("updated_date", TypeName = "datetime")]
    public DateTime? UpdatedDate { get; set; }

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }
}
