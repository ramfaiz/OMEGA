using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class TlVwSelectMarketList
{
    [Column("DM_DISTRICT_ID")]
    public int DmDistrictId { get; set; }

    [Column("DM_DISTRICT_CODE")]
    [StringLength(15)]
    [Unicode(false)]
    public string DmDistrictCode { get; set; } = null!;

    [Column("EM_EMIRATE_ID")]
    public int EmEmirateId { get; set; }

    [Column("display_value")]
    [StringLength(240)]
    [Unicode(false)]
    public string? DisplayValue { get; set; }

    [Column("language_code")]
    public short LanguageCode { get; set; }

    [Column("deleteflag")]
    public byte Deleteflag { get; set; }
}
