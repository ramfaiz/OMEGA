using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("SL_TB_AREA_MASTER")]
public partial class SlTbAreaMaster
{
    [Key]
    [Column("AM_AREA_ID")]
    public int AmAreaId { get; set; }

    [Column("AM_AREA_CODE")]
    [StringLength(15)]
    [Unicode(false)]
    public string AmAreaCode { get; set; } = null!;

    [Column("AM_AREA_NAME")]
    [StringLength(50)]
    [Unicode(false)]
    public string AmAreaName { get; set; } = null!;

    [Column("DM_DISTRICT_ID")]
    public int? DmDistrictId { get; set; }

    [Column("EM_EMIRATE_ID")]
    public int? EmEmirateId { get; set; }

    [Column("AM_CREATED_BY")]
    public int? AmCreatedBy { get; set; }

    [Column("AM_CREATED_DATE", TypeName = "datetime")]
    public DateTime? AmCreatedDate { get; set; }

    [Column("AM_UPDATED_BY")]
    public int? AmUpdatedBy { get; set; }

    [Column("AM_UPDATED_DATE", TypeName = "datetime")]
    public DateTime? AmUpdatedDate { get; set; }

    [Column("AM_ZONE_NAME")]
    [StringLength(50)]
    [Unicode(false)]
    public string? AmZoneName { get; set; }

    [Column("AM_REF_CODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string? AmRefCode { get; set; }

    [Column("AM_LAND_MARK")]
    [StringLength(100)]
    [Unicode(false)]
    public string? AmLandMark { get; set; }

    [Column("deleteflag")]
    public byte Deleteflag { get; set; }

    [Column("country_code")]
    public int? CountryCode { get; set; }

    [InverseProperty("AmArea")]
    public virtual ICollection<SlTbAreaValue> SlTbAreaValues { get; } = new List<SlTbAreaValue>();
}
