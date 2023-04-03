using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("SL_TB_EMIRATE_MASTER")]
public partial class SlTbEmirateMaster
{
    [Key]
    [Column("EM_EMIRATE_ID")]
    public int EmEmirateId { get; set; }

    [Column("EM_EMIRATE_CODE")]
    [StringLength(15)]
    [Unicode(false)]
    public string EmEmirateCode { get; set; } = null!;

    [Column("EM_EMIRATE_NAME")]
    [StringLength(50)]
    [Unicode(false)]
    public string EmEmirateName { get; set; } = null!;

    [Column("EM_CREATED_BY")]
    public int? EmCreatedBy { get; set; }

    [Column("EM_CREATED_DATE", TypeName = "datetime")]
    public DateTime? EmCreatedDate { get; set; }

    [Column("EM_UPDATED_BY")]
    public int? EmUpdatedBy { get; set; }

    [Column("EM_UPDATED_DATE", TypeName = "datetime")]
    public DateTime? EmUpdatedDate { get; set; }

    [Column("deleteflag")]
    public byte Deleteflag { get; set; }

    [Column("country_code")]
    public int CountryCode { get; set; }

    [InverseProperty("EmEmirate")]
    public virtual ICollection<SlTbEmirateValue> SlTbEmirateValues { get; } = new List<SlTbEmirateValue>();
}
