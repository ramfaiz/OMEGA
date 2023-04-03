using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class BtsVwZipcodeMaster
{
    [Column("city_id")]
    public long CityId { get; set; }

    [Column("city_name")]
    public string? CityName { get; set; }

    [Column("state_id")]
    public long? StateId { get; set; }

    [Column("state_name")]
    [StringLength(500)]
    public string? StateName { get; set; }

    [Column("county_id")]
    public long? CountyId { get; set; }

    [Column("county_name")]
    [StringLength(500)]
    public string? CountyName { get; set; }

    [Column("zip_id")]
    public long ZipId { get; set; }

    [Column("zip_code")]
    [StringLength(50)]
    public string? ZipCode { get; set; }

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }
}
