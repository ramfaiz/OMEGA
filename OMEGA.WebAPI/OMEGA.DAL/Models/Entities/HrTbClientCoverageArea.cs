using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("HR_TB_CLIENT_COVERAGE_AREA")]
public partial class HrTbClientCoverageArea
{
    public long? CustomerId { get; set; }

    public long? DmDistrictId { get; set; }

    public string? City { get; set; }

    public string? Zip { get; set; }
}
