using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("SL_TB_DISTRICT_MASTER")]
public partial class SlTbDistrictMaster
{
    [Key]
    [Column("DM_DISTRICT_ID")]
    public int DmDistrictId { get; set; }

    [Column("DM_DISTRICT_CODE")]
    [StringLength(15)]
    [Unicode(false)]
    public string DmDistrictCode { get; set; } = null!;

    [Column("DM_DISTRICT_NAME")]
    [StringLength(50)]
    [Unicode(false)]
    public string DmDistrictName { get; set; } = null!;

    [Column("EM_EMIRATE_ID")]
    public int EmEmirateId { get; set; }

    [Column("DM_CREATED_BY")]
    public int? DmCreatedBy { get; set; }

    [Column("DM_CREATED_DATE", TypeName = "datetime")]
    public DateTime? DmCreatedDate { get; set; }

    [Column("DM_UPDATED_BY")]
    public int? DmUpdatedBy { get; set; }

    [Column("DM_UPDATED_DATE", TypeName = "datetime")]
    public DateTime? DmUpdatedDate { get; set; }

    [Column("deleteflag")]
    public byte Deleteflag { get; set; }

    [Column("country_code")]
    public int? CountryCode { get; set; }

    [InverseProperty("DmDistrict")]
    public virtual ICollection<SlTbDistrictValue> SlTbDistrictValues { get; } = new List<SlTbDistrictValue>();
}
