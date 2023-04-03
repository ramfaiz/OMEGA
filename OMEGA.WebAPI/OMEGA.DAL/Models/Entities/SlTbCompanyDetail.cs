using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("SL_TB_COMPANY_DETAILS")]
public partial class SlTbCompanyDetail
{
    [Column("company_id")]
    public int? CompanyId { get; set; }

    [Column("company_name")]
    public string? CompanyName { get; set; }

    [Column("company_address")]
    public string? CompanyAddress { get; set; }

    [Column("GST")]
    public string? Gst { get; set; }

    [Column("logo_src")]
    public string? LogoSrc { get; set; }
}
