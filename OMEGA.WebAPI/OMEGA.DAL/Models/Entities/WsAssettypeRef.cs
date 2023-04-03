using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("WS_ASSETTYPE_REF")]
public partial class WsAssettypeRef
{
    [Key]
    [Column("Asset_Type_Id")]
    public int AssetTypeId { get; set; }

    [Column("Asset_Type_Code")]
    [StringLength(50)]
    [Unicode(false)]
    public string? AssetTypeCode { get; set; }

    [Column("Created_By")]
    public short? CreatedBy { get; set; }

    [Column("Created_Date", TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [Column("Updated_By")]
    public short? UpdatedBy { get; set; }

    [Column("Updated_Date", TypeName = "datetime")]
    public DateTime? UpdatedDate { get; set; }

    [Column("Is_Default")]
    public short? IsDefault { get; set; }

    [Column("Delete_Status")]
    public short? DeleteStatus { get; set; }
}
