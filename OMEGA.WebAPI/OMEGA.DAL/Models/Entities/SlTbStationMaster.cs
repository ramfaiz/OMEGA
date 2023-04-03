using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[PrimaryKey("SmStationId", "LanguageCode")]
[Table("SL_TB_STATION_MASTER")]
public partial class SlTbStationMaster
{
    [Key]
    [Column("SM_STATION_ID")]
    public int SmStationId { get; set; }

    [Column("SM_STATION_CODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string SmStationCode { get; set; } = null!;

    [Column("SM_STATION_NAME")]
    [StringLength(240)]
    [Unicode(false)]
    public string? SmStationName { get; set; }

    [Column("SM_MAIN_STATION")]
    public byte? SmMainStation { get; set; }

    [Column("SM_CREATEDBY")]
    public int? SmCreatedby { get; set; }

    [Column("SM_CREATEDDATE", TypeName = "datetime")]
    public DateTime? SmCreateddate { get; set; }

    [Column("SM_UPDATEDBY")]
    public int? SmUpdatedby { get; set; }

    [Column("SM_UPDATEDDATE", TypeName = "datetime")]
    public DateTime? SmUpdateddate { get; set; }

    [Column("SM_DELETESTATUS")]
    public byte? SmDeletestatus { get; set; }

    [Column("SM_ISPRODUCTABLE")]
    public byte? SmIsproductable { get; set; }

    [Column("ISDEFAULT")]
    public byte? Isdefault { get; set; }

    [Key]
    [Column("LANGUAGE_CODE")]
    public short LanguageCode { get; set; }

    [Column("LM_LOCATION_ID")]
    public int? LmLocationId { get; set; }

    [Column("COMP_STATUS")]
    public byte? CompStatus { get; set; }

    [Column("COMP_REGIST_TYPE")]
    public int? CompRegistType { get; set; }

    [Column("COMP_SOURCE_TYPE")]
    public int? CompSourceType { get; set; }

    [Column("COMP_IS_INTERNAL")]
    public byte? CompIsInternal { get; set; }

    [Column("COMP_REGN_NO")]
    [StringLength(50)]
    public string? CompRegnNo { get; set; }

    [Column("NRIC")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Nric { get; set; }

    [Column("UEN")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Uen { get; set; }

    [Column("FIN")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Fin { get; set; }

    [Column("SNO")]
    [StringLength(2)]
    [Unicode(false)]
    public string? Sno { get; set; }
}
