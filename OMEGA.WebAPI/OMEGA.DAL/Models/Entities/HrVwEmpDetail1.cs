using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class HrVwEmpDetail1
{
    [Column("LM_LOCATION_ID")]
    public int LmLocationId { get; set; }

    [Column("SM_STATION_ID")]
    public int SmStationId { get; set; }

    [Column("dept_id")]
    public short DeptId { get; set; }

    [Column("emp_ref_no")]
    public long EmpRefNo { get; set; }

    [Column("emp_ref_code")]
    [StringLength(100)]
    public string? EmpRefCode { get; set; }

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }

    [Column("language_code")]
    public short LanguageCode { get; set; }

    [Column("empt_start_date", TypeName = "datetime")]
    public DateTime? EmptStartDate { get; set; }

    [Column("empt_end_date", TypeName = "datetime")]
    public DateTime? EmptEndDate { get; set; }

    [Column("empt_status")]
    public int? EmptStatus { get; set; }

    [Column("empt_detail_ref_no")]
    public long EmptDetailRefNo { get; set; }
}
